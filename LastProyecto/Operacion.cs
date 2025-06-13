using LibreriaClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastProyecto
{
    public partial class Operacion : Form
    {
        double precio = 0;
        public Operacion()
        {
            InitializeComponent();
        }
        public void EncuentraProducto()
        {
            int n = 0;
            try
            {
                while (n < Registracion.ListProductos.Count)
                {
                    if (Registracion.ListProductos[n].Codigo == txtProducto.Text)
                    {
                        precio = Registracion.ListProductos[n].Precio;
                        if ( numCantProd.Value > 1 )
                        {
                            int cant = Convert.ToInt32(numCantProd.Value);
                            precio = precio * cant;
                            precio = precio * 0.8;
                        }
                        precio = precio * 1.21;
                        break;
                    }
                    else
                    {
                        n++;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nico se la come");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EncuentraProducto();
            txtPrecio.Text = Convert.ToString(precio);
        }

        private void Operacion_Load(object sender, EventArgs e)
        {

        }
    }
}
