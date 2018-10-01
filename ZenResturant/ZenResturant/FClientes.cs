using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZenResturant
{
    public partial class FClientes : UserControl
    {
        DataCliente dataC;
        public FClientes()
        {
            InitializeComponent();
            dataC = new DataCliente();
            CargarDataGrid();
        }
        private void CargarDataGrid()
        {
            DGridClientes.DataSource = dataC.CrudCliente("select");
            //DGridClientes.Columns[0].Width = 1;
            DGridClientes.Columns[1].HeaderText = "Nombre";
            DGridClientes.Columns[2].HeaderText = "CI o NIT";
            DGridClientes.Columns[3].HeaderText = "Celular";
        }

        private void BAgregarCliente_Click(object sender, EventArgs e)
        {
            FAgregarClientes agregarc = new FAgregarClientes();
            Inicio.Cargarf(agregarc);
        }

        private void BEditarCliente_Click(object sender, EventArgs e)
        {
            FEditarClientes editarc = new FEditarClientes(DGridClientes.CurrentRow.Cells[0].Value.ToString());
            Inicio.Cargarf(editarc);
            //DGridClientes.CurrentRow.Cells[0].Value;
        }

        private void BEliminarCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirme si desea eliminar", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataC.CrudCliente(DGridClientes.CurrentRow.Cells[0].Value.ToString(), "", "", "", "delete");
                CargarDataGrid();
            }
        }
    }
}
