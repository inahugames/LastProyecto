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
    }
}
