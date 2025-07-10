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
using System.Globalization;
using System.Threading;
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
        string codprod;
        Producto elegido;
        List<Producto> listcompra = new List<Producto>();
        public Operacion()
        {
            InitializeComponent();
            foreach ( Producto prod in Registracion.ListProductos )
            {
                dgvProductos.Rows.Add(prod.GenerarObjeto());
            }
            foreach ( Cliente cl in Registracion.ListClientes )
            {
                dgvClientes.Rows.Add(cl.GenerarObjeto());
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
                nueva.Fecha = DateTime.Today;
                int n = 0;
                while (n < listcompra.Count)
                {
                    nueva.AñadirLista(listcompra[n]);
                    precio += listcompra[n].Existencia;
                    n++;
                }
                /*nueva.CantProd = Convert.ToString(numCantProd.Value);*/
                EscriboOperaciones(nueva);
                nueva.Num = cuenta + 1;
                Registracion.ListOperaciones.Add(nueva);
            }
            else
            {
                if (CultureInfo.CurrentUICulture.DisplayName == "Español (Argentina)")
                {
                    MessageBox.Show("Datos inválidos.");
                }
                else if (CultureInfo.CurrentUICulture.DisplayName == "English (United States)")
                {
                    MessageBox.Show("Invalid data.");
                }
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
            nueva.Num = cuenta + 1;
            nueva.Habilitada = true;
            escritor.Write(texto + Environment.NewLine + nueva.GeneraLinea());
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
                    if (Registracion.ListProductos[seleccionp].Existencia >= Convert.ToInt32(numCantProd.Value))
                    {
                        cantidad = 0;
                        precio = 0;
                        if (codprod != null)
                        {
                            foreach (Producto prod in Registracion.ListProductos)
                            {
                                if (prod.Codigo == codprod)
                                {
                                    elegido = prod;
                                }
                            }
                        }
                        else
                        {
                            if ( CultureInfo.CurrentUICulture.DisplayName == "Español (Argentina)")
                            {
                                MessageBox.Show("Elija un producto para añadirlo al carrito.");
                            }
                            else if ( CultureInfo.CurrentUICulture.DisplayName == "English (United States)")
                            {
                                MessageBox.Show("Choose a product to add to the cart.");
                            }
                            return;
                        }
                        elegido.Costo = Convert.ToInt32(numCantProd.Value);
                        listcompra.Add(elegido);
                        precio += elegido.Precio;
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
                            txtCarrito.Text += elegido.Codigo + "\t DESCRIPCION: " + elegido.Descripcion + "\tCANTIDAD: " + numCantProd.Value + "\tPRECIO UNITARIO: " + listcompra[puntero].Precio + "\tTOTAL: " + listcompra[puntero].Existencia + "\r\n";
                            puntero++;
                        }
                        else
                        {
                            if (CultureInfo.CurrentUICulture.DisplayName == "Español (Argentina)")
                            {
                                MessageBox.Show("Ingrese un descuento válido.");
                                txtDescuento.Clear();
                                return;
                            }
                            else if ( CultureInfo.CurrentUICulture.DisplayName == "English (United States)")
                            {
                                MessageBox.Show("Enter a valid discount.");
                                txtDescuento.Clear();
                                return;
                            }
                        }
                    }
                    else
                    {
                        if ( CultureInfo.CurrentUICulture.DisplayName == "Español (Argentina)")
                        {
                            MessageBox.Show("Existencias insuficientes.");
                            return;
                        }
                        else if ( CultureInfo.CurrentUICulture.DisplayName == "English (United States)")
                        {
                            MessageBox.Show("Insufficient stock.");
                            return;
                        }
                    }
                }
                else
                {
                    if ( CultureInfo.CurrentUICulture.DisplayName == "Español (Argentina)")
                    {
                        MessageBox.Show("Elija un medio de pago.");
                        return;
                    }
                    else if ( CultureInfo.CurrentUICulture.DisplayName == "English (United States)")
                    {
                        MessageBox.Show("Select a payment method.");
                        return;
                    }
                }
            }
            else
            {
                if (CultureInfo.CurrentUICulture.DisplayName == "Español (Argentina)")
                {
                    MessageBox.Show("Ingrese una cantidad mayor a 0.");
                    return;
                }
                else if ( CultureInfo.CurrentUICulture.DisplayName == "English (United States)")
                {
                    MessageBox.Show("Enter a quantity over 0.");
                    return;
                }
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
            foreach ( Producto prod in Registracion.ListProductos )
            {
                dgvProductos.Rows.Add(prod.GenerarObjeto());
            }
        }

        private void dgvProductos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string[] datos = dgvProductos.CurrentRow.AccessibilityObject.Value.Split(';');

            foreach ( Producto prod in Registracion.ListProductos )
            {
                if ( prod.Codigo == datos[0])
                {
                    codprod = prod.Codigo;
                }
            }
        }

        private void txtBuscaProducto_TextChanged(object sender, EventArgs e)
        {
            dgvProductos.Rows.Clear();
            try
            {
                var Productardo = Registracion.ListProductos.Where(p => p.Descripcion.ToLower().Contains(txtBuscaProducto.Text)).ToList();
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
    }
}