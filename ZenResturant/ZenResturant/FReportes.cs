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
    public partial class FReportes : UserControl
    {
        DataReporte dataR;
        public FReportes()
        {
            InitializeComponent();
            dataR = new DataReporte();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dddd dd,MMMMyyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dddd dd,MMMMyyyy";
            DGridCompras.DataSource= dataR.CrudReporte(dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss"), dateTimePicker2.Value.ToString("yyyy-MM-dd hh:mm:ss"),"Compras");
            DGridVentas.DataSource = dataR.CrudReporte(dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss"), dateTimePicker2.Value.ToString("yyyy-MM-dd hh:mm:ss"), "Ventas");

            
            DGridCompras.Columns[0].HeaderText = "CODIGO_PRODUCTO";
            DGridCompras.Columns[1].HeaderText = "GLOSA";
            DGridCompras.Columns[2].HeaderText = "FECHA";
            DGridCompras.Columns[3].HeaderText = "CANTIDAD";
            DGridCompras.Columns[4].HeaderText = "PRECIO_COMPRA (U)";
            DGridCompras.Columns[5].HeaderText = "IMPORTE";
            //DGridCompras.Columns[4].Visible = false;
            DGridCompras.Columns[1].Width = 450;

            DGridVentas.Columns[0].Visible = false;
            DGridVentas.Columns[1].HeaderText = "NIT";
            DGridVentas.Columns[2].HeaderText = "FECHA";
            DGridVentas.Columns[3].HeaderText = "IMPORTE";
            DGridVentas.Columns[4].Visible = false;
            DGridVentas.Columns[5].Visible = false;


          /*  double total = 0.00;
            for (int fila = DGridCompras.Rows.Count - 1; fila >= 0; fila--)
            {
                total += Convert.ToDouble(DGridCompras.Rows[fila].Cells[3].Value) * Convert.ToDouble(DGridCompras.Rows[fila].Cells[3].Value);
            }
            texTotal.Text = Math.Round(total, 2).ToString("N2");
            texTotal.Enabled = false;

            double totalventas = 0.00;
            for (int fila = DGridVentas.Rows.Count - 1; fila >= 0; fila--)
            {
                totalventas += Convert.ToDouble(DGridVentas.Rows[fila].Cells[3].Value);/*+ Convert.ToDouble(DGridCompras.Rows[fila].Cells[3].Value);
            }
            txtTotalVentas.Text = Math.Round(totalventas, 2).ToString("N2");
            txtTotalVentas.Enabled = false;*/
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DGridCompras.DataSource = dataR.CrudReporte(dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss"), dateTimePicker2.Value.ToString("yyyy-MM-dd hh:mm:ss"), "Compras");
            DGridVentas.DataSource = dataR.CrudReporte(dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss"), dateTimePicker2.Value.ToString("yyyy-MM-dd hh:mm:ss"), "Ventas");

            double total = 0.00;
            for (int fila = DGridCompras.Rows.Count - 1; fila >= 0; fila--)
            {
                total += Convert.ToDouble(DGridCompras.Rows[fila].Cells[5].Value);/*+ Convert.ToDouble(DGridCompras.Rows[fila].Cells[3].Value);*/
            }
            texTotal.Text = Math.Round(total, 2).ToString("N2");
            texTotal.Enabled = false;

            double totalventas = 0.00;
            for (int fila = DGridVentas.Rows.Count - 1; fila >= 0; fila--)
            {
                totalventas += Convert.ToDouble(DGridVentas.Rows[fila].Cells[3].Value);/*+ Convert.ToDouble(DGridCompras.Rows[fila].Cells[3].Value);*/
            }
            txtTotalVentas.Text = Math.Round(totalventas, 2).ToString("N2");
            txtTotalVentas.Enabled = false;

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DGridCompras.DataSource = dataR.CrudReporte(dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss"), dateTimePicker2.Value.ToString("yyyy-MM-dd hh:mm:ss"), "Compras");
            DGridVentas.DataSource = dataR.CrudReporte(dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss"), dateTimePicker2.Value.ToString("yyyy-MM-dd hh:mm:ss"), "Ventas");

            double total = 0.00;
            for (int fila = DGridCompras.Rows.Count - 1; fila >= 0; fila--)
            {
                total += Convert.ToDouble(DGridCompras.Rows[fila].Cells[5].Value);/*+ Convert.ToDouble(DGridCompras.Rows[fila].Cells[3].Value);*/
            }
            texTotal.Text = Math.Round(total, 2).ToString("N2");
            texTotal.Enabled = false;

            double totalventas = 0.00;
            for (int fila = DGridVentas.Rows.Count - 1; fila >= 0; fila--)
            {
                totalventas += Convert.ToDouble(DGridVentas.Rows[fila].Cells[3].Value);/*+ Convert.ToDouble(DGridCompras.Rows[fila].Cells[3].Value);*/
            }
            txtTotalVentas.Text = Math.Round(totalventas, 2).ToString("N2");
            txtTotalVentas.Enabled = false;
        }

        private void DGridCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel_Export excel_Class = new Excel_Export();
            try
            {
                if (tabControl1.SelectedTab.Name == "tabPage1")
                {
                    System.Diagnostics.Process.Start(excel_Class.crear_exel_compras(DGridCompras));
                    
                }
                else
                {
                    System.Diagnostics.Process.Start(excel_Class.crear_exel_ventas(DGridVentas));
                }
                

            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Operación Cancelada");
            }
        }
    }
}
