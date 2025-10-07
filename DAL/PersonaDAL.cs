using LibreriaClases;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PersonaDAL
    {
        public static int AgregarAdmin(Administrador admin)
        {
            int retorna = 0;
            using (SqlConnection conexion = SQL.Conectar())
            {
                string consulta = $"insert into Administradores (Usuario,Contraseña) values('{admin.Usuario}','{admin.Contraseña}')";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }

        public static int AgregarVendedor(Vendedor vendedor)
        {
            int retorna = 0;
            using (SqlConnection conexion = SQL.Conectar())
            {
                string consulta = $"insert into Vendedores (Usuario,Contraseña) values ('{vendedor.Usuario}','{vendedor.Contraseña}')";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }

        public static int AgregarCliente(Cliente cliente)
        {
            int retorna = 0;
            using (SqlConnection conexion = SQL.Conectar())
            {
                string consulta = $"insert into Clientes (CUIT,Razon) values ('{cliente.CUIT}','{cliente.Razon}')";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }

        public static int AgregarOperaciones( Operaciones op )
        {
            int retorna = 0;

            using (SqlConnection conexion = SQL.Conectar())
            {
                string consulta = $"insert into Operaciones (Número,Fecha,CUITCliente,RazonCliente,MedioPago,Habilitada) values ('{op.Num}','{op.Fecha}','{op.CUITCliente}','{op.RazonCliente}','{op.MedioPago}','{op.Habilitada}')";
                SqlCommand comando = new SqlCommand(consulta,conexion);
                foreach ( Producto prod in op.ListCompra )
                {
                    consulta = $"insert into ListCompras (Número,Cantidad,Código,Descripción,Precio,CostoTotal) values ('{op.Num}','{prod.Costo}','{prod.Codigo}','{prod.Descripcion}','{prod.Precio}','{prod.Existencia}')";
                    SqlConnection conexion2 = SQL.Conectar();
                    SqlCommand comando2 = new SqlCommand(consulta, conexion);
                }
                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }

        public static int AgregarProducto(Producto prod)
        {
            int retorna = 0;

            using (SqlConnection conexion = SQL.Conectar())
            {
                string consulta = $"insert into Productos (Costo,Código,Descripción,Precio,Existencia) values ('{prod.Costo}','{prod.Codigo}','{prod.Descripcion}','{prod.Precio}','{prod.Existencia}')";
                SqlCommand commando = new SqlCommand(consulta, conexion);
                retorna = commando.ExecuteNonQuery();
            }
            return retorna;
        }

        public static int EliminarAdmin(Administrador admin)
        {
            int retorna = 0;
            using (SqlConnection conexion = SQL.Conectar())
            {
                string consulta = $"delete from Administradores where Usuario={admin.Usuario}";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }

        public static int EliminarVend(Vendedor vend)
        {
            int retorna = 0;
            using (SqlConnection conexion = SQL.Conectar())
            {
                string consulta = $"delete from Vendedores where Usuario={vend.Usuario}";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }

        public static int EliminarCliente(Cliente cl)
        {
            int retorna = 0;
            using (SqlConnection conexion = SQL.Conectar())
            {
                string consulta = $"delete from Clientes where CUIT={cl.CUIT}";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }

        public static int EliminarProd(Producto prod)
        {
            int retorna = 0;
            using (SqlConnection conexion = SQL.Conectar())
            {
                string consulta = $"delete from Productos where Código={prod.Codigo}";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }

        public static List<Administrador> PresentarAdmins()
        {
            List<Administrador> ListaDeAdministradores = new List<Administrador>();
            using (SqlConnection conexion = SQL.Conectar())
            {
                string consulta = "select *from administradores";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Administrador administrador = new Administrador();
                    administrador.Usuario = lector.GetString(1);
                    administrador.Contraseña = lector.GetString(2);
                    ListaDeAdministradores.Add(administrador);
                }
                conexion.Close();
                return ListaDeAdministradores;
            }
        }

        public static List<Vendedor> PresentarVendedores()
        {
            List<Vendedor> listvend = new List<Vendedor>();
            using (SqlConnection conexion = SQL.Conectar())
            {
                string consulta = "select * from Vendedores";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Vendedor nuevo = new Vendedor();
                    nuevo.Usuario = lector.GetString(1);
                    nuevo.Contraseña = lector.GetString(2);
                    listvend.Add(nuevo);
                }
                conexion.Close();
                return listvend;
            }
        }

        public static List<Cliente> PresentarClientes()
        {
            List<Cliente> listcliente = new List<Cliente>();
            string consulta = "select * from Clientes";
            SqlConnection conexion = SQL.Conectar();
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Cliente cl = new Cliente();
                cl.CUIT = lector.GetInt32(0);
                cl.Razon = lector.GetString(1);
                listcliente.Add(cl);
            }
            conexion.Close();
            return listcliente;
        }

        public static List<Producto> PresentarProductos()
        {
            List<Producto> listprod = new List<Producto>();
            using (SqlConnection conexion = SQL.Conectar())
            {
                string consulta = "select * from Productos";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Producto producto = new Producto();
                    producto.Codigo = lector.GetInt16(0);
                    producto.Costo = lector.GetInt16(1);
                    producto.Descripcion = lector.GetString(2);
                    producto.Precio = lector.GetInt16(3);
                    producto.Existencia = lector.GetInt16(4);
                    listprod.Add(producto);
                }
                conexion.Close();
                return listprod;
            }
        }

        public static List<Operaciones> PresentarOperaciones()
        {
            List<Operaciones> ListaDeOperaciones = new List<Operaciones>();
            using (SqlConnection conexion = SQL.Conectar())
            {
                string consulta = "select *from Operaciones";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Operaciones nueva = new Operaciones();
                    nueva.Num = lector.GetInt16(0);
                    nueva.Fecha = lector.GetDateTime(1);
                    nueva.CUITCliente = lector.GetInt32(2);
                    nueva.RazonCliente = lector.GetString(3);
                    nueva.MedioPago = lector.GetString(4);
                    nueva.Habilitada = Convert.ToBoolean(lector.GetString(5));
                    string consultaprod = "select * from ListaCompras";
                    SqlConnection conexion2 = SQL.Conectar();
                    SqlCommand comandoprod = new SqlCommand(consultaprod, conexion2);
                    SqlDataReader lector2 = comandoprod.ExecuteReader();
                    while (lector2.Read())
                    {
                        if ( nueva.Num == lector2.GetInt16(0) )
                        {
                            Producto nuevo = new Producto();
                            nuevo.Costo = lector2.GetInt16(1);
                            nuevo.Codigo = lector2.GetInt16(2);
                            nuevo.Descripcion = lector2.GetString(3);
                            nuevo.Precio = lector2.GetInt16(4);
                            nuevo.Existencia = lector2.GetInt16(5);
                            nueva.ListCompra.Add(nuevo);
                        }
                    }
                    ListaDeOperaciones.Add(nueva);
                }
                conexion.Close();
                return ListaDeOperaciones;
            }
        }
    }
}