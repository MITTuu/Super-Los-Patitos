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
    public partial class GraficoDocumentos : Form
    {
        Cnx conexion;

        public GraficoDocumentos()
        {
            InitializeComponent();
            conexion = new Cnx();
            CargarGrafico();
        }

        private void CargarGrafico()
        {
            // traer info
            DataTable dt = conexion.GetDocumentosGrafico();

            // Limpiar series anteriores
            grafico.Series.Clear();

            // Crear una nueva serie
            Series series = new Series("Documentos");
            series.ChartType = SeriesChartType.Pie;

            // Agregar datos de DataTable a la serie
            foreach (DataRow row in dt.Rows)
            {
                string tipo = row["Tipo"].ToString();
                int cantidad = Convert.ToInt32(row["Cantidad"]);

                series.Points.AddXY(tipo, cantidad);
            }

            // Agregar la serie al Chart
            grafico.Series.Add(series);
        }
    }
}
