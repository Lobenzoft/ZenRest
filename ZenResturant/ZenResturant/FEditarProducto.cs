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
    public partial class FEditarProducto : UserControl
    {
        DataProducto dataP;
        private string _id_producto;
        public FEditarProducto(string id_producto)
        {
            InitializeComponent();
            dataP = new DataProducto();
            DataTable dataT = new DataTable();
            dataT = dataP.CrudProducto(id_producto, "selectId");
            DataRow row = dataT.Rows[0];
            TextNombre.Text = row["nombre_producto"].ToString();
            TextPrecio.Text = row["precio_producto"].ToString();
            TextCodigo.Text = row["codigo_producto"].ToString();
            string categoria = row["categoria"].ToString();
            _id_producto = id_producto;
            List<string> Opciones = new List<string>();
            Opciones.Add("Si");
            Opciones.Add("No");
            ComboOpcion.DataSource = Opciones;
            if (row["inventario_producto"].ToString() == "Si")
            {
                ComboOpcion.SelectedIndex = 0;
            }
            else
            {
                ComboOpcion.SelectedIndex = 1;
            }
            List<string> Categorias = new List<string>();
            Categorias.Add("Desayuno");
            Categorias.Add("Almuerzo");
            Categorias.Add("Cena");
            Categorias.Add("Bebidas");
            Categorias.Add("Extras");
            Categorias.Add("Compras");
            ComboCategoria.DataSource = Categorias;
            ComboCategoria.SelectedIndex = 0;

            if (categoria== "Desayuno")
            {
                ComboCategoria.SelectedIndex = 0;
            }
            else if (categoria == "Almuerzo")
            {
                ComboCategoria.SelectedIndex = 1;
            }
            else if (categoria == "Cena")
            {
                ComboCategoria.SelectedIndex = 2;
            }
            else if (categoria == "Bebidas")
            {
                ComboCategoria.SelectedIndex = 3;
            }
            else if (categoria == "Extras")
            {
                ComboCategoria.SelectedIndex = 4;
            }
            else if (categoria == "Compras")
            {
                ComboCategoria.SelectedIndex = 5;
            }
            else
            {
                ComboCategoria.SelectedIndex = 0;
            }

        }

        private void CargarFProductos()
        {
            FProductos fproductos = new FProductos();
            Inicio.Cargarf(fproductos);
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {

            string opcion_inventario = ComboOpcion.SelectedValue.ToString();
            string categoria = ComboCategoria.SelectedValue.ToString();
            dataP.CrudProducto(_id_producto, TextNombre.Text,categoria,TextPrecio.Text, TextCodigo.Text, opcion_inventario, "update");
            CargarFProductos();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            CargarFProductos();
        }
    }
}
