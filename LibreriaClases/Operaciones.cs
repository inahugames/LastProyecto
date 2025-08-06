using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public class Operaciones
    {
        public List<Producto> ListCompra = new List<Producto>();
        
        private int _num;
        public int Num
        { 
            get { return _num; }
            set { _num = value; }
        }

        private DateTime _fecha;
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        
        private double _cuitcliente;
        public double CUITCliente
        {
            get { return _cuitcliente; }
            set { _cuitcliente = value; }
        }

        private string _razoncliente;
        public string RazonCliente
        {
            get { return _razoncliente; }
            set { _razoncliente = value; }
        }

        private string _mediopago;
        public string MedioPago
        {
            get { return _mediopago; }
            set { _mediopago = value; }
        }

        private bool _habilitada;
        public bool Habilitada
        {
            get { return _habilitada; }
            set { _habilitada = value; }
        }

        public Operaciones()
        {
            
        }

        public Operaciones(string linea)
        {
            string[] datos = linea.Split(';');
            Num = int.Parse(datos[0]);
            Fecha = Convert.ToDateTime(datos[1]);
            CUITCliente = int.Parse(datos[2]);
            RazonCliente = datos[3];
            MedioPago = datos[4];
            Habilitada = Convert.ToBoolean(datos[5]);
        }

        public string GeneraLinea()
        {
            string compra = null;
            int n = 0;
            while ( n < ListCompra.Count )
            {
                compra += "," + ListCompra[n].Costo + "," + ListCompra[n].Codigo + "," + ListCompra[n].Descripcion + "," + ListCompra[n].Precio + "," + ListCompra[n].Existencia;
                n++;
            }
            return Num + ";" + Fecha + ";" + CUITCliente + ";" + RazonCliente + ";"+ MedioPago + ";" + Habilitada + ";" + compra;
        }

        public void AñadirLista(Producto prod)
        {
            ListCompra.Add(prod);
        }

        public string GeneraLineaCompra()
        {
            int n = 0;
            string detalles = null;
            while ( n < ListCompra.Count )
            {
                detalles += ListCompra[n].Costo + "\t\t" + ListCompra[n].Codigo + "\t\t" + ListCompra[n].Descripcion + "\t\t\t" + ListCompra[n].Precio + "\t\t\t" + ListCompra[n].Existencia + "\r\n";
                n++;
            }
            return detalles;
        }

        public string DatosCompra()
        {
            string datos = null;
            foreach ( Producto prod in ListCompra )
            {
                datos += prod.Codigo + ";" + prod.Costo + ";"; 
            }
            return datos;
        }

        public object[] GenerarObjeto()
        {
            return new object[] { Num, Fecha, CUITCliente, RazonCliente, MedioPago, Habilitada };
        }

        public string[] GenerarVector()
        {
            return new string[] { Convert.ToString(Num), Convert.ToString(Fecha), Convert.ToString(CUITCliente), RazonCliente, MedioPago, Convert.ToString(Habilitada) };
        }
    }
}
