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
    public partial class PersonalModificar : Form
    {
        public PersonalModificar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbNombre.Text = "Dylan";
            tbApellido1.Text = "Montiel";
            tbApellido2.Text = "Zúñiga";
            tbIdentificación.Text = "703050437";
            tbCorreo.Text = "dylanmmz01@gmail.com";
            tbContrasenia.Text = "abc123";
            tbTelefono.Text = "60234565";
            cbRol.SelectedIndex = 1;
            cbTipoI.SelectedIndex = 1;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
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
            MessageBox.Show("Usuario modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void PersonalModificar_Load(object sender, EventArgs e)
        {

        }
    }
}
