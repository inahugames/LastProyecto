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
    public partial class ListarOperaciones : Form
    {
        int seleccionc;
        int seleccionp;
        string dgvseleccion;
        int n = 0;
        List<Producto> listacompra = new List<Producto>();
        public ListarOperaciones(bool adm)
        {
            InitializeComponent();
            foreach ( Cliente cl in Registracion.ListClientes )
            {
                dgvCliente.Rows.Add(cl.GenerarObjeto());
            }
            foreach ( Producto prod in Registracion.ListProductos )
            {
                dgvProductos.Rows.Add(prod.GenerarObjeto());
            }
            if (adm == true )
            {
                btnCancelar.Visible = true;
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionc = e.RowIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarDgv();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvOperaciones.Rows.Clear();
            if ( dgvProductos.Visible == false )
            {
                dgvCliente.Visible = false;
                dgvProductos.Visible = true;
            }
            else
            {
                dgvCliente.Visible = true;
                dgvProductos.Visible = false;
            }
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            try
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
            catch
            {
                MessageBox.Show("Elija una operación para producir su factura.");
            }
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                int selec = int.Parse(dgvseleccion);
                selec = selec - 1;
                Registracion.ListOperaciones[selec].Habilitada = false;
                ActualizoOperaciones();
                ActualizarDgv();
            }
            catch
            {
                MessageBox.Show("Elija una operación para su cancelación.");
            }
        }
        
        private void ActualizoOperaciones()
        {
            string datos = null;
            foreach ( Operaciones op in Registracion.ListOperaciones )
            {
                datos += op.GeneraLinea() + Environment.NewLine;
            }
            StreamWriter escritor = new StreamWriter("Operaciones.csv");
            escritor.Write(datos);
            escritor.Close();
        }

        public void ActualizarDgv()
        {
            try
            {
                if (dgvProductos.Visible == false)
                {
                    dgvOperaciones.Rows.Clear();
                    n = 0;
                    while (n < Registracion.ListOperaciones.Count)
                    {
                        if (Registracion.ListOperaciones[n].CUITCliente == Registracion.ListClientes[seleccionc].CUIT)
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
                                dgvOperaciones.Rows.Add(operacion[0], operacion[1], operacion[2], operacion[3], operacion[4], operacion[5], pedido, numpedido);
                            }
                            else
                            {
                                string[] operacion = Registracion.ListOperaciones[n].GenerarVector();
                                dgvOperaciones.Rows.Add(operacion[0], operacion[1], operacion[2], operacion[3], operacion[4], operacion[5], datos[0], datos[1]);
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
                            if (Registracion.ListOperaciones[n].ListCompra[x].Codigo == Registracion.ListProductos[seleccionp].Codigo)
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
                                    dgvOperaciones.Rows.Add(operacion[0], operacion[1], operacion[2], operacion[3], operacion[4], operacion[5], pedido, numpedido);
                                }
                                else
                                {
                                    string[] operacion = Registracion.ListOperaciones[n].GenerarVector();
                                    dgvOperaciones.Rows.Add(operacion[0], operacion[1], operacion[2], operacion[3], operacion[4], operacion[5], datos[0], datos[1]);
                                }
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

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionp = e.RowIndex;
        }
    }
}
