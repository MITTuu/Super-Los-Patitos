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
    public partial class RegistrarCliente : Form
    {
        public RegistrarCliente()
        {
            InitializeComponent();
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
            
            // Se debe validar lo siguiente:

            // nombre, apellido1, apellido2 no deben ser vacios

            // identificacion:
            // si tipoIdentificacion es 1, DEBE TENER 9 DÍGITOS, SIN CERO AL INICIO NI GUIONES.
            // si tipoIdentificacion es 2, DEBE TENER 10 DÍGITOS, SIN CERO AL INICIO NI GUIONES.
            // si tipoIdentificacion es 3, DEBE TENER 11 O 12 DÍGITOS, SIN CERO AL INICIO NI GUIONES.  
            // si tipoIdentificacion es 4, DEBE TENER 10 DÍGITOS, SIN CERO AL INICIO NI GUIONES.

            // El correo debe tener una terminacion valida

            // El telefono debe ser numerico, con 8 digitos
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
    }
}
