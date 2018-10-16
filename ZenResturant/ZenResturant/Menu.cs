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
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void VentaButon_Click(object sender, EventArgs e)
        {
            FBoletaVenta fBoletaventa = new FBoletaVenta();
            Inicio.Cargarf(fBoletaventa);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FClientes fclientes = new FClientes();
            Inicio.Cargarf(fclientes);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FProductos fproductos = new FProductos();
            Inicio.Cargarf(fproductos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FInventarios finventarios = new FInventarios();
            Inicio.Cargarf(finventarios);
        }

        private void CompraButon_Click(object sender, EventArgs e)
        {
            FBoletaCompra fboletacompra = new FBoletaCompra();
            Inicio.Cargarf(fboletacompra);
        }
    }
}
