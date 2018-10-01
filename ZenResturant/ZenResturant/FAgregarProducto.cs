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
            ComboOpcion.SelectedIndex = 0;
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
            string opcion_inventario = ComboOpcion.SelectedValue.ToString();
            dataP.CrudProducto("0", TextNombre.Text, TextCodigo.Text, opcion_inventario, "new");
            CargarProducto();
        }
    }
}
