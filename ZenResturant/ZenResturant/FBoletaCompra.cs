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
    public partial class FBoletaCompra : UserControl
    {
        DataCompra dataC;
        DataProducto dataP;
        public FBoletaCompra()
        {
            InitializeComponent();
            dataC = new DataCompra();
            dataP = new DataProducto();
            DGridLista.DataSource = dataP.CrudProducto("select");
            DGridLista.Columns[0].Visible = false;
            DGridLista.Columns[1].HeaderText = "Nombre";
            DGridLista.Columns[2].HeaderText = "Codigo";
            DGridLista.Columns[3].Visible = false;
            DGridLista.Columns[4].Visible = false;

        }

        private void DGridLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DGridProductos.Rows.Add(DGridLista.CurrentRow.Cells[2].Value, DGridLista.CurrentRow.Cells[1].Value, 0,0);
        }

        private void DGridProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double total = 0.00;
            for (int fila = DGridProductos.Rows.Count - 1; fila >= 0; fila--)
            {
                total += Convert.ToDouble(DGridProductos.Rows[fila].Cells[2].Value) * Convert.ToDouble(DGridProductos.Rows[fila].Cells[3].Value);
            }
            TotalCompra.Text = Math.Round(total, 2).ToString("N2");
        }

        private void DGridProductos_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            double total = 0.00;
            for (int fila = DGridProductos.Rows.Count - 1; fila >= 0; fila--)
            {
                total += Convert.ToDouble(DGridProductos.Rows[fila].Cells[2].Value) * Convert.ToDouble(DGridProductos.Rows[fila].Cells[3].Value);
            }
            TotalCompra.Text = Math.Round(total, 2).ToString("N2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataC.CrudCompra("0",GlosaCompra.Text, FechaCompra.Value.ToString("yyyy-MM-dd"), Math.Round(Convert.ToDouble(TotalCompra.Text), 2),"0","new");
            DataTable tabla = new DataTable();
            tabla = dataC.CrudCompra("ultimo_id");
            DataRow row = tabla.Rows[0];
            for (int fila = DGridProductos.Rows.Count - 1; fila >= 0; fila--)
            {
                dataC.CrudCompraDetalle("0", DGridProductos.Rows[fila].Cells[0].Value.ToString(), Convert.ToDouble(DGridProductos.Rows[fila].Cells[2].Value), Convert.ToDouble(DGridProductos.Rows[fila].Cells[3].Value), Convert.ToDouble(DGridProductos.Rows[fila].Cells[2].Value)* Convert.ToDouble(DGridProductos.Rows[fila].Cells[3].Value), row[0].ToString(), "new");
            }
            FBoletaCompra fboletacompra = new FBoletaCompra();
            Inicio.Cargarf(fboletacompra);
        }
    }
}
