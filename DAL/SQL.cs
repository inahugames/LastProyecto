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
            SqlConnection Conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;ial Catalog=BDfactos;Data Source=Millonario91218");
            Conexion.Open();
            return Conexion;
        
        }

    }
}
