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
        string[] admins = null;
        string[] vendedores = null;
        bool admin = false;
        bool login = false;
        public Form1()
        {
            InitializeComponent();
            listasToolStripMenuItem.Visible = false;
            nuevaOperaciónToolStripMenuItem.Visible = false;
            listarOperacionesToolStripMenuItem.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargaClientes();
            CargaProductos();
            CargaOperaciones();
            CargoLogin();
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
            while (linea != null)
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
                    Producto nuevo = new Producto(int.Parse(producto[n]), producto[n + 1], int.Parse(producto[n + 2]), Convert.ToDouble(producto[n + 3]));
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
            ListarOperaciones listop = new ListarOperaciones(admin);
            listop.MdiParent = this;
            listop.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Ingrese un usuario o contraseña.");
            }

            int n = 0;
            while ( n < admins.Length )
            {
                if ( txtUser.Text == admins[n] && txtPassword.Text == admins[n+1] )
                {
                    txtUser.Visible = false;
                    txtPassword.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    btnLogin.Visible = false;
                    listasToolStripMenuItem.Visible = true;
                    listarOperacionesToolStripMenuItem.Visible = true;
                    MessageBox.Show("Inicio de sesión exitoso.");
                    admin = true;
                    login = true;
                    break;
                }
                else
                {
                    n++;
                }
            }
            if ( admin == false )
            {
                n = 0;
                while (n < vendedores.Length)
                {
                    if (txtUser.Text == vendedores[n] && txtPassword.Text == vendedores[n + 1])
                    {
                        txtUser.Visible = false;
                        txtPassword.Visible = false;
                        label1.Visible = false;
                        label2.Visible = false;
                        btnLogin.Visible = false;
                        listasToolStripMenuItem.Visible = true;
                        nuevaOperaciónToolStripMenuItem.Visible = true;
                        listarOperacionesToolStripMenuItem.Visible= true;
                        login = true;
                        MessageBox.Show("Inicio de sesión exitoso.");
                        break;
                    }
                    else
                    {
                        n++;
                    }

                    if (login == false )
                    {
                        MessageBox.Show("Ingrese un usuario o contraseña válidos.");
                    }
                }
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void CargoLogin()
        {
            StreamReader lector = new StreamReader("Administradores.csv");
            string linea = lector.ReadToEnd();
            lector.Close();
            admins = linea.Split(';');
            lector = new StreamReader("Vendedores.csv");
            linea = lector.ReadToEnd();
            vendedores = linea.Split(';');
        }
    }
}
