using Prototipo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo.Prototipo
{
    public partial class AjusteInventario : Form
    {
        Cnx conexion;
        DataTable tablaProductos;
        DataTable tablaAjustes;
        int idPersonal;

        public AjusteInventario(int idPersonal)
        {
            InitializeComponent();
            conexion = new Cnx();
            BuscarProducto();
            tablaAjustes = new DataTable();
            tablaAjustes.Columns.Add("ID");
            tablaAjustes.Columns["ID"].Unique = true;
            tablaAjustes.Columns.Add("Producto");
            tablaAjustes.Columns.Add("Ajuste");
            dgvProductosAjuste.DataSource = tablaAjustes;
            this.idPersonal = idPersonal;
        }

        private void BuscarProducto()
        {
            string busqueda = tbBusqueda.Text;
            tablaProductos = conexion.GetProductoBySearch(busqueda);
            tablaProductos.Columns.Remove("Precio");
            dgvProductos.DataSource = tablaProductos.DefaultView;
        }

        // ------------------------------------------------------------------------
        // Event Handlers 
        // ------------------------------------------------------------------------

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar seleccion de valores
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Se debe seleccionar un producto de la lista para ajustar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nudCantidadAjuste.Value == 0)
            {
                MessageBox.Show("El ajuste de inventario debe ser diferente de 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Agregar producto a la lista de ajustes por guardar
            int cantidadAjuste = (int) nudCantidadAjuste.Value;
            int cantidadActual = (int) dgvProductos.SelectedRows[0].Cells["Cantidad"].Value;
            int idProducto = (int) dgvProductos.SelectedRows[0].Cells["ID"].Value;
            string nombreProducto = dgvProductos.SelectedRows[0].Cells["Nombre"].Value.ToString();

            // Validar resta mayor a la cantidad actual
            if (cantidadActual + cantidadAjuste < 0 )
            {
                MessageBox.Show("No se puede restar una cantidad mayor que la actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try // para validar existencia del producto en la tabla de ajustes
            {
                tablaAjustes.Rows.Add(idProducto, nombreProducto, cantidadAjuste);
                dgvProductosAjuste.DataSource = tablaAjustes;
                nudCantidadAjuste.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un producto solo puede existir 1 vez por registro de ajuste.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnGaurdarAjuste_Click(object sender, EventArgs e)
        {
            // Traer info
            string razon = tbRazon.Text;

            // Guardar los ajustes en la base de datos
            int idAjuste = conexion.InsertAjuste(razon, idPersonal);
            if (idAjuste == -1)
            {
                return;
            }
            for (int i = 0; i < tablaAjustes.Rows.Count; i++)
            {
                int.TryParse(tablaAjustes.Rows[i]["ID"].ToString(), out int idProducto);
                int.TryParse(tablaAjustes.Rows[i]["Ajuste"].ToString(), out int cantidadAjuste);

                conexion.InsertAjusteProducto(idProducto, cantidadAjuste, idAjuste);
            }
            MessageBox.Show("Ajuste de inventario agregado con exito");
            tablaAjustes.Rows.Clear();
            dgvProductosAjuste.DataSource = tablaAjustes.DefaultView;
            BuscarProducto();
        }

        private void btEliminarAjuste_Click(object sender, EventArgs e)
        {
            if (dgvProductosAjuste.SelectedRows.Count == 1)
            {
                int index = dgvProductosAjuste.SelectedRows[0].Index;
                tablaAjustes.Rows.RemoveAt(index);
                dgvProductosAjuste.DataSource = tablaAjustes.DefaultView;
            }
        }
    }
}
