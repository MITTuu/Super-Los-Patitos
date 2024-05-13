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
            BuscarProducto();
            this.idRol = idRol;
            dicMedidas = new Dictionary<string, int>
            {
                { "unidad", 1 },
                { "kilogramo", 2 }
            };
        }

        /// <summary>
        /// Guarda en la base de datos los datos del producto registrado en la GUI
        /// </summary>
        private void RegistrarProducto()
        {
            // recolectar la información
            string codigoText = tbCodigo.Text;
            string descripcionText = tbDescripcion.Text;
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

            int.TryParse(cantidadText, out int cantidad);

            int medida = dicMedidas[medidaText];


            // ejecutar stored procedure
            if (conexion.InsertProducto(codigoText, descripcionText, precio, cantidad, medida))
            {
                MessageBox.Show("Producto registrado con exito");
                ResetRegistroUI();
            }
        }

        /// <summary>
        /// Coloca los valores iniciales de los elementos de la sección de registro de producto
        /// </summary>
        private void ResetRegistroUI()
        {
            tbCodigo.Text = "0";
            tbDescripcion.Text = "";
            tbPrecioU.Text = "0";
            tbCantidad.Text = "0";
            cbTipoMedida.SelectedIndex = 0;
        }

        private void BuscarProducto()
        {
            string busqueda = tbBusqueda.Text;
            DataTable dt = conexion.GetProductoBySearch(busqueda);
            dgvProductos.DataSource = dt.DefaultView;
        }

        // ------------------------------------------------------------------------
        // Event Handlers 
        // ------------------------------------------------------------------------

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarProducto EP = new EditarProducto();
            EP.Show();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }
    }
}
