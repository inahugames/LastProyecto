using LibreriaClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastProyecto
{
    public partial class ListarOperaciones : Form
    {
        int seleccion;
        int n = 0;
        bool prod;
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
            if (prod == false)
            {
                dgvOperaciones.Rows.Clear();
                n = 0;
                while (n < Registracion.ListOperaciones.Count)
                {
                    if (Registracion.ListOperaciones[n].CUITCliente == Registracion.ListClientes[seleccion].CUIT)
                    {
                        dgvOperaciones.Rows.Add(Registracion.ListOperaciones[n].GenerarObjeto());
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
                while ( n < Registracion.ListOperaciones.Count )
                {
                    if ( Registracion.ListOperaciones[n].CodigoProducto == Registracion.ListProductos[seleccion].Codigo )
                    {
                        dgvOperaciones.Rows.Add(Registracion.ListOperaciones[n].GenerarObjeto());
                        n++;
                    }
                    else
                    {
                        n++;
                    }
                }
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
    }
}
