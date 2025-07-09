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

        private string _razon;
        public string Razon
        {
            get { return _razon; }
            set { _razon = value; }
        }

        public Cliente()
        {
            
        }

        public Cliente(string linea)
        {
            string[] datos = linea.Split(';');
            CUIT = float.Parse(datos[0]);
            Razon = datos[1];
        }

        public object[] GenerarObjeto()
        {
            return new object[] { CUIT, Razon };
        }
    }
}
