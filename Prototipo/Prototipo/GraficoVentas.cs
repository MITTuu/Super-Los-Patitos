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
    public partial class GraficoVentas : Form
    {
        Cnx conexion;

        public GraficoVentas()
        {
            InitializeComponent();
            conexion = new Cnx();
            CargarGrafico();
        }

        private void CargarGrafico()
        {
            
            DataView dv = conexion.GetVentasGrafico().DefaultView;
            if (dv == null )
            {
                return;
            }
            grafico.DataSource = dv;
        }
    }
}
