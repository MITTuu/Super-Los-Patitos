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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prototipo.Prototipo {
    public partial class PersonalModificar : Form {
        private Cnx conexion;
        public PersonalModificar() {
            InitializeComponent();
            conexion = new Cnx();

        }

        //vea que opcion de busqueda, es un if, si es el del nombre el store procedure de nombre
        private void button1_Click(object sender, EventArgs e) {
            // Obtener el texto de búsqueda del TextBox
            string busqueda = tbBusqueda.Text.Trim();

            // Obtener el índice seleccionado del ComboBox
            int opcionBusqueda = cbBusqueda.SelectedIndex;

            if (!string.IsNullOrEmpty(busqueda)) {
                DataTable personalData = new DataTable();

                switch (opcionBusqueda) {
                    case 0: // Búsqueda por nombre
                        personalData = conexion.GetNombreBuscar(busqueda);
                        break;
                    case 1: // Búsqueda por identificación
                        personalData = conexion.GetCedulaBuscar(busqueda);
                        break;
                    default:
                        MessageBox.Show("Seleccione una opción de búsqueda válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                // Asignar los resultados de la búsqueda al DataGridView
                dgvPersonal.DataSource = personalData;
            } else {
                MessageBox.Show("Ingrese un texto de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnModificar_Click_1(object sender, EventArgs e) {

            if (dgvPersonal.SelectedRows.Count == 0) {
                ObtenerIdPersonalSeleccionado();
                return;
            }

            // Obtener los valores actualizados de los campos del formulario
            string nombre = tbNombre.Text;
            string primerApellido = tbApellido1.Text;
            string segundoApellido = tbApellido2.Text;
            string correo = tbCorreo.Text;
            string contrasena = tbContrasenia.Text;
            string telefono = tbTelefono.Text;
            bool estado = cbEstado.SelectedIndex == 1;
            string identificacion = tbIdentificación.Text;
            int idTipoIdentificacion = Convert.ToInt32(cbTipoI.SelectedIndex);
            int idRol = Convert.ToInt32(cbRol.SelectedIndex);

            // Obtener el idPersonal de la fila seleccionada
            int idPersonal = Convert.ToInt32(dgvPersonal.SelectedRows[0].Cells["idPersonal"].Value);

            if (idPersonal != -1) {
                if (conexion.UpdatePersonal(idPersonal, nombre, primerApellido, segundoApellido, correo, contrasena, telefono, estado, identificacion, idTipoIdentificacion, idRol)) {
                    MessageBox.Show("Usuario modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Actualizar la vista de los datos después de la modificación
                    LoadPersonalData();
                } else {
                    MessageBox.Show("No se pudo modificar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show("Datos actualizados correctamente.");
            }
        }
        private int ObtenerIdPersonalSeleccionado() {
            // Asegurarse de que hay al menos una fila seleccionada
            if (dgvPersonal.SelectedRows.Count > 0) {

                // Obtener el valor del idPersonal de la fila seleccionada
                int idPersonal = Convert.ToInt32(dgvPersonal.SelectedRows[1].Cells["idPersonal"].Value);

                return idPersonal;

            } else {
                // Si no hay filas seleccionadas, mostrar un mensaje de error y devolver -1
                MessageBox.Show("No se ha seleccionado ningún personal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }


        private void PersonalModificar_Load(object sender, EventArgs e) {
            LoadPersonalData();
        }



        private void LoadPersonalData() {

            DataTable personalData = conexion.GetAllPersonal();
            if (personalData != null) {
                dgvPersonal.DataSource = personalData;
                dgvPersonal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                
            } else {
                MessageBox.Show("No se pudieron cargar los datos del personal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cbBusqueda_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void dgvPersonal_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            // Obtener la fila actual
            DataGridViewRow row = dgvPersonal.Rows[e.RowIndex];

            // Asignar los valores de las celdas a los TextBoxes y ComboBoxes
            tbNombre.Text = row.Cells[0].Value.ToString();
            tbApellido1.Text = row.Cells[1].Value.ToString();
            tbApellido2.Text = row.Cells[2].Value.ToString();
            tbCorreo.Text = row.Cells[3].Value.ToString();
            tbContrasenia.Text = row.Cells[4].Value.ToString();
            tbTelefono.Text = row.Cells[5].Value.ToString();
            tbIdentificación.Text = row.Cells[6].Value.ToString();
            cbTipoI.SelectedIndex = Convert.ToInt32(row.Cells[7].Value);
            cbRol.SelectedIndex = Convert.ToInt32(row.Cells[8].Value);


            int contrasenaIndex = row.Cells.IndexOf(row.Cells.Cast<DataGridViewCell>().FirstOrDefault(c => c.OwningColumn.Name == "Contrasena"));
            if (contrasenaIndex != -1) {
                tbContrasenia.Text = row.Cells[contrasenaIndex].Value.ToString();
            } else {
                tbContrasenia.Text = string.Empty; // O cualquier otro valor predeterminado que desees
            }

            int estadoIndex = row.Cells.IndexOf(row.Cells.Cast<DataGridViewCell>().FirstOrDefault(c => c.OwningColumn.Name == "Estado"));
            if (estadoIndex != -1) {
                cbEstado.SelectedIndex = Convert.ToInt32(row.Cells[estadoIndex].Value);
            } else {
                cbEstado.SelectedIndex = -1; // O cualquier otro valor predeterminado que desees
            }
        }

        private void dgvPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
