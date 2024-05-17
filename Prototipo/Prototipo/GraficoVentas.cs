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
using System.Windows.Forms.DataVisualization.Charting;

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
            // traer info
            DataTable dt = conexion.GetVentasGrafico();
            
            // Limpiar series anteriores
            grafico.Series.Clear();

            // Crear una nueva serie
            Series series = new Series("Ventas");
            series.ChartType = SeriesChartType.Bar;

            // Agregar datos de DataTable a la serie
            foreach (DataRow row in dt.Rows)
            {
                DateTime fecha = (DateTime) row["Fecha"];
                int cantidadVentas = Convert.ToInt32(row["Ventas"]);

                series.Points.AddXY(fecha, cantidadVentas);
            }

            // Agregar la serie al Chart
            grafico.Series.Add(series);
        }
    }
}
