using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Prototipo.Modelo
{
    internal class Cnx
    {
        private readonly string connectionString = $"Data Source={Environment.MachineName};Initial Catalog=SuperPatitosDB;Integrated Security=True";

        public Cnx()
        {
            try
            {

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK);
            }
        }

        public DataRow GetPersonalByEmailPassword(string correo, string contrasena)
        {
            DataRow personalData = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("GetPersonalByEmailPassword", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@Contrasena", contrasena);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        // El usuario y contraseña son válidos, devuelve la fila de datos del personal
                        personalData = dataTable.Rows[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
            }

            return personalData;
        }

        public DataRow GetPersonalByID(int idPersonal)
        {
            DataRow personalData = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("GetPersonalByID", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@idPersonal", idPersonal);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        personalData = dataTable.Rows[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
            }

            return personalData;
        }

        public DataRow GetClienteByIdentificacion(string identificacion)
        {
            DataRow clienteData = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("GetClienteByIdentificacion", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@identificacion", identificacion);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        clienteData = dataTable.Rows[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
            }

            return clienteData;
        }


        public bool InsertCliente(string nombre, string primerApellido, string segundoApellido, string correo, string telefono, string identificacion, int idTipoIdentificacion)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("InsertCliente", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@PrimerApellido", primerApellido);
                    command.Parameters.AddWithValue("@SegundoApellido", segundoApellido);
                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Identificacion", identificacion);
                    command.Parameters.AddWithValue("@idTipoIdentificacion", idTipoIdentificacion);

                    command.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
        }

        public DataTable GetProductos()
        {
            DataTable productosData = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("GetProductos", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        productosData = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
            }

            return productosData;
        }

        public DataTable GetProductosByNombre(string nombreBuscar)
        {
            DataTable productosData = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("GetProductosByNombre", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NombreBuscar", nombreBuscar);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        productosData = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
            }

            return productosData;
        }

        public DataTable GetProductosByCodigo(string codigoBuscar)
        {
            DataTable productosData = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("GetProductosByCodigo", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@codigoBuscar", codigoBuscar);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        productosData = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
            }

            return productosData;
        }

        public int GetSiguienteConsecutivo(int idTipoDocumento)
        {
            int siguienteConsecutivo = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("GetSiguienteConsecutivo", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@idTipoDocumento", idTipoDocumento);

                    // Ejecutar el comando y obtener el resultado (siguiente consecutivo)
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            siguienteConsecutivo = Convert.ToInt32(reader["SiguienteConsecutivo"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el siguiente consecutivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return siguienteConsecutivo;
        }

        public bool InsertLinea(int idDocumento, decimal cantidad, int idProducto, decimal subtotal, decimal impuesto, decimal total)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("InsertLinea", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@idDocumento", idDocumento);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@idProducto", idProducto);
                    command.Parameters.AddWithValue("@Subtotal", subtotal);
                    command.Parameters.AddWithValue("@Impuesto", impuesto);
                    command.Parameters.AddWithValue("@Total", total);

                    command.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la linea: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool InsertDocumento(int idTipoDocumento, int consecutivo, int idPersonal, object idCliente, decimal Subtotal, decimal TotalImp, decimal Total)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("InsertDocumento", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@idTipoDocumento", idTipoDocumento);
                    command.Parameters.AddWithValue("@Consecutivo", consecutivo);
                    command.Parameters.AddWithValue("@idPersonal", idPersonal);
                    command.Parameters.AddWithValue("@idCliente", idCliente);
                    command.Parameters.AddWithValue("@Subtotal", Subtotal);
                    command.Parameters.AddWithValue("@TotalImpuestos", TotalImp);
                    command.Parameters.AddWithValue("@Total", Total);

                    command.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el documento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool InsertNotasCreditoDocumentos(int idNotaCredito, int idDocumentoRelacionado)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("InsertNotasCreditoDocumentos", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@idNotaCredito", idNotaCredito);
                    command.Parameters.AddWithValue("@idDocumentoRelacionado", idDocumentoRelacionado);

                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        public int GetIdDocumento()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("GetIdDoc", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        // Si no se encontró ningún idDocumento en la tabla
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el idDocumento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public bool restaCantidadProducto(int idProducto, decimal cantidadRestar)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("RestaCantidadProducto", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@idProducto", idProducto);
                    command.Parameters.AddWithValue("@CantidadResta", cantidadRestar);


                    command.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restar la cantidad del producto a facturar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable GetDocumentos()
        {
            DataTable documentosData = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("GetDocumentos", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        documentosData = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
            }

            return documentosData;
        }

        public DataTable GetProductosByIdDocumento(int idDocumento)
        {
            DataTable productosData = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("GetProductosByIdDocumento", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@idDocumento", idDocumento);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        productosData = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
            return productosData;
        }

        public bool sumaCantidadProducto(int idProducto, decimal cantidadSumar)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SumaCantidadProducto", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@idProducto", idProducto);
                    command.Parameters.AddWithValue("@CantidadSuma", cantidadSumar);


                    command.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restar la cantidad del producto a facturar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public bool InsertProducto(string codigo, string descripcion, double precio, Decimal cantidad, int medida)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("InsertProducto", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Nombre", descripcion);
                    command.Parameters.AddWithValue("@Codigo", codigo);
                    command.Parameters.AddWithValue("@PrecioUnitario", precio);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@idUnidadMedida", medida);

                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        public bool ModifyProducto(int idProducto, string codigo, string descripcion, double precio, Decimal cantidad, int medida)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("ModifyProducto", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@idProducto", idProducto);
                    command.Parameters.AddWithValue("@Nombre", descripcion);
                    command.Parameters.AddWithValue("@Codigo", codigo);
                    command.Parameters.AddWithValue("@PrecioUnitario", precio);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@idUnidadMedida", medida);

                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        public DataTable GetProductoBySearch(string busqueda)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SelectProductoCoincidencia", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@busqueda", busqueda);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
            }

            return dt;
        }

        /// <summary>
        /// Inserta un ajuste en la BD
        /// </summary>
        /// <param name="razon"></param>
        /// <param name="idPersonalResponsable"></param>
        /// <returns>ID del ajuste generado, -1 en caso de error</returns>
        public int InsertAjuste(string razon, int idPersonalResponsable)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("InsertAjuste", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Razon", razon);
                    command.Parameters.AddWithValue("@idPersonal", idPersonalResponsable);

                    int.TryParse(command.ExecuteScalar().ToString(), out int idAjuste);
                    return idAjuste;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
                return -1;
            }
        }

        public bool InsertAjusteProducto(int idProducto, Decimal cantidadAjuste, int idAjuste)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("InsertAjusteProducto", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@idProducto", idProducto);
                    command.Parameters.AddWithValue("@CantidadAjustada", cantidadAjuste);
                    command.Parameters.AddWithValue("@idAjuste", idAjuste);

                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        public DataTable GetAjustes()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SelectAjustes", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
            }

            return dt;
        }

        public DataTable GetAjustesProducto(int idAjuste)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SelectAjustesProdutos", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@idAjuste", idAjuste);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
            }

            return dt;
        }

        public DataRow GetAjusteByID(int idAjuste)
        {
            DataRow infoAjuste = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SelectAjusteById", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@idAjuste", idAjuste);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        infoAjuste = dataTable.Rows[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
            }

            return infoAjuste;
        }
    }
}
