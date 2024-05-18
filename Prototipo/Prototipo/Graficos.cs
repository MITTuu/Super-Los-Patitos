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
    public partial class Graficos : Form
    {
        public Graficos()
        {
            InitializeComponent();
        }

        

        //Abrir otro form pero en un form 
        private void abrir_Ventana(object nuevaVentana)
        {
            //Verifica si hay ventanas abiertas en panelOperaciones
            if (this.pVisualizadorGraficos.Controls.Count > 0)
            {
                this.pVisualizadorGraficos.Controls.RemoveAt(0);
            }

            //Crea el objeto de la ventana y define unas propiedades
            Form f = nuevaVentana as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;

            //Agrega la ventana al panelOperaciones
            this.pVisualizadorGraficos.Controls.Add(f);
            this.pVisualizadorGraficos.Tag = f;
            f.Show();
        }

        // ------------------------------------------
        // EVENTOS DE BOTONES PARA ACCEDER A GRAFICOS
        // ------------------------------------------

        private void btnGrafico1_Click(object sender, EventArgs e)
        {
            abrir_Ventana(new GraficoVentas());
        }

        private void btnGrafico2_Click(object sender, EventArgs e)
        {
            abrir_Ventana(new GraficoDocumentos());
        }
    }
}
