using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public class Producto
    {
        private string _codigo;
        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        private int _costo;
        public int Costo
        {
            get { return _costo; }
            set { _costo = value; }
        }
        private int _precio;
        public int Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        private int _existencia;
        public int Existencia
        {
            get { return _existencia; }
            set { _existencia = value; }
        }

        public Producto()
        {
            
        }

        public Producto(string linea)
        {
            string[] datos = linea.Split(';');
            Codigo = datos[0];
            Costo = Convert.ToInt32(datos[1]);
            Precio = Convert.ToInt32(datos[2]);
            Existencia = Convert.ToInt32(datos[3]);
        }
    }
}
