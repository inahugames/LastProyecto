using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public class Operaciones
    {
        private int _num;
        public int Num
        { 
            get { return _num; }
            set { _num = value; }
        }

        private string _fecha;
        public string Fecha
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

        private string _codigoproducto;
        public string CodigoProducto
        {
            get { return _codigoproducto; }
            set { _codigoproducto = value; }
        }

        private string _mediopago;
        public string MedioPago
        {
            get { return _mediopago; }
            set { _mediopago = value; }
        }

        private string _cantprod;

        public string CantProd
        {
            get { return _cantprod; }
            set { _cantprod = value; }
        }

        public Operaciones()
        {
            
        }

        public Operaciones(string linea)
        {
            string[] datos = linea.Split(';');
            Num = int.Parse(datos[0]);
            Fecha = datos[1];
            CUITCliente = int.Parse(datos[2]);
            RazonCliente = datos[3];
            CodigoProducto = datos[4];
            MedioPago = datos[5];
            CantProd = datos[6];
        }

        public string GeneraLinea()
        {
            return Num + ";" + Fecha + ";" + CUITCliente + ";" + RazonCliente + ";" + CodigoProducto + ";" + MedioPago + ";" + CantProd; 
        }

        public object[] GenerarObjeto()
        {
            return new object[] { Num, Fecha, CUITCliente, RazonCliente, CodigoProducto, MedioPago, CantProd };
        }
    }
}
