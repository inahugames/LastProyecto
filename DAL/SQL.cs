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
        public static SqlConnection Conectar()
        {
            SqlConnection Conexion = new SqlConnection("Data Source=MILLONARIO91218;Initial Catalog=BDFactos;Integrated Security=True;Encrypt=False");
            Conexion.Open();
            return Conexion;
        }
    }
}
