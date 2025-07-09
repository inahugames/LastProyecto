using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public class Administrador : Persona
    {
        public Administrador(string linea)
        {
            string[] datos = linea.Split(';');
            Usuario = datos[0];
            Contraseña = datos[1];
        }
    }
}
