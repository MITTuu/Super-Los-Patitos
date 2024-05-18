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
        DataTable tablaProductosAjuste;
        DataTable tablaAjustes;
        int idPersonal;
        string medidaSeleccionada;

        public AjusteInventario(int idPersonal)
        {
            InitializeComponent();
            conexion = new Cnx();
            BuscarProducto();
            CargarHistorialAjustes();
            tablaProductosAjuste = new DataTable();
            tablaProductosAjuste.Columns.Add("ID");
            tablaProductosAjuste.Columns["ID"].Unique = true;
            tablaProductosAjuste.Columns.Add("Producto");
            tablaProductosAjuste.Columns.Add("Ajuste");
            dgvProductosAjuste.DataSource = tablaProductosAjuste;
            this.idPersonal = idPersonal;
        }

        /// <summary>
        /// Busca el producto basado en el texto que se encuentre en el textBox de busqueda
        /// </summary>
        private void BuscarProducto()
        {
            string busqueda = tbBusqueda.Text;
            tablaProductos = conexion.GetProductoBySearch(busqueda);
            tablaProductos.Columns.Remove("Codigo");
            tablaProductos.Columns.Remove("Precio");
            dgvProductos.DataSource = tablaProductos.DefaultView;
        }

        /// <summary>
        /// Carga la informacion de los ajustes realizados en el DataGridView
        /// </summary>
        private void CargarHistorialAjustes()
        {
            tablaAjustes = conexion.GetAjustes();
            dgvAjustes.DataSource = tablaAjustes;
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
            Decimal.TryParse(nudCantidadAjuste.Value.ToString(), out Decimal cantidadAjuste);
            Decimal.TryParse(dgvProductos.SelectedRows[0].Cells["Cantidad"].Value.ToString(), out Decimal cantidadActual);
            int idProducto = (int) dgvProductos.SelectedRows[0].Cells["ID"].Value;
            string nombreProducto = dgvProductos.SelectedRows[0].Cells["Nombre"].Value.ToString();

            // Ajustar cantidad si es unitario (sin decimales)
            if (medidaSeleccionada == "unidad")
            {
                cantidadAjuste = Math.Floor(cantidadAjuste);
            }

            // Validar resta mayor a la cantidad actual
            if (cantidadActual + cantidadAjuste < 0 )
            {
                MessageBox.Show("No se puede restar una cantidad mayor que la actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try // para validar existencia del producto en la tabla de ajustes
            {
                tablaProductosAjuste.Rows.Add(idProducto, nombreProducto, cantidadAjuste);
                dgvProductosAjuste.DataSource = tablaProductosAjuste;
                nudCantidadAjuste.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un producto solo puede existir 1 vez por registro de ajuste.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// Valida y Guarda el ajuste en la BD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGaurdarAjuste_Click(object sender, EventArgs e)
        {
            // Validar exitencia de info
            if (tablaProductosAjuste.Rows.Count == 0 || tbRazon.Text == "") 
            {
                MessageBox.Show("No hay suficiente información para guardar el ajuste", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Traer info
            string razon = tbRazon.Text;

            // Guardar los ajustes en la base de datos
            int idAjuste = conexion.InsertAjuste(razon, idPersonal);
            if (idAjuste == -1)
            {
                return;
            }
            for (int i = 0; i < tablaProductosAjuste.Rows.Count; i++)
            {
                int.TryParse(tablaProductosAjuste.Rows[i]["ID"].ToString(), out int idProducto);
                Decimal.TryParse(tablaProductosAjuste.Rows[i]["Ajuste"].ToString(), out Decimal cantidadAjuste);

                conexion.InsertAjusteProducto(idProducto, cantidadAjuste, idAjuste);
            }

            //  Finalizado
            MessageBox.Show("Ajuste de inventario agregado con exito");
            tablaProductosAjuste.Rows.Clear();
            dgvProductosAjuste.DataSource = tablaProductosAjuste.DefaultView;
            BuscarProducto();
            CargarHistorialAjustes();
        }

        /// <summary>
        /// Elimina un ajuste de producto de la lista de registrar ajuste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEliminarAjuste_Click(object sender, EventArgs e)
        {
            if (dgvProductosAjuste.SelectedRows.Count == 1)
            {
                int index = dgvProductosAjuste.SelectedRows[0].Index;
                tablaProductosAjuste.Rows.RemoveAt(index);
                dgvProductosAjuste.DataSource = tablaProductosAjuste.DefaultView;
            }
        }

        private void dgvAjustes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idAjuste = (int) dgvAjustes.SelectedRows[0].Cells["ID"].Value;
            DetalleAjuste detalleAjusteWindow = new DetalleAjuste(idAjuste);
            detalleAjusteWindow.ShowDialog();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedIndex = dgvProductos.SelectedRows[0].Index;
            medidaSeleccionada = tablaProductos.Rows[selectedIndex]["Medida"].ToString();
        }

        private void nudCantidadAjuste_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
