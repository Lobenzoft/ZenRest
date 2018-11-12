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
            if (TextNombre.Text !="" )
            {
                    dataC.CrudCliente("0", TextNombre.Text, TextCINIT.Text, TextCelular.Text, "new");
                    CargarClientes();
            }
            else
            {
            
                MessageBoxEx.Show("Debe ingresar datos en todos los campos", "Alerta!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              
            }
            
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void TextNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void TextCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }
    }
}
