using Prototipo.Modelo;
using Prototipo.Prototipo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo.Prototipo
{
    public partial class Login : Form
    {
        private Cnx conexion;
        public Login()
        {
            InitializeComponent();
            conexion = new Cnx();
            tbUsuario.Text = "dylanmmz01@gmail.com";
            tbContrasenia.Text = "Dylan.1234";
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text;
            string contrasena = tbContrasenia.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {

                MessageBox.Show("Ingresa un usuario para ingresar.");
            }

            DataRow personalData = conexion.GetPersonalByEmailPassword(usuario, contrasena);

            if (personalData != null)
            {
                // Usuario y contraseña válidos
                int idRol = Convert.ToInt32(personalData["idRol"]);
                int idPersonal = Convert.ToInt32(personalData["idPersonal"]);

                PantallaPrincipal pP = new PantallaPrincipal(this, idRol, personalData);
                pP.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
