using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaClases;

namespace LastProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargaClientes();
            CargaProductos();
            CargaOperaciones();
        }

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLista listas = new FormLista();
            listas.MdiParent = this;
            listas.Show();
        }

        private void nuevaOperaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operacion NuevaOperacion = new Operacion();
            NuevaOperacion.MdiParent = this;
            NuevaOperacion.Show();
        }

        public void CargaClientes()
        {
            StreamReader lector = new StreamReader("Clientes.csv");
            string linea = lector.ReadLine();
            while ( linea != null )
            {
                Cliente nuevo = new Cliente(linea);
                Registracion.ListClientes.Add(nuevo);
                linea = lector.ReadLine();
            }
            lector.Close();
        }

        public void CargaProductos()
        {
            StreamReader lector = new StreamReader("Productos.csv");
            string linea = lector.ReadLine();
            while (linea != null)
            {
                Producto nuevo = new Producto(linea);
                Registracion.ListProductos.Add(nuevo);
                linea = lector.ReadLine();
            }
            lector.Close();
        }

        public void CargaOperaciones()
        {
            StreamReader lector = new StreamReader("Operaciones.csv");
            string linea = lector.ReadLine();
            while (linea != null)
            {
                string[] producto = linea.Split(',');
                int n = 1;
                Operaciones nueva = new Operaciones(linea);
                while (n < producto.Length)
                {
                    Producto nuevo = new Producto(int.Parse(producto[n]), producto[n + 1], int.Parse(producto[n + 2]), int.Parse(producto[n + 3]));
                    nueva.AñadirLista(nuevo);
                    n = n + 4;
                }
                Registracion.ListOperaciones.Add(nueva);
                linea = lector.ReadLine();
            }
            lector.Close();
        }

        private void listarOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarOperaciones listop = new ListarOperaciones();
            listop.MdiParent = this;
            listop.Show();
        }
    }
}
