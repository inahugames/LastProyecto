using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public class Cliente
    {
        
        private float _CUIT;
        public float CUIT
        {
            get { return _CUIT; }
            set { _CUIT = value; }
        }

        public Cliente()
        {
            
        }

        public Cliente(string linea)
        {
            string[] datos = linea.Split(';');
            CUIT = float.Parse(datos[0]);
        }
    }
}
