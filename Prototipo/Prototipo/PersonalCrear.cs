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
    public partial class PersonalCrear : Form
    {
        public PersonalCrear()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            tbNombre.Text = string.Empty;
            tbApellido1.Text = string.Empty;
            tbApellido2.Text = string.Empty;
            tbIdentificación.Text = string.Empty;   
            tbCorreo.Text = string.Empty;
            tbContrasenia.Text = string.Empty; 
            tbTelefono.Text = string.Empty; 
            cbRol.SelectedIndex = 0;
            cbTipoI.SelectedIndex = 0;

            // Mostrar un mensaje de éxito
            MessageBox.Show("Usuario creado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void PersonalCrear_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
