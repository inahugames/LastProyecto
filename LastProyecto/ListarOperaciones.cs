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
        public ListarOperaciones()
        {
            InitializeComponent();
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = Registracion.ListClientes;
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccion = e.RowIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvOperaciones.Rows.Clear();
            while ( n < Registracion.ListOperaciones.Count )
            {
                if ( Registracion.ListOperaciones[n].CUITCliente == Registracion.ListClientes[seleccion].CUIT )
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
}
