using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class SQL
    {
        string conexionstring = "Server aca";

        public void Conectar()
        {
            using (SqlConnection conexion = new SqlConnection(conexionstring))
            {
                string solicitud = "SELECT etc";
                using (SqlCommand comando = new SqlCommand(solicitud, conexion))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {

                    }
                }
            }
        }
    }
}
