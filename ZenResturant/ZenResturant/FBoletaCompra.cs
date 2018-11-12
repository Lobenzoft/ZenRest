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
    public partial class FBoletaCompra : UserControl
    {
        DataCompra dataC;
        DataProducto dataP;
        public FBoletaCompra()
        {
            InitializeComponent();
            dataC = new DataCompra();
            dataP = new DataProducto();
            /*DGridListaD.DataSource = dataP.CrudProductoCategoria("selectCategoria","Desayuno");
            DGridListaD.Columns[0].Visible = false;
            DGridListaD.Columns[1].HeaderText = "Nombre";
            DGridListaD.Columns[2].Visible = false;
            DGridListaD.Columns[3].HeaderText = "Codigo";
            DGridListaD.Columns[4].Visible = false;
            DGridListaD.Columns[5].HeaderText = "Inventario";

            DGridListaA.DataSource = dataP.CrudProductoCategoria("selectCategoria", "Almuerzo");
            DGridListaA.Columns[0].Visible = false;
            DGridListaA.Columns[1].HeaderText = "Nombre";
            DGridListaA.Columns[2].Visible = false;
            DGridListaA.Columns[3].HeaderText = "Codigo";
            DGridListaA.Columns[4].Visible = false;
            DGridListaA.Columns[5].HeaderText = "Inventario";

            DGridListaC.DataSource = dataP.CrudProductoCategoria("selectCategoria", "Cena");
            DGridListaC.Columns[0].Visible = false;
            DGridListaC.Columns[1].HeaderText = "Nombre";
            DGridListaC.Columns[2].Visible = false;
            DGridListaC.Columns[3].HeaderText = "Codigo";
            DGridListaC.Columns[4].Visible = false;
            DGridListaC.Columns[5].HeaderText = "Inventario";


            DGridListaE.DataSource = dataP.CrudProductoCategoria("selectCategoria", "Extras");
            DGridListaE.Columns[0].Visible = false;
            DGridListaE.Columns[1].HeaderText = "Nombre";
            DGridListaE.Columns[2].Visible = false;
            DGridListaE.Columns[3].HeaderText = "Codigo";
            DGridListaE.Columns[4].Visible = false;
            DGridListaE.Columns[5].HeaderText = "Inventario";*/

            DGridListaB.DataSource = dataP.CrudProductoCategoria("selectCategoria", "Bebidas");
            DGridListaB.Columns[0].Visible = false;
            DGridListaB.Columns[1].HeaderText = "Nombre";
            DGridListaB.Columns[2].Visible = false;
            DGridListaB.Columns[3].HeaderText = "Codigo";
            DGridListaB.Columns[4].Visible = false;
            DGridListaB.Columns[5].HeaderText = "Inventario";

            DGridListaB.Columns[1].Width = 200;
            DGridListaB.Columns[3].Width = 60;
            DGridListaB.Columns[5].Width = 60;




            DGridListaCompras.DataSource = dataP.CrudProductoCategoria("selectCategoria", "Compras");
            DGridListaCompras.Columns[0].Visible = false;
            DGridListaCompras.Columns[1].HeaderText = "Nombre";
            DGridListaCompras.Columns[2].Visible = false;
            DGridListaCompras.Columns[3].HeaderText = "Codigo";
            DGridListaCompras.Columns[4].Visible = false;
            DGridListaCompras.Columns[5].HeaderText = "Inventario";

            DGridListaCompras.Columns[1].Width = 200;
            DGridListaCompras.Columns[3].Width = 60;
            DGridListaCompras.Columns[5].Width = 60;

        }

        /*private void DGridLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DGridProductos.Rows.Add(DGridListaD.CurrentRow.Cells[3].Value, DGridListaD.CurrentRow.Cells[1].Value, 0,0);
        }*/

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
            if (DGridProductos.Rows.Count > 0)
            {
                dataC.CrudCompra("0", GlosaCompra.Text, FechaCompra.Value.ToString("yyyy-MM-dd"), Math.Round(Convert.ToDouble(TotalCompra.Text), 2), "0", "new");
                DataTable tabla = new DataTable();
                tabla = dataC.CrudCompra("ultimo_id");
                DataRow row = tabla.Rows[0];
                for (int fila = DGridProductos.Rows.Count - 1; fila >= 0; fila--)
                {



                    dataC.CrudCompraDetalle("0", DGridProductos.Rows[fila].Cells[0].Value.ToString(), Convert.ToDouble(DGridProductos.Rows[fila].Cells[2].Value), Convert.ToDouble(DGridProductos.Rows[fila].Cells[3].Value), Convert.ToDouble(DGridProductos.Rows[fila].Cells[2].Value) * Convert.ToDouble(DGridProductos.Rows[fila].Cells[3].Value), row[0].ToString(), "new");
                }
                FBoletaCompra fboletacompra = new FBoletaCompra();
                Inicio.Cargarf(fboletacompra);
            }
            else 
            {
                MessageBoxEx.Show("Ud debe Seleccionar un producto para realizar la Compra", "Alerta!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        /*private void DGridListaA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DGridProductos.Rows.Add(DGridListaA.CurrentRow.Cells[3].Value, DGridListaA.CurrentRow.Cells[1].Value, 0, 0);
        }

        private void DGridListaC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DGridProductos.Rows.Add(DGridListaC.CurrentRow.Cells[3].Value, DGridListaC.CurrentRow.Cells[1].Value, 0, 0);
        }*/

        private void DGridListaB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DGridProductos.Rows.Add(DGridListaB.CurrentRow.Cells[3].Value, DGridListaB.CurrentRow.Cells[1].Value, 0, 0);
        }

        /*private void DGridListaE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DGridProductos.Rows.Add(DGridListaE.CurrentRow.Cells[3].Value, DGridListaE.CurrentRow.Cells[1].Value, 0, 0);
        }*/

        private void DGridListaCompras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DGridProductos.Rows.Add(DGridListaCompras.CurrentRow.Cells[3].Value, DGridListaCompras.CurrentRow.Cells[1].Value, 0, 0);
        }

        private void FechaCompra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBuscadorC_TextChanged(object sender, EventArgs e)
        {

            try
            {

                if (tabControl1.SelectedTab.Name == "tabPage4")
                {
                    DGridListaB.DataSource = dataP.CrudBuscarProducto(textBuscadorC.Text, "Bebidas", "selectLIKE");
                }
                else if (tabControl1.SelectedTab.Name == "tabPage6")
                {
                    DGridListaCompras.DataSource = dataP.CrudBuscarProducto(textBuscadorC.Text, "Compras", "selectLIKE");
                }
               
            }
            catch
            {

            }
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            textBuscadorC.Text = "";
        }

        private void TotalCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQutarfilaC_Click(object sender, EventArgs e)
        {
            try
            {
                DGridProductos.Rows.RemoveAt(DGridProductos.CurrentRow.Index);
            }
            catch
            {

            }
        }
    }
}
