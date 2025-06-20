using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastProyecto
{
    public partial class FormFactura : Form
    {
        public FormFactura(int numfac, string fecha, double cuitcliente, string razoncliente, int cantidad, string id, int preciouni, int total)
        {
            InitializeComponent();
            txtFactura.Text = "FACTURA \t\t\t I \r\nNUMERO DE FACTURA: "+ numfac + "\t\t I \r\nFECHA: " + fecha + "\t\t\t I \r\nCUIT CLIENTE: " + cuitcliente + "\t\t\t I \r\nRAZON CLIENTE: " + razoncliente + "\t I \r\nCUIL EMPRESA: " /*+ cuilemp*/ + "\t\t\t I \r\n---------------------------------------------------------------------------------------------------------------------------------------------------------------------------\r\nCANT PROD\tID\tDESCRIPCION\t\tPRECIO UNITARIO \tSUBTOTAL \r\n" + cantidad + "\t\t" + id + "\t\t\t\t" + preciouni + "\t\t\t" +total;
        }
    }
}
