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
    public partial class DetalleAjuste : Form
    {
        int idAjuste;
        Cnx conexion;

        public DetalleAjuste(int idAjuste)
        {
            InitializeComponent();
            conexion = new Cnx();
            this.idAjuste = idAjuste;
            CargarInfo();
        }

        private void CargarInfo()
        {
            // traer info de BD
            DataRow infoAjuste = conexion.GetAjusteByID(idAjuste);
            DataTable tablaAjustesProductos = conexion.GetAjustesProducto(idAjuste);

            // Actualizar GUI
            lFecha.Text = "Fecha: " + infoAjuste["Fecha"].ToString();
            lResponsable.Text = "Responsable: " + infoAjuste["Responsable"].ToString();
            lRazon.Text = infoAjuste["Razon"].ToString();
            dgvProductosAjuste.DataSource = tablaAjustesProductos;
        }


    }
}
