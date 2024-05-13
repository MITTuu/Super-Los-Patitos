using Prototipo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo.Prototipo
{
    public partial class Inventario : Form
    {
        private Cnx conexion;
        private Dictionary<string, int> dicMedidas;
        int idRol;

        public Inventario(int idRol)
        {
            InitializeComponent();
            cbTipoMedida.SelectedIndex = 0;
            conexion = new Cnx();
            this.idRol = idRol;
            dicMedidas = new Dictionary<string, int>();
            dicMedidas.Add("unidad", 1);
            dicMedidas.Add("kilogramo", 2);
        }

        private void RegistrarProducto()
        {
            // recolectar la información
            string codigoValue = tbCodigo.Text;
            string descripcion = tbDescripcion.Text;
            string precioValue = tbPrecioU.Text;
            string cantidadValue = tbCantidad.Text;
            string medidaValue = cbTipoMedida.SelectedText;

            // validar
            if (descripcion.Length == 0)
            {
                MessageBox.Show("Es necesario agregar una descripción (nombre).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            medidaValue = dicMedidas[medidaValue].ToString(); // tiene error, no existe la key??

            // ejecutar stored procedure
            if (conexion.InsertProducto(codigoValue, descripcion, precioValue, cantidadValue, medidaValue))
            {
                MessageBox.Show("Producto registrado cone exito");
                ResetRegistroUI();
            }
        }

        private void ResetRegistroUI()
        {
            tbCodigo.Text = "0";
            tbDescripcion.Text = "";
            tbPrecioU.Text = "0";
            tbCantidad.Text = "0";
            cbTipoMedida.SelectedIndex = 0;
        }

        // ------------------------------------------------------------------------
        // Event Handlers 
        // ------------------------------------------------------------------------

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarProducto EP = new EditarProducto();
            EP.Show();
        }

        private void CheckOnlyIntKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CheckOnlyDecimalKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                    e.Handled = true;
            }

            // para aceptar solo un punto decimal!
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void FixDecimalTextBox(TextBox tb, double max)
        {
            Double.TryParse(tb.Text, out Double value);
            if (value > max) tb.Text = max.ToString();
            else
            {
                tb.Text = value.ToString("0.##");
            }
        }


        private void tbPrecioU_Leave(object sender, EventArgs e)
        {
            FixDecimalTextBox(tbPrecioU, 999999999.99);
        }

        private void tbCodigo_Leave(object sender, EventArgs e)
        {
            FixDecimalTextBox(tbCodigo, 999999999999999);
        }

        private void tbCantidad_Leave(object sender, EventArgs e)
        {
            FixDecimalTextBox(tbCantidad, 99999999);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            RegistrarProducto();
        }
    }
}
