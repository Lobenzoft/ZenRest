using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace ZenResturant
{
    public partial class FAgregarProducto : UserControl
    {
        DataProducto dataP;
        public FAgregarProducto()
        {
            InitializeComponent();
            dataP = new DataProducto();
            List<string> Opciones = new List<string>();
            Opciones.Add("Si");
            Opciones.Add("No");
            ComboOpcion.DataSource = Opciones;
            ComboOpcion.SelectedIndex = 1;
            List<string> Categorias = new List<string>();
            Categorias.Add("Desayuno");
            Categorias.Add("Almuerzo");
            Categorias.Add("Cena");
            Categorias.Add("Bebidas");
            Categorias.Add("Extras");
            Categorias.Add("Compras");
            ComboCategoria.DataSource = Categorias;
            ComboCategoria.SelectedIndex = 0;
        }

        private void CargarProducto()
        {
            FProductos fproductos = new FProductos();
            Inicio.Cargarf(fproductos);
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            CargarProducto();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            if (TextNombre.Text !="" ) { 
                string opcion_inventario = ComboOpcion.SelectedValue.ToString();
                string categoria = ComboCategoria.SelectedValue.ToString();
                dataP.CrudProducto("0", TextNombre.Text, categoria,TextPrecio.Text, TextCodigo.Text, opcion_inventario, "new");
                CargarProducto();
            }
            else
            {
                MessageBoxEx.Show("Debe llenar todos los datos correspondientes", "Advertencia", MessageBoxButtons.OK);
            }
        }

        private void TextNombre_TextChanged(object sender, EventArgs e)
        {
            TextCodigo.Text = "COD.-" + TextNombre.Text;
        }

       
    }
}
