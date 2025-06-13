using LibreriaClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastProyecto
{
    public partial class Operacion : Form
    {
        int seleccionc;
        int seleccionp;
        double precio;
        public Operacion()
        {
            InitializeComponent();
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = Registracion.ListClientes;
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = Registracion.ListProductos;
        }
        /*public void EncuentraProducto()
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
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            if (numCantProd.Value > 0 && comboBox1.Text != null)
            {
                txtPrecio.Text = Convert.ToString(DeterminarPrecio());
                Operaciones nueva = new Operaciones();
                nueva.CUITCliente = Registracion.ListClientes[seleccionc].CUIT;
                nueva.CodigoProducto = Registracion.ListProductos[seleccionp].Codigo;
                nueva.MedioPago = comboBox1.Text;
                nueva.CantProd = Convert.ToString(numCantProd.Value);
                EscriboOperaciones(nueva);
                Registracion.ListOperaciones.Add(nueva);
            }
            else
            {
                MessageBox.Show("Datos inválidos.");
            }
        }

        private void Operacion_Load(object sender, EventArgs e)
        {

        }

        public void EscriboOperaciones(Operaciones nueva)
        {
            StreamReader lector = new StreamReader("Operaciones.csv");
            string texto = lector.ReadToEnd();
            lector.Close();
            StreamWriter escritor = new StreamWriter("Operaciones.csv");
            escritor.Write(texto + Environment.NewLine + nueva.GeneraLinea());
            escritor.Close();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionc = e.RowIndex;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionp = e.RowIndex;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private double DeterminarPrecio()
        {
            if ( numCantProd.Value > 1 )
            {
                if ( txtDescuento.Text == null || txtDescuento.Text == "" )
                {
                    precio = Registracion.ListProductos[seleccionp].Precio * 0.8;
                    precio = precio * Convert.ToInt32(numCantProd.Value);
                }
                else
                {
                    precio = Registracion.ListProductos[seleccionp].Precio * Convert.ToDouble(txtDescuento.Text);
                    precio = precio * Convert.ToInt32(numCantProd.Value);
                }
            }
            precio = precio * 1.21;
            return precio;
        }
    }
}
