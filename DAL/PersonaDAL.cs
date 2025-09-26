using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LibreriaClases;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DAL
{
    public class PersonaDAL
    {
        public static int AgregarAdmin(Administrador admin)
        {
            int retorna = 0;

            using (SqlConnection conexion = SQL.Conectar())
            {
                string consulta = "insert into Administradores values('"+admin.Usuario+"','"+admin.Contraseña+"')";
                SqlCommand comando = new SqlCommand(consulta,conexion);
                retorna = comando.ExecuteNonQuery();
            }

            return retorna;
        }
    }
}
