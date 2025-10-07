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
using DAL;

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
        int codprod;
        Producto elegido;
        List<Producto> listcompra = new List<Producto>();
        public event EventHandler<string> StockInsuficiente;
        public Operacion()
        {
            InitializeComponent();
            Registracion.ListProductos.Sort();
            foreach ( Producto prod in Registracion.ListProductos )
            {
                dgvProductos.Rows.Add(prod.GenerarObjeto());
            }
            foreach ( Cliente cl in Registracion.ListClientes )
            {
                dgvClientes.Rows.Add(cl.GenerarObjeto());
            }
            this.StockInsuficiente += Operacion_StockInsuficiente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listcompra.Count > 0 && comboBox1.Text != "")
            {
                precio = 0;
                Operaciones nueva = new Operaciones();
                nueva.CUITCliente = Registracion.ListClientes[seleccionc].CUIT;
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
                //EscriboOperaciones(nueva);
                PersonaDAL.AgregarOperaciones(nueva);
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
            //PersonaDAL.AgregarOperaciones(nueva);
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
                                    elegido = (Producto)prod.Clone();
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
                            listcompra[puntero].Existencia = Convert.ToInt32(precio);
                            acumuloprecio += precio;
                            txtPrecio.Text = Convert.ToString(acumuloprecio);
                            if (CultureInfo.CurrentUICulture.DisplayName == "Español (Argentina)")
                            {
                                txtCarrito.Text += elegido.Codigo + "\t DESCRIPCION: " + elegido.Descripcion + "\tCANTIDAD: " + numCantProd.Value + "\tPRECIO UNITARIO: " + listcompra[puntero].Precio + "\tTOTAL: " + listcompra[puntero].Existencia + "\r\n";
                            }
                            else if (CultureInfo.CurrentUICulture.DisplayName == "English (United States)")
                            {
                                txtCarrito.Text += elegido.Codigo + "\t DESCRIPTION: " + elegido.Descripcion + "\tQUANTITY: " + numCantProd.Value + "\tINDIVIDUAL PRICE: " + listcompra[puntero].Precio + "\tTOTAL: " + listcompra[puntero].Existencia + "\r\n";
                            }
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
                            StockInsuficiente?.Invoke(this, $"No hay suficiente stock.");
                        }
                        else if ( CultureInfo.CurrentUICulture.DisplayName == "English (United States)")
                        {
                            StockInsuficiente?.Invoke(this, $"Insufficient stock.");
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
                if ( prod.Codigo == Convert.ToInt32(datos[0]))
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
                var Productardo = Registracion.ListProductos.Where(p => p.Descripcion.ToLower().Contains(txtBuscaProducto.Text.ToLower())).ToList();
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

        private void Operacion_StockInsuficiente( object sender, string mensaje )
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Operacion_Load(object sender, EventArgs e)
        {

        }
    }
}