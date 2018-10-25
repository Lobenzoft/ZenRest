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

            DGridCompras.Columns[0].Visible = false;
            DGridCompras.Columns[1].HeaderText = "Glosa";
            DGridCompras.Columns[2].HeaderText = "Fecha";
            DGridCompras.Columns[3].HeaderText = "Importe";
            DGridCompras.Columns[4].Visible = false;

            DGridVentas.Columns[0].Visible = false;
            DGridVentas.Columns[1].HeaderText = "Nit";
            DGridVentas.Columns[2].HeaderText = "Fecha";
            DGridVentas.Columns[3].HeaderText = "Importe";
            DGridVentas.Columns[4].Visible = false;
            DGridVentas.Columns[5].Visible = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DGridCompras.DataSource = dataR.CrudReporte(dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss"), dateTimePicker2.Value.ToString("yyyy-MM-dd hh:mm:ss"), "Compras");
            DGridVentas.DataSource = dataR.CrudReporte(dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss"), dateTimePicker2.Value.ToString("yyyy-MM-dd hh:mm:ss"), "Ventas");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DGridCompras.DataSource = dataR.CrudReporte(dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss"), dateTimePicker2.Value.ToString("yyyy-MM-dd hh:mm:ss"), "Compras");
            DGridVentas.DataSource = dataR.CrudReporte(dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss"), dateTimePicker2.Value.ToString("yyyy-MM-dd hh:mm:ss"), "Ventas");
        }
    }
}
