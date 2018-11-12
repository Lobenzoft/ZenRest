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
    public partial class FInventarios : UserControl
    {
        DataInventario dataI;
        public FInventarios()
        {
            InitializeComponent();
            dataI = new DataInventario();
            CargarDataGrid();

            List<string> Categorias = new List<string>();
            Categorias.Add("Desayuno");
            Categorias.Add("Almuerzo");
            Categorias.Add("Cena");
            Categorias.Add("Bebidas");
            Categorias.Add("Extras");
            Categorias.Add("Compras");
            ComboCategoriaBIn.DataSource = Categorias;
            ComboCategoriaBIn.SelectedIndex = 3;
        }
        private void CargarDataGrid() => DGridInventarios.DataSource = dataI.CrudInventario("select");

        private void textBuscadorIn_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string categoria = ComboCategoriaBIn.SelectedValue.ToString();
                DGridInventarios.DataSource = dataI.CrudInventariolike(textBuscadorIn.Text, categoria, "selectLike");
            }
            catch (Exception ex)
            {

            }
            
        }
    }
}
