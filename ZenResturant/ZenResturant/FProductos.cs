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
            DGridProductos.Columns[0].Visible = false;
            DGridProductos.Columns[1].HeaderText = "Nombre";
            DGridProductos.Columns[2].HeaderText = "Categoria";
            DGridProductos.Columns[3].HeaderText = "Codigo";
            DGridProductos.Columns[4].HeaderText = "Precio";

            //DGridProductos.Columns[0].Width = 17;
            DGridProductos.Columns[1].Width = 200;










            List<string> Categorias = new List<string>();
            Categorias.Add("Desayuno");
            Categorias.Add("Almuerzo");
            Categorias.Add("Cena");
            Categorias.Add("Bebidas");
            Categorias.Add("Extras");
            Categorias.Add("Compras");
            ComboCategoriaB.DataSource = Categorias;
            ComboCategoriaB.SelectedIndex = 3;


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
                dataP.CrudProducto(DGridProductos.CurrentRow.Cells[0].Value.ToString(), "","","0", "","", "delete");
                CargarDataGrid();
            }
        }

        private void textBuscadorP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string categoria = ComboCategoriaB.SelectedValue.ToString();
                DGridProductos.DataSource = dataP.CrudBuscarProducto(textBuscadorP.Text, categoria, "selectLIKE");
            }
            catch(Exception ex)
            {

            }
           
        }
        
    }
}
