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
        int puntero = 0;
        int cantidad = 0;
        int cuenta;
        double acumuloprecio;
        List<Producto> listcompra = new List<Producto>();
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
            if (listcompra.Count > 0 && comboBox1.Text != "")
            {
                //txtPrecio.Text = Convert.ToString(DeterminarPrecio());
                precio = 0;
                Operaciones nueva = new Operaciones();
                nueva.CUITCliente = Registracion.ListClientes[seleccionc].CUIT;
                //nueva.CodigoProducto = Registracion.ListProductos[seleccionp].Codigo;
                nueva.MedioPago = comboBox1.Text;
                nueva.RazonCliente = Registracion.ListClientes[seleccionc].Razon;
                nueva.Fecha = System.DateTime.Now;
                int n = 0;
                while ( n < listcompra.Count )
                {
                    nueva.AñadirLista(listcompra[n]);
                    precio += listcompra[n].Existencia;
                    n++;
                }
                /*nueva.CantProd = Convert.ToString(numCantProd.Value);*/
                EscriboOperaciones(nueva);
                nueva.Num = cuenta;
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
            cuenta = Registracion.ListOperaciones.Count;
            cuenta += 1;
            escritor.Write(texto + Environment.NewLine + cuenta + ";" + nueva.GeneraLinea());
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

        private void btnAgregarAlCarro_Click(object sender, EventArgs e)
        {
            cantidad = 0;
            precio = 0;
            listcompra.Add(Registracion.ListProductos[seleccionp]);
            listcompra[puntero].Costo = Convert.ToInt32(numCantProd.Value);
            precio += Registracion.ListProductos[seleccionp].Precio;
            cantidad += Convert.ToInt32(numCantProd.Value);
            double descuento = 0;
            if (txtDescuento.Text == "")
            {
                descuento = (cantidad * 0.05);
                descuento = 1.00 - descuento;
            }
            else
            {
                descuento = Convert.ToDouble(txtDescuento.Text);
            }
            precio = precio * cantidad;
            precio = precio * descuento;
            listcompra[puntero].Existencia = precio;
            acumuloprecio += precio;
            txtPrecio.Text = Convert.ToString(acumuloprecio);
            txtCarrito.Text += Registracion.ListProductos[seleccionp].Codigo + "\tCANTIDAD: " + numCantProd.Value + "\tPRECIO UNITARIO: " + listcompra[puntero].Precio + "\tTOTAL: " + listcompra[puntero].Existencia + "\r\n";
            puntero++;
        }

        private void btnBuscaProducto_Click(object sender, EventArgs e)
        {
            int n = 0;
            bool encontrado = false;
            try
            {
                while (n < Registracion.ListProductos.Count)
                {
                    if (txtBuscaProducto.Text == Registracion.ListProductos[n].Descripcion)
                    {
                        dgvProductos.ClearSelection();
                        dgvProductos.Rows[n].Selected = true;
                        dgvProductos.FirstDisplayedScrollingRowIndex = n;
                        encontrado = true;
                        break;
                    }
                    else
                    {
                        n++;
                    }
                }
                if ( encontrado == false )
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }
            catch
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        /*private double DeterminarPrecio()
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
        }*/
    }
}