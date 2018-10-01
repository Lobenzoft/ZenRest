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
    public partial class FAgregarClientes : UserControl
    {
        DataCliente dataC;
        public FAgregarClientes()
        {
            InitializeComponent();
            dataC = new DataCliente();
        }

        private void CargarClientes()
        {
            FClientes fclientes = new FClientes();
            Inicio.Cargarf(fclientes);
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            dataC.CrudCliente("0", TextNombre.Text, TextCINIT.Text, TextCelular.Text, "new");
            CargarClientes();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }
    }
}
