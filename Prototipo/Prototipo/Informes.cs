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
    public partial class Informes : Form
    {
        private Cnx conexion;
        DataTable informesData = null;
        private DateTime? fechaSeleccionada;
        private DateTime? fechaInicio;
        private DateTime? fechaFin;
        public Informes()
        {
            InitializeComponent();
            conexion = new Cnx();   
        }
        private void Informes_Load(object sender, EventArgs e)
        {
            productoMasVendido();
            cargarTop5ClientesData();
        }

        private void DTPCalendario_ValueChanged(object sender, EventArgs e)
        {
            fechaSeleccionada = DTPCalendario.Value;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (!fechaSeleccionada.HasValue)
            {
                MessageBox.Show("Por favor, seleccione una fecha del calendario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (fechaFin.HasValue && fechaFin.Value < fechaSeleccionada.Value)
            {
                MessageBox.Show("La fecha inicio no puede ser mayor a la fecha de final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            fechaInicio = fechaSeleccionada.Value;
            tbFechaIni.Text = fechaInicio.Value.ToString("dd/MM/yyyy");
        }

        private void btnFechaFin_Click(object sender, EventArgs e)
        {
            if (!fechaSeleccionada.HasValue)
            {
                MessageBox.Show("Por favor, seleccione una fecha del calendario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            fechaFin = fechaSeleccionada.Value;

            if (fechaInicio.HasValue && fechaSeleccionada.Value < fechaInicio.Value)
            {
                MessageBox.Show("La fecha final no puede ser menor a la fecha de inicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tbFechaFin.Text = fechaFin.Value.ToString("dd/MM/yyyy");
        }

        private void btnReporteFacturas_Click(object sender, EventArgs e)
        {
            if (!fechaInicio.HasValue || !fechaFin.HasValue)
            {
                MessageBox.Show("Por favor, seleccione un rango de fechas para el informe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            informesData = conexion.GetDocumentosIF(fechaInicio.Value, fechaFin.Value);

            if (informesData == null)
            {
                MessageBox.Show("No se encontraron facturas registradas en el rango de fechas seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (informesData != null)
            {
                // Cargar la información de la consulta en el dgv
                DGVInforme.DataSource = informesData;

                DGVInforme.DefaultCellStyle.ForeColor = Color.Black;

                // Ocultar columna
                DGVInforme.Columns["idDocumento"].Visible = false;
                DGVInforme.Columns["idCliente"].Visible = false;
                DGVInforme.Columns["Estado"].Visible = false;

                // Organizar las columnas
                DGVInforme.Columns["Consecutivo"].DisplayIndex = 1;
                DGVInforme.Columns["TipoDocumento"].DisplayIndex = 2;
                DGVInforme.Columns["FechaCreacion"].DisplayIndex = 3;
                DGVInforme.Columns["NombrePersonal"].DisplayIndex = 4;
                DGVInforme.Columns["NombreCliente"].DisplayIndex = 5;
                DGVInforme.Columns["TotalImpuestos"].DisplayIndex = 6;
                DGVInforme.Columns["Subtotal"].DisplayIndex = 7;
                DGVInforme.Columns["Total"].DisplayIndex = 8;

                // Auto size
                DGVInforme.Columns["Consecutivo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVInforme.Columns["TipoDocumento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVInforme.Columns["FechaCreacion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVInforme.Columns["NombrePersonal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVInforme.Columns["NombreCliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVInforme.Columns["TotalImpuestos"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVInforme.Columns["Subtotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVInforme.Columns["Total"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                // Encabezado
                DGVInforme.Columns["Consecutivo"].HeaderText = "Consecutivo";
                DGVInforme.Columns["TipoDocumento"].HeaderText = "Tipo de Documento";
                DGVInforme.Columns["FechaCreacion"].HeaderText = "Fecha de Creación";
                DGVInforme.Columns["NombrePersonal"].HeaderText = "Responsable";
                DGVInforme.Columns["NombreCliente"].HeaderText = "Cliente";
                DGVInforme.Columns["TotalImpuestos"].HeaderText = "Impuesto";
                DGVInforme.Columns["Subtotal"].HeaderText = "Subtotal";
                DGVInforme.Columns["Total"].HeaderText = "Total";
                DGVInforme.Columns["Estado"].HeaderText = "Estado";
            }
        }

        private void btnTop10Prod_Click(object sender, EventArgs e)
        {

        }

        private void productoMasVendido()
        {
            DataTable productoData = conexion.GetProductoMasVendido();

            if (productoData == null)
            {
                MessageBox.Show("Hubo un problema al obtener el producto mas vendido.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (productoData != null)
            {
                DataRow filaProducto = productoData.Rows[0];
                string nombreProducto = filaProducto["Producto"].ToString();
                decimal cantidadVendida = Convert.ToDecimal(filaProducto["TotalVendido"]);

                lbProducto.Text = "Producto: " + nombreProducto;
                lbCantidad.Text = "Cantidad: " + cantidadVendida.ToString("0.00");
            }
        }

        private void cargarTop5ClientesData()
        {
            DataTable clientesData = conexion.GetTop5ClientesQueMasCompran();

            if (clientesData == null)
            {
                MessageBox.Show("Hubo un problema el top 5 clientes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (clientesData != null)
            {
                // Cargar la información de la consulta en el dgv
                DGVClientes.DataSource = clientesData;

                DGVClientes.DefaultCellStyle.ForeColor = Color.Black;

                // Organizar las columnas
                DGVClientes.Columns["Identificacion"].DisplayIndex = 0;
                DGVClientes.Columns["NombreCompleto"].DisplayIndex = 1;
                DGVClientes.Columns["CantidadDocumentos"].DisplayIndex = 2;

                // Encabezado
                DGVClientes.Columns["Identificacion"].HeaderText = "Identificación";
                DGVClientes.Columns["NombreCompleto"].HeaderText = "Nombre completo";
                DGVClientes.Columns["CantidadDocumentos"].HeaderText = "Documentos";

                // Auto size
                DGVClientes.Columns["Identificacion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVClientes.Columns["NombreCompleto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVClientes.Columns["CantidadDocumentos"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
