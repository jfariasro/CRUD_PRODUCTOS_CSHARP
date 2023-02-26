using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using aplicacion.Properties;

namespace aplicacion
{
    class Conexion
    {
        public static SqlConnection variableConex = new SqlConnection("Data Source=LAPTOP-LFOM23KG;Initial Catalog=base;Integrated Security=True");

        public static void Conectar()
        {
            try
            {
                variableConex.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public static void Desconectar()
        {
            try
            {
                variableConex.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
