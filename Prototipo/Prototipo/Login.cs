using Prototipo.Prototipo;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            tbUsuario.Text = "admin";
            tbContrasenia.Text = "123";
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text;
            string contraseia = tbContrasenia.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseia))
            {

                MessageBox.Show("Ingresa un usuario para ingresar.");
            }
            if (usuario == "admin" && contraseia == "123")
            {
                PantallaPrincipal pP = new PantallaPrincipal(this, 1, 1);
                pP.Show();
                this.Hide();
            }
            if (usuario == "cajero" && contraseia == "123")
            {
                PantallaPrincipal pP = new PantallaPrincipal(this, 2, 2);
                pP.Show();
                this.Hide();
            }
            if (usuario == "admini" && contraseia == "123")
            {
                PantallaPrincipal pP = new PantallaPrincipal(this, 3, 3);
                pP.Show();
                this.Hide();
            }
            if (usuario == "contador" && contraseia == "123")
            {
                PantallaPrincipal pP = new PantallaPrincipal(this, 4, 4);
                pP.Show();
                this.Hide();
            }
        }
    }
}
