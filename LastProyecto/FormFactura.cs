using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastProyecto
{
    public partial class FormFactura : Form
    {
        public FormFactura(int numfac, DateTime fecha, double cuitcliente, string razoncliente, string productos)
        {
            InitializeComponent();
            if (CultureInfo.CurrentUICulture.DisplayName == "Español (Argentina)")
            {
                txtFactura.Text = "FACTURA \t\t\t I \r\nNUMERO DE FACTURA: " + numfac + "\t\t I \r\nFECHA: " + fecha + "\t I \r\nCUIT CLIENTE: " + cuitcliente + "\t\t\t I \r\nRAZON CLIENTE: " + razoncliente + "\t I \r\nCUIL EMPRESA: " /*+ cuilemp*/ + "\t\t\t I \r\n---------------------------------------------------------------------------------------------------------------------------------------------------------------------------\r\nCANT PROD\tID\t\tDESCRIPCION\t\tPRECIO UNITARIO \tSUBTOTAL \r\n" + productos;
            }
            else if (CultureInfo.CurrentUICulture.DisplayName == "English (United States)")
            {
                txtFactura.Text = "BILL \t\t\t\t I \r\nBILL NUMBER: " + numfac + "\t\t\t I \r\nDATE: " + fecha + "\t\t I \r\nCLIENT'S CUIT: " + cuitcliente + "\t\t\t I \r\nCLIENT'S REASON: " + razoncliente + "\t I \r\nBUSINESS CUIL: " /*+ cuilemp*/ + "\t\t\t I \r\n---------------------------------------------------------------------------------------------------------------------------------------------------------------------------\r\nPROD QUANTITY\tID\t\tDESCRIPTION\t\tINDIVIDUAL PRICE \tTOTAL \r\n" + productos;
            }
        }

        private void btnGuardarFactura_Click(object sender, EventArgs e)
        {
            string factura = txtFactura.Text;
            StreamWriter escritor = new StreamWriter("Factura.txt");
            escritor.Write(factura);
            escritor.Close();
            MessageBox.Show("Factura guardada en: Factura.txt");
        }
    }
}
