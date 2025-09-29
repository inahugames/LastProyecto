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
using SEG;
using DAL;

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
            /*StreamReader lector = new StreamReader("Clientes.csv");
            string linea = lector.ReadLine();
            while (linea != null)
            {
                Cliente nuevo = new Cliente(linea);
                Registracion.ListClientes.Add(nuevo);
                linea = lector.ReadLine();
            }
            lector.Close();*/
            Registracion.ListClientes = PersonaDAL.PresentarClientes();
        }

        public void CargaProductos()
        {
            /*StreamReader lector = new StreamReader("Productos.csv");
            string linea = lector.ReadLine();
            while (linea != null)
            {
                Producto nuevo = new Producto(linea);
                Registracion.ListProductos.Add(nuevo);
                linea = lector.ReadLine();
            }
            lector.Close();*/
            Registracion.ListProductos = PersonaDAL.PresentarProductos();
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
                    Producto nuevo = new Producto(int.Parse(producto[n]), Convert.ToInt32(producto[n + 1]), producto[n + 2], int.Parse(producto[n + 3]), Convert.ToDouble(producto[n + 4]));
                    nueva.AñadirLista(nuevo);
                    n = n + 5;
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
                if ( txtUser.Text == administra.Usuario && txtPassword.Text == administra.Contraseña)
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
                    cerrarSesiónToolStripMenuItem.Visible = true;
                    button1.Visible = false;
                    chkAdmin.Visible = false;
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
                        cerrarSesiónToolStripMenuItem.Visible = true;
                        button1.Visible = false;
                        chkAdmin.Visible = false;
                        login = true;
                        if (CultureInfo.CurrentUICulture.DisplayName == "Español (Argentina)")
                        {
                            MessageBox.Show("Inicio de sesión exitoso.", "Información", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else if (CultureInfo.CurrentUICulture.DisplayName == "English (United States)")
                        {
                            MessageBox.Show("Successfully logged in.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                    if (login == false )
                    {
                        if (CultureInfo.CurrentUICulture.DisplayName == "Español (Argentina)")
                        {
                            MessageBox.Show("Ingrese un usuario o contraseña válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if ( CultureInfo.CurrentUICulture.DisplayName == "English (United States)")
                        {
                            MessageBox.Show("Wrong username or password.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void CargoLogin()
        {
            /*StreamReader lector = new StreamReader("Administradores.csv");
            string linea = lector.ReadLine();
            while (linea != null)
            {
                string[] datos = linea.Split(';');
                //datos[1] = SEG.Encriptación.Desencriptar(Convert.FromBase64String(datos[1]));
                Administrador nuevo = new Administrador();
                nuevo.Usuario = datos[0];
                nuevo.Contraseña = datos[1];
                ListAdmins.Add(nuevo);
                linea = lector.ReadLine();
            }
            lector.Close();
            StreamReader lector = new StreamReader("Vendedores.csv");
            //lector = new StreamReader("Vendedores.csv");
            string linea = lector.ReadLine();
            while ( linea != null )
            {
                string[] datos = linea.Split(';');
                datos[1] = SEG.Encriptación.Desencriptar(Convert.FromBase64String(datos[1]));
                Vendedor nuevo = new Vendedor();
                nuevo.Usuario = datos[0];
                nuevo.Contraseña = datos[1];
                ListVendedor.Add(nuevo);
                linea = lector.ReadLine();
            }
            lector.Close();*/
            ListAdmins = PersonaDAL.PresentarAdmins();
            ListVendedor = PersonaDAL.PresentarVendedores();
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

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login = false;
            admin = false;
            txtUser.Text = "";
            txtPassword.Text = "";
            label1.Visible = true;
            label2.Visible = true;
            listarOperacionesToolStripMenuItem.Visible = false;
            listasToolStripMenuItem.Visible = false;
            nuevaOperaciónToolStripMenuItem.Visible = false;
            cerrarSesiónToolStripMenuItem.Visible = false;
            btnLogin.Visible = true;
            txtPassword.Visible = true;
            txtUser.Visible = true;
            pictureboxAR.Visible = true;
            pictureboxUS.Visible = true;
            button1.Visible = true;
            if (CultureInfo.CurrentUICulture.DisplayName == "Español (Argentina)") { MessageBox.Show("Sesión cerrada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else if (CultureInfo.CurrentUICulture.DisplayName == "English (United States)") { MessageBox.Show("Logged out successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chkAdmin.Visible == false )
            {
                chkAdmin.Visible = true;
                return;
            }
            if ( txtUser.Text != "" && txtPassword.Text != "")
            {
                if (chkAdmin.Checked)
                {
                    foreach (Administrador adm in ListAdmins)
                    {
                        if (txtUser.Text == adm.Usuario)
                        {
                            if (CultureInfo.CurrentUICulture.DisplayName == "Español (Argentina)") { MessageBox.Show("Usuario ya creado, elija otro usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            else if (CultureInfo.CurrentUICulture.DisplayName == "English (United States)") { MessageBox.Show("User is already registered, choose another username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            return;
                        }
                    }
                    /*StreamReader lector = new StreamReader("Administradores.csv");
                    string texto = lector.ReadToEnd();
                    lector.Close();
                    byte[] contra = SEG.Encriptación.Encriptar(txtPassword.Text);
                    StreamWriter escritor = new StreamWriter("Administradores.csv");
                    escritor.Write(texto + Environment.NewLine + txtUser.Text + ";" + Convert.ToBase64String(contra));
                    escritor.Close();
                    Administrador nuevo = new Administrador();
                    nuevo.Usuario = txtUser.Text;
                    nuevo.Contraseña = txtPassword.Text;
                    ListAdmins.Add(nuevo);*/

                    Administrador admin = new Administrador();
                    admin.Usuario = txtUser.Text;
                    //byte[] contra = SEG.Encriptación.Encriptar(txtPassword.Text);
                    //string maniobras = txtPassword.Text;
                    //admin.Contraseña = Convert.ToBase64String(contra);
                    admin.Contraseña = txtPassword.Text;
                    int reg = DAL.PersonaDAL.AgregarAdmin(admin);
                    if ( reg > 0 )
                    {
                        if (CultureInfo.CurrentUICulture.DisplayName == "Español (Argentina)")
                        {
                            MessageBox.Show("Registrado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Registered successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        ListAdmins.Add(admin);
                    }
                    else
                    {
                        if (CultureInfo.CurrentUICulture.DisplayName == "Español (Argentina)")
                        {
                            MessageBox.Show("Error al registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Registration error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        return;
                    }
                }
                else
                {
                    foreach (Vendedor vend in ListVendedor)
                    {
                        if (txtUser.Text == vend.Usuario)
                        {
                            if (CultureInfo.CurrentUICulture.DisplayName == "Español (Argentina)") { MessageBox.Show("Usuario ya creado, elija otro usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            else if (CultureInfo.CurrentUICulture.DisplayName == "English (United States)") { MessageBox.Show("User is already registered, choose another username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            return;
                        }
                    }
                    StreamReader lector = new StreamReader("Vendedores.csv");
                    string texto = lector.ReadToEnd();
                    lector.Close();
                    byte[] contra = SEG.Encriptación.Encriptar(txtPassword.Text);
                    StreamWriter escritor = new StreamWriter("Vendedores.csv");
                    escritor.Write(texto + Environment.NewLine + txtUser.Text + ";" + Convert.ToBase64String(contra));
                    escritor.Close();
                    Vendedor nuevo = new Vendedor();
                    nuevo.Usuario = txtUser.Text;
                    nuevo.Contraseña = Convert.ToBase64String(contra);
                    ListVendedor.Add(nuevo);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un usuario o contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*public static byte[] Encriptar(string texto)
        {
            byte[] datos = Encoding.UTF8.GetBytes(texto);
            return ProtectedData.Protect(datos, null, DataProtectionScope.CurrentUser);
        }

        public static string Desencriptar(byte[] cifrado)
        {
            byte[] datos = ProtectedData.Unprotect(cifrado, null, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(datos);
        }*/
    }
}