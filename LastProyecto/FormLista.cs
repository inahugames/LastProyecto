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
            foreach ( Cliente client in Registracion.ListClientes )
            {
                dgvClientes.Rows.Add(client.GenerarObjeto());
            }
            foreach (Operaciones op in Registracion.ListOperaciones)
            {
                dgvOperacion.Rows.Add(op.GenerarObjeto());
            }
            foreach ( Producto prod in Registracion.ListProductos )
            {
                dgvProductos.Rows.Add(prod.GenerarObjeto());
            }
        }

        private void dgvOperaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvOperacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
