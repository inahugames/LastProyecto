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
    public partial class ListarOperaciones : Form
    {
        int seleccion;
        string dgvseleccion;
        int n = 0;
        bool prod;
        List<Producto> listacompra = new List<Producto>();
        public ListarOperaciones()
        {
            InitializeComponent();
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = Registracion.ListClientes;
            prod = false;
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccion = e.RowIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (prod == false)
                {
                    dgvOperaciones.Rows.Clear();
                    n = 0;
                    while (n < Registracion.ListOperaciones.Count)
                    {
                        if (Registracion.ListOperaciones[n].CUITCliente == Registracion.ListClientes[seleccion].CUIT)
                        {
                            string linea = Registracion.ListOperaciones[n].DatosCompra();
                            string[] datos = linea.Split(';');
                            if (datos.Length > 4)
                            {
                                int z = 0;
                                string pedido = null;
                                string numpedido = null;
                                while (z < datos.Length - 1)
                                {
                                    pedido += datos[z] + ",";
                                    numpedido += datos[z + 1] + ",";
                                    z = z + 2;
                                }
                                string[] operacion = Registracion.ListOperaciones[n].GenerarVector();
                                dgvOperaciones.Rows.Add(operacion[0], operacion[1], operacion[2], operacion[3], operacion[4], pedido, numpedido);
                            }
                            else
                            {
                                string[] operacion = Registracion.ListOperaciones[n].GenerarVector();
                                dgvOperaciones.Rows.Add(operacion[0], operacion[1], operacion[2], operacion[3], operacion[4], datos[0], datos[1]);
                            }
                            n++;
                        }
                        else
                        {
                            n++;
                        }
                    }
                }
                else
                {
                    dgvOperaciones.Rows.Clear();
                    n = 0;
                    int x = 0;
                    while (n < Registracion.ListOperaciones.Count)
                    {
                        while (x < Registracion.ListOperaciones[n].ListCompra.Count)
                        {
                            if (Registracion.ListOperaciones[n].ListCompra[x].Codigo == Registracion.ListProductos[seleccion].Codigo)
                            {
                                dgvOperaciones.Rows.Add(Registracion.ListOperaciones[n].GenerarObjeto());
                                break;
                            }
                            else
                            {
                                x++;
                            }
                        }
                        n++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Elija un producto o cliente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvOperaciones.Rows.Clear();
            if (prod == false)
            {
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = Registracion.ListProductos;
                prod = true;
            }
            else
            {
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = Registracion.ListClientes;
                prod = false;
            }
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            int seleccionfac = int.Parse(dgvseleccion);
            seleccionfac = seleccionfac - 1;
            string detallesproducto = Registracion.ListOperaciones[seleccionfac].GeneraLineaCompra();
            /*string prodseleccion = Registracion.ListOperaciones[seleccionfac].CodigoProducto;
            foreach (Producto prod in Registracion.ListProductos)
            {
                if (prodseleccion == prod.Codigo)
                {
                    listacompra.Add(prod);
                    break;
                }
            }*/
            FormFactura factos = new FormFactura(Registracion.ListOperaciones[seleccionfac].Num, Registracion.ListOperaciones[seleccionfac].Fecha, Registracion.ListOperaciones[seleccionfac].CUITCliente, Registracion.ListOperaciones[seleccionfac].RazonCliente, /*int.Parse(Registracion.ListOperaciones[seleccionfac].CantProd), listacompra[0].Codigo, listacompra[0].Precio, 1*/ detallesproducto);
            factos.Show();
        }

        private void dgvOperaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOperaciones.Columns[e.ColumnIndex].Name == "Num")
            {
                object a = dgvOperaciones.CurrentCell.Value;
                dgvseleccion = a.ToString();
            }
            else
            {
                MessageBox.Show("Seleciona un número de operación para producir su factura.");
            }
        }

        public void GenerarLineaProductos()
        {
           
        }
    }
}
