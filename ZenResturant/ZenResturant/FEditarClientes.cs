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
    public partial class FEditarClientes : UserControl
    {
        DataCliente dataC;
        private string _id_cliente;
        public FEditarClientes(string id_cliente)
        {
            InitializeComponent();
            _id_cliente = id_cliente;
            dataC = new DataCliente();
            DataTable dataT = new DataTable();
            dataT = dataC.CrudCliente(_id_cliente, "selectId");
            DataRow row = dataT.Rows[0];
            TextNombre.Text = row["nombre_cliente"].ToString();
            TextCINIT.Text = row["ci_cliente"].ToString();
            TextCelular.Text = row["celular_cliente"].ToString();
        }

        private void CargarClientes()
        {
            FClientes fclientes = new FClientes();
            Inicio.Cargarf(fclientes);
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            dataC.CrudCliente(_id_cliente, TextNombre.Text, TextCINIT.Text, TextCelular.Text, "update");
            CargarClientes();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }
    }
}
