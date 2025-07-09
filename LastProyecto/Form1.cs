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
using System.Globalization;
using System.Threading;
using LibreriaClases;

namespace LastProyecto
{
    public partial class Form1 : Form
    {
        static List<Administrador> ListAdmins = new List<Administrador>();
        static List<Vendedor> ListVendedor = new List<Vendedor>();
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
            if (Registracion.ListClientes.Count == 0)
            {
                CargaClientes();
                CargaProductos();
                CargaOperaciones();
                CargoLogin();
            }
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

            foreach (Administrador administra in ListAdmins)
            {
                if ( txtUser.Text == administra.Usuario && txtPassword.Text == administra.Contraseña )
                {
                    txtUser.Visible = false;
                    txtPassword.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    btnLogin.Visible = false;
                    pictureboxAR.Visible = false;
                    pictureboxUS.Visible = false;
                    listasToolStripMenuItem.Visible = true;
                    listarOperacionesToolStripMenuItem.Visible = true;
                    if (CultureInfo.CurrentUICulture.DisplayName == "Español (Argentina)")
                    {
                        MessageBox.Show("Inicio de sesión exitoso.");
                    }
                    else if ( CultureInfo.CurrentUICulture.DisplayName == "English (United States)")
                    {
                        MessageBox.Show("Successfully logged in.");
                    }
                    admin = true;
                    login = true;
                    break;
                }
            }
            if ( admin == false )
            {
                foreach ( Vendedor venta in ListVendedor )
                {
                    if (txtUser.Text == venta.Usuario && txtPassword.Text == venta.Contraseña)
                    {
                        txtUser.Visible = false;
                        txtPassword.Visible = false;
                        label1.Visible = false;
                        label2.Visible = false;
                        btnLogin.Visible = false;
                        pictureboxAR.Visible = false;
                        pictureboxUS.Visible = false;
                        listasToolStripMenuItem.Visible = true;
                        nuevaOperaciónToolStripMenuItem.Visible = true;
                        listarOperacionesToolStripMenuItem.Visible= true;
                        login = true;
                        if (CultureInfo.CurrentUICulture.DisplayName == "Español (Argentina)")
                        {
                            MessageBox.Show("Inicio de sesión exitoso.");
                        }
                        else if (CultureInfo.CurrentUICulture.DisplayName == "English (United States)")
                        {
                            MessageBox.Show("Successfully logged in.");
                        }
                        break;
                    }
                    if (login == false )
                    {
                        if (CultureInfo.CurrentUICulture.DisplayName == "Español (Argentina)")
                        {
                            MessageBox.Show("Ingrese un usuario o contraseña válidos.");
                        }
                        else if ( CultureInfo.CurrentUICulture.DisplayName == "English (United States)")
                        {
                            MessageBox.Show("Wrong username or password.");
                        }
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
            string linea = lector.ReadLine();
            while (linea != null)
            {
                Administrador nuevo = new Administrador(linea);
                ListAdmins.Add(nuevo);
                linea = lector.ReadLine();
            }
            lector.Close();
            lector = new StreamReader("Vendedores.csv");
            linea = lector.ReadLine();
            while ( linea != null )
            {
                Vendedor nuevo = new Vendedor(linea);
                ListVendedor.Add(nuevo);
                linea = lector.ReadLine();
            }
            lector.Close();
        }

        private void CambiarIdioma(string codigoIdioma)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(codigoIdioma);

            this.Hide();
            Form1 nuevoForm = new Form1();
            nuevoForm.Show();
        }

        private void pictureboxAR_Click(object sender, EventArgs e)
        {
            if (CultureInfo.CurrentUICulture.DisplayName == "English (United States)")
            {
                CambiarIdioma("es-AR");
            }
        }

        private void pictureboxUS_Click(object sender, EventArgs e)
        {
            if (CultureInfo.CurrentUICulture.DisplayName == "Español (Argentina)")
            {
                CambiarIdioma("en-US");
            }
        }
    }
}
