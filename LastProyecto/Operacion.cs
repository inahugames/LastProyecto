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
            foreach ( Producto prod in Registracion.ListProductos )
            {
                dgvProductos.Rows.Add(prod.GenerarObjeto());
            }
        }

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
                while (n < listcompra.Count)
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
        private void btnAgregarAlCarro_Click(object sender, EventArgs e)
        {
            if (numCantProd.Value > 0)
            {
                if (comboBox1.Text != "")
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
                        try
                        {
                            descuento = Convert.ToDouble(txtDescuento.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Ingrese un descuento válido.");
                            return;
                        }
                    }
                    if (descuento != 0)
                    {
                        precio = precio * cantidad;
                        precio = precio * descuento;
                        listcompra[puntero].Existencia = precio;
                        acumuloprecio += precio;
                        txtPrecio.Text = Convert.ToString(acumuloprecio);
                        txtCarrito.Text += Registracion.ListProductos[seleccionp].Codigo + "\t DESCRIPCION: " + Registracion.ListProductos[seleccionp].Descripcion + "\tCANTIDAD: " + numCantProd.Value + "\tPRECIO UNITARIO: " + listcompra[puntero].Precio + "\tTOTAL: " + listcompra[puntero].Existencia + "\r\n";
                        puntero++;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un descuento válido.");
                        txtDescuento.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Elija un medio de pago.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad mayor a 0.");
            }
        }

        private void btnBuscaProducto_Click(object sender, EventArgs e)
        {
            /*if (txtBuscaProducto.Text != "")
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
                            seleccionp = n;
                            break;
                        }
                        else
                        {
                            n++;
                        }
                    }
                    if (encontrado == false)
                    {
                        MessageBox.Show("Producto no encontrado.");
                    }
                }
                catch
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un producto para su búsqueda.");
            }*/
            dgvProductos.Rows.Clear();
            try
            {
                var Productardo = from prod in Registracion.ListProductos
                                  where prod.Descripcion.ToLower().Contains(txtBuscaProducto.Text) //|| prod.Descripcion.Equals(txtBuscaProducto.Text, StringComparison.OrdinalIgnoreCase)
                                  select prod;
                foreach (var prod in Productardo)
                {
                    dgvProductos.Rows.Add(prod.GenerarObjeto());
                }
            }
            catch
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        private void dgvProductos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            seleccionp = e.RowIndex;
        }
    }
}