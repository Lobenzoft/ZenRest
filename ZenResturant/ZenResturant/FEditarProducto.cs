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
            TextCodigo.Text = row["codigo_producto"].ToString();
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
        }

        private void CargarFProductos()
        {
            FProductos fproductos = new FProductos();
            Inicio.Cargarf(fproductos);
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            string opcion_inventario = ComboOpcion.SelectedValue.ToString();
            dataP.CrudProducto(_id_producto, TextNombre.Text, TextCodigo.Text, opcion_inventario, "update");
            CargarFProductos();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            CargarFProductos();
        }
    }
}
