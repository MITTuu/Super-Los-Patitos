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
    public partial class EditarProducto : Form
    {
        Dictionary<string, int> dicMedidas;
        int idProducto;
        Cnx conexion;

        public EditarProducto(string idProducto, string nombre, string codigo, string precio, string medida, string cantidad)
        {
            InitializeComponent();
            conexion = new Cnx();
            dicMedidas = new Dictionary<string, int>
            {
                { "unidad", 1 },
                { "kilogramo", 2 }
            };
            lID.Text = "ID: " + idProducto;
            int.TryParse(idProducto, out this.idProducto);
            tbNombre.Text = nombre;
            tbCodigo.Text = codigo;
            tbPrecioU.Text = precio;
            cbTipoMedida.Text = medida;
            tbCantidad.Text = cantidad;
        }

        private void ModificarProducto()
        {
            // recolectar la información
            string codigoText = tbCodigo.Text;
            string descripcionText = tbNombre.Text;
            string precioText = tbPrecioU.Text;
            string cantidadText = tbCantidad.Text;
            string medidaText = cbTipoMedida.Text;

            // validar y convertir tipos
            if (descripcionText.Length == 0)
            {
                MessageBox.Show("Es necesario agregar una descripción (nombre).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double.TryParse(precioText, out double precio);
            Decimal.TryParse(cantidadText, out Decimal cantidad);
            int medida = dicMedidas[medidaText];


            // ejecutar stored procedure
            if (conexion.ModifyProducto(idProducto, codigoText, descripcionText, precio, cantidad, medida))
            {
                MessageBox.Show("Producto modificado");
                this.Close();
            }
        }

        /// <summary>
        /// Bloquea la escritura de datos no enteros positivos en un TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckOnlyIntKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Bloquea la escritura de datos no decimales positivos en un TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Arregla un numero escrito en un TextBox para no sobrepasar <c>max</c>
        /// y no tener más de 2 decimales
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="max"></param>
        private void FixDecimalTextBox(TextBox tb, double max, int decimalDigits)
        {
            Double.TryParse(tb.Text, out Double value);
            if (value > max) tb.Text = max.ToString();
            else
            {
                tb.Text = value.ToString("0." + new string('#', decimalDigits));
            }
        }

        private void FixDecimalTextBox(TextBox tb, double max)
        {
            FixDecimalTextBox(tb, max, 2);
        }

        private void tbPrecioU_Leave(object sender, EventArgs e)
        {
            FixDecimalTextBox(tbPrecioU, 999999999.99);
        }

        private void tbCodigo_Leave(object sender, EventArgs e)
        {
            FixDecimalTextBox(tbCodigo, 999999999999999);
        }

        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbTipoMedida.Text == "unidad")
            {
                CheckOnlyIntKeyPress(sender, e);
            }
            else
            {
                CheckOnlyDecimalKeyPress(sender, e);
            }
        }

        private void cbTipoMedida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoMedida.Text == "unidad")
            {
                FixDecimalTextBox(tbCantidad, 999999999, 0);
            }
            else
            {
                FixDecimalTextBox(tbCantidad, 999999999.999);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ModificarProducto();
        }
    }
}
