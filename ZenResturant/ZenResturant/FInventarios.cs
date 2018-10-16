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
        }
        private void CargarDataGrid() => DGridInventarios.DataSource = dataI.CrudInventario("select");
    }
}
