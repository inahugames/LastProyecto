using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public class Producto : IComparable<Producto> , ICloneable
    {
        private string _codigo;
        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private string _descripcion;
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
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

        private double _existencia;
        public double Existencia
        {
            get { return _existencia; }
            set { _existencia = value; }
        }

        public int CompareTo(Producto otro)
        {
            if (otro == null) return 1;
            return this.Codigo.CompareTo(otro.Codigo);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Producto()
        {
            
        }

        public Producto(int cant, string cod, string desc, int prec, double ex)
        {
            Costo = cant; // costo en este caso se usa para determinar la cantidad de productos en la operacion
            Codigo = cod;
            Descripcion = desc;
            Precio = prec;
            Existencia = ex; // uso la existencia para determinar el costo total del producto en la operacion
        }

        public Producto(string linea)
        {
            string[] datos = linea.Split(';');
            Codigo = datos[0];
            Descripcion = datos[1];
            Costo = Convert.ToInt32(datos[2]);
            Precio = Convert.ToInt32(datos[3]);
            Existencia = Convert.ToDouble(datos[4]);
        }

        public object[] GenerarObjeto()
        {
            return new object[] { Codigo, Descripcion, Costo, Precio, Existencia };
        }
    }
}
