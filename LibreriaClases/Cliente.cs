using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public class Cliente
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        
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
            ID = Convert.ToInt32(datos[0]);
            CUIT = float.Parse(datos[1]);
        }
    }
}
