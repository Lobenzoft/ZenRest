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
    public partial class FProductos : UserControl
    {
        DataProducto dataP;
        public FProductos()
        {
            InitializeComponent();
            dataP = new DataProducto();
            CargarDataGrid();
        }
        private void CargarDataGrid()
        {
            DGridProductos.DataSource = dataP.CrudProducto("select");
            //DGridProductos.Columns[0].Width = 1;
            DGridProductos.Columns[1].HeaderText = "Nombre";
            DGridProductos.Columns[2].HeaderText = "Codigo";
            DGridProductos.Columns[3].HeaderText = "Inventario";
        }

        private void BAgregarProducto_Click(object sender, EventArgs e)
        {
            FAgregarProducto agregarp = new FAgregarProducto();
            Inicio.Cargarf(agregarp);
        }

        private void BEditarProducto_Click(object sender, EventArgs e)
        {
            FEditarProducto editarp = new FEditarProducto(DGridProductos.CurrentRow.Cells[0].Value.ToString());
            Inicio.Cargarf(editarp);
        }

        private void BEliminarProducto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirme si desea eliminar", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataP.CrudProducto(DGridProductos.CurrentRow.Cells[0].Value.ToString(), "", "", "", "delete");
                CargarDataGrid();
            }
        }
    }
}
