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
    public partial class PantallaPrincipal : Form
    {
        int idRol;
        DataRow personalData;
        bool sesion;
        Login l;

        public PantallaPrincipal(Login l,int idRol, DataRow personalData)
        {
            InitializeComponent();
            this.idRol = idRol;
            this.personalData = personalData;
            this.l = l;
            this.sesion = false;
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            lbBienvenido.Text = lbBienvenido.Text + $" {personalData["Nombre"]}!";
            if (idRol == 1)
            {
                // Apilar los paneles 
                // pnControlPersonal
                // pnFacturacion
                // pnGestionInventario
                // pnInformes
                // uno sobre otro
            }
            if (idRol == 2)
            {
                pnControlPersonal.Visible = false;
                pnGestionInventario.Visible = false;
                pnInformes.Visible = false;
                pnFacturacion.Dock = DockStyle.Top;
            }
            if (idRol == 3)
            {
                pnControlPersonal.Visible = false;
                pnFacturacion.Visible = false;
                pnInformes.Visible = false;
                pnGestionInventario.Dock = DockStyle.Top;
            }
            if (idRol == 4)
            {
                pnControlPersonal.Visible = false;
                pnFacturacion.Visible = false;
                pnGestionInventario.Visible = false;
                pnInformes.Dock = DockStyle.Top;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            String mensaje = "¿Desea cerrar la sesión?";
            DialogResult resultado = MessageBox.Show(mensaje, "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                l.Visible = true;
                sesion = true;
                this.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            abrir_Ventana(new PersonalCrear());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            abrir_Ventana(new PersonalModificar());
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            abrir_Ventana(new Facturar(personalData));
        }

        private void btnReporteFac_Click(object sender, EventArgs e)
        {
            abrir_Ventana(new Informes());
        }
        private void btnAjustesI_Click(object sender, EventArgs e)
        {
            abrir_Ventana(new Inventario(idRol));
        }

        private void btAjusteInventario_Click(object sender, EventArgs e)
        {
            abrir_Ventana(new AjusteInventario((int) personalData["idPersonal"]));
        }

        //Abrir otro form pero en un form 
        private void abrir_Ventana(object nuevaVentana)
        {
            //Verifica si hay ventanas abiertas en panelOperaciones
            if (this.pnVentana.Controls.Count > 0)
            {
                this.pnVentana.Controls.RemoveAt(0);
            }

            //Crea el objeto de la ventana y define unas propiedades
            Form f = nuevaVentana as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;

            //Agrega la ventana al panelOperaciones
            this.pnVentana.Controls.Add(f);
            this.pnVentana.Tag = f;
            f.Show();
        }

        private void pnVentana_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PantallaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            String mensaje = "¿Desea cerrar el programa?";
            DialogResult resultado = MessageBox.Show(mensaje, "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                l.Close();
            }
        }
    }
}
