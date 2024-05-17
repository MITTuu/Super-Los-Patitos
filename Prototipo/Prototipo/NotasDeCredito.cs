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
using static System.Collections.Specialized.BitVector32;

namespace Prototipo.Prototipo
{
    public partial class NotasDeCredito : Form
    {
        private Cnx conexion;
        DataGridViewRow selectedRow;
        DataRow personalData;
        int consecutivo;

        public NotasDeCredito(DataRow personalData)
        {
            InitializeComponent();
            conexion = new Cnx();
            consecutivo = 0;
            this.personalData = personalData;
        }

        private void NotasDeCredito_Load(object sender, EventArgs e)
        {
            cargarDocumentos();
            habilitarBoton();
            actualizarConsecutivo();
        }

        private void cargarDocumentos()
        {
            DataTable documentosTable = conexion.GetDocumentos();

            if (documentosTable != null)
            {
                // Cargar la información de la consulta en el dgv
                DGVDocumentos.DataSource = documentosTable;

                DGVDocumentos.DefaultCellStyle.ForeColor = Color.Black;

                // Ocultar columna
                DGVDocumentos.Columns["idDocumento"].Visible = false;
                DGVDocumentos.Columns["idCliente"].Visible = false;

                // Organizar las columnas
                DGVDocumentos.Columns["Consecutivo"].DisplayIndex = 1;
                DGVDocumentos.Columns["TipoDocumento"].DisplayIndex = 2;
                DGVDocumentos.Columns["FechaCreacion"].DisplayIndex = 3;
                DGVDocumentos.Columns["NombrePersonal"].DisplayIndex = 4;
                DGVDocumentos.Columns["NombreCliente"].DisplayIndex = 5;
                DGVDocumentos.Columns["TotalImpuestos"].DisplayIndex = 6;
                DGVDocumentos.Columns["Subtotal"].DisplayIndex = 7;
                DGVDocumentos.Columns["Total"].DisplayIndex = 8;
                DGVDocumentos.Columns["Estado"].DisplayIndex = 9;

                // Auto size
                DGVDocumentos.Columns["Consecutivo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVDocumentos.Columns["TipoDocumento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVDocumentos.Columns["FechaCreacion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVDocumentos.Columns["NombrePersonal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVDocumentos.Columns["NombreCliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVDocumentos.Columns["TotalImpuestos"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVDocumentos.Columns["Subtotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVDocumentos.Columns["Total"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVDocumentos.Columns["Estado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                // Encabezado
                DGVDocumentos.Columns["Consecutivo"].HeaderText = "Consecutivo";
                DGVDocumentos.Columns["TipoDocumento"].HeaderText = "Tipo de Documento";
                DGVDocumentos.Columns["FechaCreacion"].HeaderText = "Fecha de Creación";
                DGVDocumentos.Columns["NombrePersonal"].HeaderText = "Responsable";
                DGVDocumentos.Columns["NombreCliente"].HeaderText = "Cliente";
                DGVDocumentos.Columns["TotalImpuestos"].HeaderText = "Impuesto";
                DGVDocumentos.Columns["Subtotal"].HeaderText = "Subtotal";
                DGVDocumentos.Columns["Total"].HeaderText = "Total";
                DGVDocumentos.Columns["Estado"].HeaderText = "Estado";
            }
        }

        private void DGVDocumentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en una celda que contiene un valor y no en encabezados
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                selectedRow = DGVDocumentos.Rows[e.RowIndex];

                if (DGVDocumentos.SelectedCells.Count > 0)
                {
                    // Acceder a los valores de las celdas en la fila seleccionada
                    lbTipoDoc.Text = "Tipo de documento: " + selectedRow.Cells["TipoDocumento"].Value.ToString();
                    
                    DateTime fechaCreacion = Convert.ToDateTime(selectedRow.Cells["FechaCreacion"].Value);
                    string fechaCorta = fechaCreacion.ToShortDateString();
                    lbFecha.Text = "Fecha de creación: " + fechaCorta;

                    lbResponsable.Text = "Facturado por: " + selectedRow.Cells["NombrePersonal"].Value.ToString();
                    
                    lbCliente.Text = "Cliente: " + selectedRow.Cells["NombreCliente"].Value.ToString();
                    
                    lbTotal.Text = "Total pagado: " + selectedRow.Cells["Total"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ninguna celda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            habilitarBoton();
        }

        private void habilitarBoton()
        {
            if (selectedRow != null)
            {
                string tipoDocumento = selectedRow.Cells["TipoDocumento"].Value.ToString();
                int estado = Convert.ToInt32(selectedRow.Cells["Estado"].Value);

                // Verificar las condiciones para habilitar o deshabilitar el botón
                if ((tipoDocumento == "Tiquete" || tipoDocumento == "Factura") && estado == 1)
                {
                    btnNT.Enabled = true;
                }
                else
                {
                    btnNT.Enabled = false;
                }
            }
            else
            {
                btnNT.Enabled = false;
            }
        }

        private void actualizarConsecutivo()
        {
            consecutivo = conexion.GetSiguienteConsecutivo(3);
        }

        private void btnNT_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                object idDocumentoObj = selectedRow.Cells["idDocumento"].Value;

                if (idDocumentoObj != DBNull.Value && idDocumentoObj != null)
                {
                    DialogResult resultado = MessageBox.Show("¿Está seguro de aplicar la nota de crédito a la factura seleecionada?. Esta acción no es reversible", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.No)
                    {
                        return;
                    }

                    int idDocumento = Convert.ToInt32(selectedRow.Cells["idDocumento"].Value);

                    DataTable productosData = conexion.GetProductosByIdDocumento(idDocumento);

                    foreach (DataRow row in productosData.Rows)
                    {
                        int idProducto = Convert.ToInt32(row["idProducto"]);
                        decimal cantidadSumar = Convert.ToDecimal(row["Cantidad"]);

                        conexion.sumaCantidadProducto(idProducto, cantidadSumar);
                    }

                    int idPersonal = Convert.ToInt32(personalData["idPersonal"]);

                    object idClienteValue = selectedRow.Cells["idCliente"].Value;
                    object idCliente = DBNull.Value;

                    if (idClienteValue != DBNull.Value && idClienteValue != null)
                    {
                        idCliente = Convert.ToInt32(idClienteValue);
                    }

                    decimal Subtotal = Convert.ToDecimal(selectedRow.Cells["Subtotal"].Value);
                    decimal TotalImp = Convert.ToDecimal(selectedRow.Cells["TotalImpuestos"].Value);
                    decimal Total = Convert.ToDecimal(selectedRow.Cells["Total"].Value);
                    actualizarConsecutivo();

                    bool insertResultDoc = conexion.InsertDocumento(3, consecutivo, idPersonal, idCliente, Subtotal, TotalImp, Total);

                    if (!insertResultDoc)
                    {
                        MessageBox.Show("Error al crear el documento: " + idDocumento, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int idNotaCredito = conexion.GetIdDocumento();

                    bool insertRelacion = conexion.InsertNotasCreditoDocumentos(idNotaCredito, idDocumento);

                    if (!insertRelacion)
                    {
                        MessageBox.Show("Error al crear la relación: " + idDocumento, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Error al obtener la información del documento seleccionado, vuelve a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Nota de crédito aplicada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDocumentos();
                actualizarConsecutivo();
            }
        }
    }
}
