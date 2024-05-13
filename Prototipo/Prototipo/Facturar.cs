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

namespace Prototipo.Prototipo
{
    public partial class Facturar : Form
    {
        DataRow personalData;
        private Cnx conexion;
        public Facturar(DataRow personalData)
        {
            InitializeComponent();
            this.personalData = personalData;
            conexion = new Cnx();
            cbTipoDoc.SelectedIndex = 0;
        }

        private void Facturar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnFacturar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Facturar_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string identificacion = tbUsuario.Text;
            DataRow clienteData = conexion.GetClienteByIdentificacion(identificacion);

            if (clienteData != null)
            {
                MessageBox.Show("Cliente registrado: " + $"{clienteData["Nombre"]}");
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Usuario no registrado. ¿Desea ser registrado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    RegistrarCliente RC = new RegistrarCliente();
                    RC.Show();
                }
                else if (resultado == DialogResult.No)
                {
                    tbUsuario.Text = "";
                    cbTipoDoc.SelectedIndex = 0;
                }
            }
        }

        private void cbTipoDoc_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTipoDoc.SelectedIndex == 0)
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
    }
}
