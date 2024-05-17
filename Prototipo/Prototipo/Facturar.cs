using Prototipo.Modelo;
using Prototipo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace Prototipo.Prototipo
{
    public partial class Facturar : Form
    {
        DataRow personalData;
        DataRow clienteData;
        DataGridViewRow selectedRow;
        private Cnx conexion;
        int cosencutivo;
        public Facturar(DataRow personalData)
        {
            InitializeComponent();
            this.personalData = personalData;
            conexion = new Cnx();
            cbTipoDoc.SelectedIndex = 0;
            cbBuscarPor.SelectedIndex = 0;
            cosencutivo = 0;
            lbCajero.Text = "Facturado por: " + personalData["Nombre"].ToString() + " " + personalData["PrimerApellido"].ToString() + " " + personalData["SegundoApellido"].ToString();
            cargarProductos();
            tbCantidad.KeyPress += tbCantidad_KeyPress;
        }


        private void Facturar_Load(object sender, EventArgs e)
        {

        }

        private void cargarProductos()
        {
            DataTable productosTable = conexion.GetProductos();

            if (productosTable != null)
            {
                // Cargar la información de la consulta en el dgv
                DGVProductos.DataSource = productosTable;

                DGVProductos.DefaultCellStyle.ForeColor = Color.Black;

                // Ocultar columna
                DGVProductos.Columns["idProducto"].Visible = false;
                DGVProductos.Columns["idUnidadMedida"].Visible = false;

                // Organizar las columnas
                DGVProductos.Columns["Codigo"].DisplayIndex = 1;
                DGVProductos.Columns["Nombre"].DisplayIndex = 2;
                DGVProductos.Columns["PrecioUnitario"].DisplayIndex = 3;
                DGVProductos.Columns["Cantidad"].DisplayIndex = 4;
                DGVProductos.Columns["idUnidadMedida"].DisplayIndex = 5;

                // Auto size
                DGVProductos.Columns["Codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVProductos.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVProductos.Columns["PrecioUnitario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVProductos.Columns["Cantidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                // Cambiar el nombre de las columnas
                DGVProductos.Columns["Nombre"].HeaderText = "Nombre del Producto";
                DGVProductos.Columns["Codigo"].HeaderText = "Código";
                DGVProductos.Columns["PrecioUnitario"].HeaderText = "Precio Unitario";
                DGVProductos.Columns["Cantidad"].HeaderText = "Cantidad";
            }
            else
            {
                MessageBox.Show("Hubo un error al obtener los productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DGVProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en una celda que contiene un valor y no en encabezados
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener la fila correspondiente a la celda en la que se hizo clic
                selectedRow = DGVProductos.Rows[e.RowIndex];

                // Verificar si hay celdas seleccionadas en la fila
                if (DGVProductos.SelectedCells.Count > 0)
                {
                    // Acceder a los valores de las celdas en la fila seleccionada
                    tbProdSel.Text = selectedRow.Cells["Nombre"].Value.ToString();

                    string idUM = selectedRow.Cells["idUnidadMedida"].Value.ToString();
                    if (idUM == "1")
                    {
                        lbTU.Text = "c/u";
                    }
                    if (idUM == "2")
                    {
                        lbTU.Text = "kg";
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ninguna celda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DGVProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string identificacion = tbUsuario.Text;
            clienteData = conexion.GetClienteByIdentificacion(identificacion);

            if (clienteData != null)
            {
                lbCliente.Text = "Cliente: " + clienteData["Nombre"].ToString() + " " + clienteData["PrimerApellido"].ToString() + " " + clienteData["SegundoApellido"].ToString();
                lbIdentificacion.Text = "Identificación: " + clienteData["Identificacion"].ToString();
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Usuario no registrado. ¿Desea ser registrado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    lbCliente.Text = "Cliente:";
                    lbIdentificacion.Text = "Identificación:";
                    RegistrarCliente RC = new RegistrarCliente();
                    RC.Show();
                }
                else if (resultado == DialogResult.No)
                {
                    lbCliente.Text = "Cliente:";
                    lbIdentificacion.Text = "Identificación:";
                    tbUsuario.Text = "";
                    cbTipoDoc.SelectedIndex = 1;
                }
            }
        }

        private void cbTipoDoc_SelectedValueChanged(object sender, EventArgs e)
        {
            actualizarConsecutivo();
            if (cbTipoDoc.SelectedIndex == 1)
            {
                tbUsuario.Enabled = false;
                btnBuscarCliente.Enabled = false;
            }
            else
            {
                tbUsuario.Enabled = true;
                btnBuscarCliente.Enabled = true;
            }
        }

        private void actualizarConsecutivo()
        {
            cosencutivo = conexion.GetSiguienteConsecutivo(cbTipoDoc.SelectedIndex + 1);
            lbNumDoc.Text = "N° Documento: " + cosencutivo;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string caracterBuscar = tbProducto.Text.Trim();
            string buscarPor = cbBuscarPor.SelectedItem as string;

            if (string.IsNullOrEmpty(caracterBuscar))
            {
                cargarProductos();
            }

            // Validar que los campos no estén vacíos y que se haya seleccionado un criterio de búsqueda
            if (!string.IsNullOrEmpty(buscarPor))
            {
                // Determinar el tipo de búsqueda y llamar al método correspondiente
                switch (buscarPor)
                {
                    case "Nombre":
                        cargarProductosPorNombre(caracterBuscar);
                        break;
                    case "Código":
                        cargarProductosPorCodigo(caracterBuscar);
                        break;
                    default:
                        MessageBox.Show("Seleccione un tipo válido de búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un tipo de busqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarProductosPorNombre(string nombreBuscar)
        {
            DataTable productosTable = conexion.GetProductosByNombre(nombreBuscar);

            if (productosTable != null)
            {
                // Cargar la información de la consulta en el dgv
                DGVProductos.DataSource = productosTable;

                DGVProductos.DefaultCellStyle.ForeColor = Color.Black;

                // Ocultar columna
                DGVProductos.Columns["idProducto"].Visible = false;
                DGVProductos.Columns["idUnidadMedida"].Visible = false;

                // Organizar las columnas
                DGVProductos.Columns["Codigo"].DisplayIndex = 1;
                DGVProductos.Columns["Nombre"].DisplayIndex = 2;
                DGVProductos.Columns["PrecioUnitario"].DisplayIndex = 3;
                DGVProductos.Columns["Cantidad"].DisplayIndex = 4;
                DGVProductos.Columns["idUnidadMedida"].DisplayIndex = 5;

                // Auto size
                DGVProductos.Columns["Codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVProductos.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVProductos.Columns["PrecioUnitario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVProductos.Columns["Cantidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                // Cambiar el nombre de las columnas
                DGVProductos.Columns["Nombre"].HeaderText = "Nombre del Producto";
                DGVProductos.Columns["Codigo"].HeaderText = "Código";
                DGVProductos.Columns["PrecioUnitario"].HeaderText = "Precio Unitario";
                DGVProductos.Columns["Cantidad"].HeaderText = "Cantidad";
            }
            else
            {
                MessageBox.Show("Hubo un error al obtener los productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarProductosPorCodigo(string codigoBuscar)
        {
            DataTable productosTable = conexion.GetProductosByCodigo(codigoBuscar);

            if (productosTable != null)
            {
                // Cargar la información de la consulta en el dgv
                DGVProductos.DataSource = productosTable;

                DGVProductos.DefaultCellStyle.ForeColor = Color.Black;

                // Ocultar columna
                DGVProductos.Columns["idProducto"].Visible = false;
                DGVProductos.Columns["idUnidadMedida"].Visible = false;

                // Organizar las columnas
                DGVProductos.Columns["Codigo"].DisplayIndex = 1;
                DGVProductos.Columns["Nombre"].DisplayIndex = 2;
                DGVProductos.Columns["PrecioUnitario"].DisplayIndex = 3;
                DGVProductos.Columns["Cantidad"].DisplayIndex = 4;
                DGVProductos.Columns["idUnidadMedida"].DisplayIndex = 5;

                // Auto size
                DGVProductos.Columns["Codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVProductos.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVProductos.Columns["PrecioUnitario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGVProductos.Columns["Cantidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                // Cambiar el nombre de las columnas
                DGVProductos.Columns["Nombre"].HeaderText = "Nombre del Producto";
                DGVProductos.Columns["Codigo"].HeaderText = "Código";
                DGVProductos.Columns["PrecioUnitario"].HeaderText = "Precio Unitario";
                DGVProductos.Columns["Cantidad"].HeaderText = "Cantidad";
            }
            else
            {
                MessageBox.Show("Hubo un error al obtener los productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                DGVFactura.DefaultCellStyle.ForeColor = Color.Black;

                int idProducto = Convert.ToInt32(selectedRow.Cells["idProducto"].Value);
                string nombreProducto = Convert.ToString(selectedRow.Cells["Nombre"].Value);
                decimal precioUnitario = Convert.ToDecimal(selectedRow.Cells["PrecioUnitario"].Value);

                if (tbCantidad.Text == "")
                {
                    MessageBox.Show("Por favor, ingrese una cantidad del producto para agregar a la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string idUM = selectedRow.Cells["idUnidadMedida"].Value.ToString();

                decimal cantidad = 0;
                if (idUM == "1")
                {
                    // Si la unidad de medida es 1 (entero), solo permitir valores enteros
                    if (!decimal.TryParse(tbCantidad.Text, out cantidad) || cantidad % 1 != 0)
                    {
                        MessageBox.Show("La cantidad debe ser un valor entero para este producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (idUM == "2")
                {
                    // Si la unidad de medida es 2 (decimal), permitir valores enteros o decimales
                    if (!decimal.TryParse(tbCantidad.Text, out cantidad))
                    {
                        MessageBox.Show("La cantidad debe ser un valor numérico para este producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                decimal cantidadDisponible = Convert.ToDecimal(selectedRow.Cells["Cantidad"].Value);

                if (cantidad > cantidadDisponible)
                {
                    MessageBox.Show("La cantidad solicitada para el producto '" + nombreProducto + "' excede la cantidad disponible en inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool productoExistente = false;

                // Verificar si el producto ya está en la factura
                foreach (DataGridViewRow row in DGVFactura.Rows)
                {
                    if (Convert.ToInt32(row.Cells["idProducto"].Value) == idProducto)
                    {
                        // El producto ya está en la factura, sumar la cantidad
                        decimal cantidadActual = Convert.ToDecimal(row.Cells["Cantidad"].Value);
                        decimal nuevaCantidad = cantidadActual + cantidad;

                        // Verificar si la nueva cantidad excede la cantidad en el inventario
                        int cantidadInventario = Convert.ToInt32(selectedRow.Cells["Cantidad"].Value);

                        if (nuevaCantidad > cantidadInventario)
                        {
                            MessageBox.Show("No es posible agregar el producto '" + nombreProducto + "' porque excede la cantidad disponible en inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        decimal subtotalActual = Convert.ToDecimal(row.Cells["Subtotal"].Value);
                        decimal nuevoSubtotal = precioUnitario * nuevaCantidad;

                        decimal impuestoActual = Convert.ToDecimal(row.Cells["Impuesto"].Value);
                        decimal nuevoImpuesto = nuevoSubtotal * 0.13m;

                        decimal TotalActual = Convert.ToDecimal(row.Cells["Total"].Value);
                        decimal nuevoTotal = nuevoSubtotal + nuevoImpuesto;


                        // Actualizar la cantidad en la fila existente
                        row.Cells["Cantidad"].Value = nuevaCantidad;
                        row.Cells["Subtotal"].Value = nuevoSubtotal;
                        row.Cells["Impuesto"].Value = nuevoImpuesto;
                        row.Cells["Total"].Value = nuevoTotal;

                        productoExistente = true;
                        break;
                    }
                }

                if (!productoExistente)
                {
                    // Calcular subtotal, impuesto y total basado en el precio unitario y la cantidad
                    decimal subtotal = precioUnitario * cantidad;
                    decimal impuesto = subtotal * 0.13m;
                    decimal total = subtotal + impuesto;

                    // Agregar una nueva fila al DataGridView de la factura (DGVFactura)
                    DataGridViewRow facturaRow = new DataGridViewRow();
                    facturaRow.CreateCells(DGVFactura);

                    // Asignar los valores a las celdas de la nueva fila
                    facturaRow.Cells[DGVFactura.Columns["idProducto"].Index].Value = idProducto;
                    facturaRow.Cells[DGVFactura.Columns["Producto"].Index].Value = nombreProducto;
                    facturaRow.Cells[DGVFactura.Columns["PrecioUnitario"].Index].Value = precioUnitario;
                    facturaRow.Cells[DGVFactura.Columns["Cantidad"].Index].Value = cantidad;
                    facturaRow.Cells[DGVFactura.Columns["Subtotal"].Index].Value = subtotal;
                    facturaRow.Cells[DGVFactura.Columns["Impuesto"].Index].Value = impuesto;
                    facturaRow.Cells[DGVFactura.Columns["Total"].Index].Value = total;

                    DGVFactura.Rows.Add(facturaRow);
                }

                DGVProductos.ClearSelection();
                CalcularTotales();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para agregar a la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVFactura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow rowToRemove = DGVFactura.Rows[e.RowIndex];

                DialogResult result = MessageBox.Show("¿Seguro que quieres eliminar este producto de la factura?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Eliminar la fila del DataGridView de la factura
                    DGVFactura.Rows.Remove(rowToRemove);
                    CalcularTotales();
                }
            }
        }

        private void CalcularTotales()
        {
            decimal totalSubtotal = 0;
            decimal totalImpuesto = 0;
            int cantidadProd = 0;

            // Recorrer todas las filas del DataGridView de la factura (DGVFactura)
            foreach (DataGridViewRow row in DGVFactura.Rows)
            {
                // Obtener los valores de Subtotal e Impuesto de la fila actual y sumarlos
                decimal subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value);
                decimal impuesto = Convert.ToDecimal(row.Cells["Impuesto"].Value);

                totalSubtotal += subtotal;
                totalImpuesto += impuesto;
                cantidadProd += 1;
            }

            // Calcular el Total General sumando el Total Subtotal y el Total Impuesto
            decimal totalGeneral = totalSubtotal + totalImpuesto;

            // Mostrar los totales en controles de la interfaz de usuario (por ejemplo, TextBox o Label)
            lbSubtotal.Text = "Subtotal: " + totalSubtotal.ToString("C");
            lbImpuesto.Text = "Impuesto: " + totalImpuesto.ToString("C");
            lbTotal.Text = "Total: " + totalGeneral.ToString("C");
            lbCantProd.Text = "Cantidad de productos a facturar: " + cantidadProd.ToString();
        }

        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.' || e.KeyChar == ',') &&
                textBox.Text.Contains(".") || textBox.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            // Verificar si el DataGridView tiene filas
            if (DGVFactura.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la factura para facturar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idTipoDocumento = cbTipoDoc.SelectedIndex + 1;
            int idPersonal = Convert.ToInt32(personalData["idPersonal"]);
            object idCliente = DBNull.Value;
            decimal Subtotal = 0;
            decimal TotalImp = 0;
            decimal Total = 0;

            if (idTipoDocumento == 1)
            {
                if (clienteData == null)
                {
                    MessageBox.Show("Debes seleccionar un cliente para la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (clienteData != null)
                {
                    idCliente = Convert.ToInt32(clienteData["idCliente"]);
                }

            }

            // Recorrer cada fila en el DataGridView de la factura (DGVFactura)
            foreach (DataGridViewRow row in DGVFactura.Rows)
            {
                // Obtener los valores de cada celda en la fila actual
                decimal subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value);
                decimal impuesto = Convert.ToDecimal(row.Cells["Impuesto"].Value);
                decimal total = Convert.ToDecimal(row.Cells["Total"].Value);

                Subtotal += subtotal;
                TotalImp += impuesto;
                Total += total;
            }

            // Llamar al procedimiento almacenado para insertar la línea en la tabla Lineas
            actualizarConsecutivo();
            bool insertResultDoc = conexion.InsertDocumento(idTipoDocumento, cosencutivo, idPersonal, idCliente, Subtotal, TotalImp, Total);

            if (!insertResultDoc)
            {
                MessageBox.Show("Error al crear el documento: " + idProducto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idDocumento = conexion.GetIdDocumento();
            Subtotal = 0;
            TotalImp = 0;
            Total = 0;

            // Recorrer cada fila en el DataGridView de la factura (DGVFactura)
            foreach (DataGridViewRow row in DGVFactura.Rows)
            {
                // Obtener los valores de cada celda en la fila actual
                int idProducto = Convert.ToInt32(row.Cells["idProducto"].Value);
                decimal cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value);
                decimal subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value);
                decimal impuesto = Convert.ToDecimal(row.Cells["Impuesto"].Value);
                decimal total = Convert.ToDecimal(row.Cells["Total"].Value);

                Subtotal += subtotal;
                TotalImp += impuesto;
                Total += total;

                bool restaCantidad = conexion.restaCantidadProducto(idProducto, cantidad);

                if (!restaCantidad)
                {
                    MessageBox.Show("Error al restar la cantidad del producto a facturar: " + idProducto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Llamar al procedimiento almacenado para insertar la línea en la tabla Lineas
                bool insertResult = conexion.InsertLinea(idDocumento, cantidad, idProducto, subtotal, impuesto, total);

                if (!insertResult)
                {
                    MessageBox.Show("Error al facturar la línea del producto: " + idProducto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (idTipoDocumento == 1)
            {
                generarFacturaPDF();
            }

            MessageBox.Show("Factura registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DGVFactura.Rows.Clear();
            clienteData = null;
            lbCliente.Text = "Cliente: ";
            lbIdentificacion.Text = "Identificación: ";
            tbUsuario.Text = "";

            CalcularTotales();
            actualizarConsecutivo();
            cargarProductos();
        }

        private void generarFacturaPDF()
        {
            DialogResult resultado = MessageBox.Show("¿Desea generar la factura elétronica?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            try
            {
                string plantillaHTML = Properties.Resources.Plantilla.ToString();
                string nombreCliente = clienteData["Nombre"].ToString() + " " + clienteData["PrimerApellido"].ToString() + " " + clienteData["SegundoApellido"].ToString();
                string nombrePersonal = personalData["Nombre"].ToString() + " " + personalData["PrimerApellido"].ToString() + " " + personalData["SegundoApellido"].ToString();

                plantillaHTML = plantillaHTML.Replace("@COSECUTIVO", cosencutivo.ToString()); 
                plantillaHTML = plantillaHTML.Replace("@CLIENTE", nombreCliente); 
                plantillaHTML = plantillaHTML.Replace("@RESPONSABLE", nombrePersonal);
                plantillaHTML = plantillaHTML.Replace("@DOCUMENTO", "Factura");
                plantillaHTML = plantillaHTML.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy")); 

                string filasProductos = string.Empty;
                decimal subtotalTotal = 0;
                decimal impuestoTotal = 0;
                decimal total = 0;

                // Iterar sobre las filas del DataGridView para agregar las líneas de productos a la factura
                foreach (DataGridViewRow row in DGVFactura.Rows)
                {
                    string producto = row.Cells["Producto"].Value.ToString();
                    decimal precioUnitario = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);
                    decimal cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value);
                    decimal subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value);
                    decimal impuesto = Convert.ToDecimal(row.Cells["Impuesto"].Value);
                    decimal totalLinea = Convert.ToDecimal(row.Cells["Total"].Value);

                    filasProductos += $"<tr>" +
                                       $"<td>{cantidad}</td>" +
                                       $"<td>{producto}</td>" +
                                       $"<td>{precioUnitario}</td>" +
                                       $"<td>{subtotal}</td>" +
                                       $"<td>{impuesto}</td>" +
                                       $"<td>{totalLinea}</td>" +
                                       $"</tr>";

                    subtotalTotal += subtotal;
                    impuestoTotal += impuesto;
                    total += totalLinea;
                }

                plantillaHTML = plantillaHTML.Replace("@FILAS", filasProductos);
                plantillaHTML = plantillaHTML.Replace("@TSUBTOTAL", subtotalTotal.ToString("C"));
                plantillaHTML = plantillaHTML.Replace("@TIMPUESTO", impuestoTotal.ToString("C"));
                plantillaHTML = plantillaHTML.Replace("@TTOTAL", total.ToString("C"));

                string rutaFacturasGeneradas = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\FacturasGeneradas\");

                // Verificar si el directorio de facturas generadas existe, si no, crearlo
                if (!Directory.Exists(rutaFacturasGeneradas))
                {
                    Directory.CreateDirectory(rutaFacturasGeneradas);
                }

                string rutaArchivoPDF = Path.Combine(rutaFacturasGeneradas, $"Factura_{DateTime.Now.ToString("yyyyMMddHHmmss")}.pdf");

                using (FileStream stream = new FileStream(rutaArchivoPDF, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();

                    // Cargar la imagen desde los recursos
                    System.Drawing.Bitmap bmp = Properties.Resources.SP_400_;
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(bmp, System.Drawing.Imaging.ImageFormat.Png);

                    img.SetAbsolutePosition(40, pdfDoc.PageSize.Height - 80); 
                    img.ScaleAbsolute(90, 90); 

                    PdfContentByte contentByte = writer.DirectContent;
                    contentByte.AddImage(img);

                    using (StringReader sr = new StringReader(plantillaHTML))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                }

                string From = "dylanmmz01@gmail.com";
                string To = clienteData["Correo"].ToString();
                string Message = "Saludos querido cliente, le adjuntamos la factura elétronica. Gracias por su compra.";
                string Subject = "Factura Eléctronica";
                List<string> lstArchivos = new List<string>();
                lstArchivos.Add(rutaArchivoPDF);

                EnviarCorreo enviarCorreo = new EnviarCorreo(From, To, Message, Subject, lstArchivos);

                if (enviarCorreo.enviaMail())
                {
                    MessageBox.Show("Factura enviada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error al enviar el correo " + enviarCorreo.error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar la factura electrónica: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
