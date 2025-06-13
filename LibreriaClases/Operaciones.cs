using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public class Operaciones
    {
        private int _idcliente;
        public int IDCliente
        {
            get { return _idcliente; }
            set { _idcliente = value; }
        }

        private int _codigoproducto;
        public int CodigoProducto
        {
            get { return _codigoproducto; }
            set { _codigoproducto = value; }
        }

        public Operaciones()
        {
            
        }

        public Operaciones(string linea)
        {
            string[] datos = linea.Split(';');
            IDCliente = int.Parse(datos[0]);
            CodigoProducto = int.Parse(datos[1]);
        }
    }
}
