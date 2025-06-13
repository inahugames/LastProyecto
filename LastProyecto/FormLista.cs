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
    public partial class FormLista : Form
    {
        public FormLista()
        {
            InitializeComponent();
            ActualizoDGV();
        }

        public void ActualizoDGV()
        {
            dgvClientes.DataSource = null;
            dgvOperacion.DataSource = null;
            dgvProductos.DataSource = null;
            dgvClientes.DataSource = Registracion.ListClientes;
            dgvOperacion.DataSource = Registracion.ListOperaciones;
            dgvProductos.DataSource = Registracion.ListProductos;
        }

        private void dgvOperaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
