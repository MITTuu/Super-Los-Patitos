using Prototipo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo.Prototipo
{
    public partial class RegistrarCliente : Form
    {
        private Cnx conexion;
        public RegistrarCliente()
        {
            InitializeComponent();
            conexion = new Cnx();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string apellido1 = tbApellido1.Text;
            string apellido2 = tbApellido2.Text;
            string identificacion = tbIdentificación.Text;
            int tipoIdentificacion = cbTipoI.SelectedIndex;
            string correo = tbCorreo.Text;
            string telefono = tbTelefono.Text;

            // Validar que nombre, apellido1 y apellido2 no estén vacíos
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido1) || string.IsNullOrWhiteSpace(apellido2))
            {
                MessageBox.Show("Por favor, ingresa el nombre y los apellidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            // Validar identificación según el tipo de identificación seleccionado
            bool identificacionValida = false;
            switch (tipoIdentificacion)
            {
                case 1: // TipoIdentificacion 1: 9 dígitos sin ceros ni guiones
                    identificacionValida = Regex.IsMatch(identificacion, @"^[1-9]\d{8}$");
                    break;
                case 2: // TipoIdentificacion 2: 10 dígitos sin ceros ni guiones
                    identificacionValida = Regex.IsMatch(identificacion, @"^[1-9]\d{9}$");
                    break;
                case 3: // TipoIdentificacion 3: 11 o 12 dígitos sin ceros ni guiones
                    identificacionValida = Regex.IsMatch(identificacion, @"^[1-9]\d{10,11}$");
                    break;
                case 4: // TipoIdentificacion 4: 10 dígitos sin ceros ni guiones
                    identificacionValida = Regex.IsMatch(identificacion, @"^[1-9]\d{9}$");
                    break;
                default:
                    break;
            }

            if (!identificacionValida)
            {
                MessageBox.Show("El formato de identificación no es válido para el tipo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            // Validar que el correo tenga una terminación válida
            if (!correo.EndsWith("@gmail.com") && !correo.EndsWith("@hotmail.com"))
            {
                MessageBox.Show("Por favor, ingresa un correo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            // Validar que el teléfono sea numérico y tenga 8 dígitos
            if (!Regex.IsMatch(telefono, @"^\d{8}$"))
            {
                MessageBox.Show("Por favor, ingresa un número de teléfono válido (8 dígitos numéricos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            CrearCliente(nombre, apellido1, apellido2, correo, telefono, identificacion, tipoIdentificacion);
        }

        private void CrearCliente(string nombre, string apellido1, string apellido2, string correo, string telefono, string identificacion, int tipoI)
        {
            bool insertExitoso = conexion.InsertCliente(nombre, apellido1, apellido2, correo, telefono, identificacion, tipoI);

            if (insertExitoso)
            {
                MessageBox.Show("Cliente insertado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNombre.Text = "";
                tbApellido1.Text = "";
                tbApellido2.Text = "";
                tbIdentificación.Text = "";
                cbTipoI.SelectedIndex = 0;
                tbCorreo.Text = "";
                tbTelefono.Text = "";

                //this.Close();
            }
        }

        private void RegistrarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Si cierras esta ventana perderás los datos ingresados. ¿Estás seguro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Se cierra la ventana
            }
            else if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void RegistrarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
