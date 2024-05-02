using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Los_Patitos.Modelo
{
    internal class Cnx
    {
        public SqlConnection cnx;

        public Cnx()
        {
            try
            {
                cnx = new SqlConnection("Data Source=DYLAN;Initial Catalog=SuperLosPatitos;Integrated Security=True");
                cnx.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}