using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public class Operaciones
    {
        private double _cuitcliente;
        public double CUITCliente
        {
            get { return _cuitcliente; }
            set { _cuitcliente = value; }
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
            CUITCliente = int.Parse(datos[0]);
            CodigoProducto = datos[1];
            MedioPago = datos[2];
            CantProd = datos[3];
        }

        public string GeneraLinea()
        {
            return CUITCliente + ";" + CodigoProducto + ";" + MedioPago + ";" + CantProd; 
        }

        public object[] GenerarObjeto()
        {
            return new object[] { CUITCliente, CodigoProducto, MedioPago, CantProd };
        }
    }
}
