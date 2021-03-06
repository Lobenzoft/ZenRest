﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevComponents.DotNetBar;

namespace ZenResturant
{
    public partial class FBoletaVenta : UserControl
    {
        DataCliente dataC;
        DataProducto dataP;
        DataVenta dataV;
        Ticket tckt;

        public FBoletaVenta()
        {
            InitializeComponent();
            dataV = new DataVenta();
            dataP = new DataProducto();
            dataC = new DataCliente();

            DGridListaD.DataSource = dataP.CrudProductoCategoria("selectCategoria", "Desayuno");
            DGridListaD.Columns[0].Visible = false;
            DGridListaD.Columns[1].HeaderText = "NOMBRE";
            DGridListaD.Columns[2].Visible = false;
            DGridListaD.Columns[3].HeaderText = "COD.";
            //DGridListaD.Columns[4].Visible = false;
            DGridListaD.Columns[4].HeaderText = "PRECIO";
            DGridListaD.Columns[5].HeaderText = "INV.";

            DGridListaD.Columns[1].Width = 200;
            DGridListaD.Columns[3].Width = 60;
            DGridListaD.Columns[4].Width = 46;
            DGridListaD.Columns[5].Width = 60;
            DGridListaD.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            DGridListaA.DataSource = dataP.CrudProductoCategoria("selectCategoria", "Almuerzo");
            DGridListaA.Columns[0].Visible = false;
            DGridListaA.Columns[1].HeaderText = "NOMBRE";
            DGridListaA.Columns[2].Visible = false;
            DGridListaA.Columns[3].HeaderText = "COD.";
            //DGridListaA.Columns[4].Visible = false;
            DGridListaA.Columns[4].HeaderText = "PRECIO";
            DGridListaA.Columns[4].HeaderText = "INV.";

            DGridListaA.Columns[1].Width = 200;
            DGridListaA.Columns[3].Width = 60;
            DGridListaA.Columns[4].Width = 46;
            DGridListaA.Columns[5].Width = 60;
            DGridListaA.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DGridListaC.DataSource = dataP.CrudProductoCategoria("selectCategoria", "Cena");
            DGridListaC.Columns[0].Visible = false;
            DGridListaC.Columns[1].HeaderText = "NOMBRE";
            DGridListaC.Columns[2].Visible = false;
            DGridListaC.Columns[3].HeaderText = "COD.";
            //DGridListaC.Columns[4].Visible = false;
            DGridListaC.Columns[4].HeaderText = "PRECIO";
            DGridListaC.Columns[5].HeaderText = "INV.";

            DGridListaC.Columns[1].Width = 200;
            DGridListaC.Columns[3].Width = 60;
            DGridListaC.Columns[4].Width = 46;
            DGridListaC.Columns[5].Width = 60;
            DGridListaC.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DGridListaB.DataSource = dataP.CrudProductoCategoria("selectCategoria", "Bebidas");
            DGridListaB.Columns[0].Visible = false;
            DGridListaB.Columns[1].HeaderText = "NOMBRE";
            DGridListaB.Columns[2].Visible = false;
            DGridListaB.Columns[3].HeaderText = "COD.";
            //DGridListaB.Columns[4].Visible = false;
            DGridListaB.Columns[4].HeaderText = "PRECIO";
            DGridListaB.Columns[5].HeaderText = "INV.";

            DGridListaB.Columns[1].Width = 200;
            DGridListaB.Columns[3].Width = 60;
            DGridListaB.Columns[4].Width = 46;
            DGridListaB.Columns[5].Width = 60;
            DGridListaB.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            DGridListaE.DataSource = dataP.CrudProductoCategoria("selectCategoria", "Extras");
            DGridListaE.Columns[0].Visible = false;
            DGridListaE.Columns[1].HeaderText = "NOMBRE";
            DGridListaE.Columns[2].Visible = false;
            DGridListaE.Columns[3].HeaderText = "COD.";
            //DGridListaE.Columns[4].Visible = false;
            DGridListaE.Columns[4].HeaderText = "PRECIO";
            DGridListaE.Columns[5].HeaderText = "INV.";

            DGridListaE.Columns[1].Width = 200;
            DGridListaE.Columns[3].Width = 60;
            DGridListaE.Columns[4].Width = 46;
            DGridListaE.Columns[5].Width = 60;
            DGridListaE.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            /* DGridListaCompras.DataSource = dataP.CrudProductoCategoria("selectCategoria", "Compras");
             DGridListaCompras.Columns[0].Visible = false;
             DGridListaCompras.Columns[1].HeaderText = "Nombre";
             DGridListaCompras.Columns[2].Visible = false;
             DGridListaCompras.Columns[3].HeaderText = "Codigo";
             DGridListaCompras.Columns[4].Visible = false;
             DGridListaCompras.Columns[5].HeaderText = "Inventario";*/


            DataTable tabla = new DataTable();
            tabla = dataV.CrudVenta(dateTimePicker1.Value.ToString("yyyy-MM-dd"), "obtener_norden");
            DataRow row = tabla.Rows[0];
            textBox3.Text = row[0].ToString();
            textBox7.Text = Inicio.cambiarwifi();



        }

        private void DGridLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DGridProductos.Rows.Add(DGridListaD.CurrentRow.Cells[2].Value, DGridListaD.CurrentRow.Cells[1].Value, DGridListaD.CurrentRow.Cells[3].Value, 0);
        }

        private void AceptarVenta_Click(object sender, EventArgs e)
        {

            if (DGridProductos.Rows.Count > 0)
            {
                dataV.CrudVenta("0", Convert.ToDouble(textBox1.Text), dateTimePicker1.Value.ToString("yyyy-MM-dd"), Math.Round(Convert.ToDouble(textBox4.Text), 2), "0", "new");
                DataTable tabla = new DataTable();
                tabla = dataV.CrudVenta("ultimo_id");
                DataRow row = tabla.Rows[0];
                for (int fila = DGridProductos.Rows.Count - 1; fila >= 0; fila--)
                {
                    dataV.CrudCompraDetalle("0", DGridProductos.Rows[fila].Cells[0].Value.ToString(), Convert.ToDouble(DGridProductos.Rows[fila].Cells[2].Value), Convert.ToDouble(DGridProductos.Rows[fila].Cells[3].Value), Convert.ToDouble(DGridProductos.Rows[fila].Cells[2].Value) * Convert.ToDouble(DGridProductos.Rows[fila].Cells[3].Value), row[0].ToString(), "new");
                }
                dataV.Crudpago("0", row[0].ToString(), Convert.ToDouble(textBox1.Text), Math.Round(Convert.ToDouble(textBox5.Text), 2), "0", "new");
                FBoletaVenta fBoletaventa = new FBoletaVenta();


                ImprimirTckt(textBox7.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss"), textBox3.Text, Convert.ToDouble(textBox4.Text).ToString("N2"), Convert.ToDouble(textBox8.Text).ToString("N2"), Convert.ToDouble(textBox9.Text).ToString("N2"));
                Inicio.Cargarf(fBoletaventa);
            }
            else
            {
                MessageBoxEx.Show("Ud debe Seleccionar un producto para realizar la Venta", "Alerta!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            
        }

        private void ImprimirTckt(string wifi, string fecha, string orden, string total, string efectivo, string cambio)
        {
            tckt = new Ticket();
            tckt.TextoCentro("WIFI: " + wifi);
            tckt.TextoCentro("NOTA DE VENTA");
            tckt.lineasGuio();
            tckt.TextoPar("FECHA: " + fecha,"#ORDEN : " + orden);
            //tckt.TextoIzquierda("FECHA: "+fecha);
            //tckt.TextoDerecha("#ORDEN : " + orden);
            if (checkBox1.Checked==true)
            {
                tckt.TextoCentro("PEDIDO PARA MESA");
            }
            else
            {
                tckt.TextoCentro("PEDIDO PARA LLEVAR");
            }
            tckt.lineasGuio();
            tckt.Textodetalle("CANT.","DETALLE","P.UNIT","SUB.TOTAL");
            tckt.lineasGuio();
            for (int fila = DGridProductos.Rows.Count - 1; fila >= 0; fila--)
            {
                tckt.Textodetalle(DGridProductos.Rows[fila].Cells[3].Value.ToString(),DGridProductos.Rows[fila].Cells[1].Value.ToString(), DGridProductos.Rows[fila].Cells[2].Value.ToString(),(Convert.ToDouble( DGridProductos.Rows[fila].Cells[2].Value)*Convert.ToDouble( DGridProductos.Rows[fila].Cells[3].Value)).ToString("N2"));
            }
            tckt.lineasGuio();
            tckt.TextoPar("", "TOTAL : " + total);
            tckt.TextoPar("", "EFECTIVO : " + efectivo);
            tckt.TextoPar("", "CAMBIO : " + cambio);

            tckt.TextoCentro("");
            tckt.TextoCentro("GRACIAS POR SU PREFERENCIA");
            tckt.TextoCentro("LO ESPERAMOS PRONTO");
            //ticket.TextoCentro("1234567890123456789012345678901234567890");
            for (int i = 0; i <= 3; i++)
            {
                tckt.TextoCentro(" ");
            }
            tckt.TextoCentro("NOTA DE PEDIDO #ORDEN : " + orden);
            if (checkBox1.Checked == true)
            {
                tckt.TextoCentro("PEDIDO PARA MESA");
            }
            else
            {
                tckt.TextoCentro("PEDIDO PARA LLEVAR");
            }
            tckt.lineasGuio();
            tckt.Textodetalle("", "DETALLE", "CANTIDAD", "");
            tckt.CortaTicket();
            for (int fila = DGridProductos.Rows.Count - 1; fila >= 0; fila--)
            {
                tckt.Textodetalle("", DGridProductos.Rows[fila].Cells[1].Value.ToString(),"   "+ DGridProductos.Rows[fila].Cells[3].Value.ToString(), "");
            }
            for (int i = 0; i <= 3; i++)
            {
                tckt.TextoCentro(" ");
            }
            tckt.TextoCentro("BART RESTAURAT NANNY-GOURMET");
            tckt.TextoCentro("DIRECCION: AV. EL REMANSO #9025");
            tckt.TextoCentro("TELEFONO:69201375");
            tckt.CortaTicket();
            tckt.ImprimirTicket("TM-U330");
            
        }

        private void DGridProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double total = 0.00;
            for (int fila = DGridProductos.Rows.Count - 1; fila >= 0; fila--)
            {
                total += Convert.ToDouble(DGridProductos.Rows[fila].Cells[2].Value) * Convert.ToDouble(DGridProductos.Rows[fila].Cells[3].Value);
            }
            textBox4.Text = Math.Round(total, 2).ToString("N2");
        }

        private void DGridProductos_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            double total = 0.00;
            for (int fila = DGridProductos.Rows.Count - 1; fila >= 0; fila--)
            {
                total += Convert.ToDouble(DGridProductos.Rows[fila].Cells[2].Value) * Convert.ToDouble(DGridProductos.Rows[fila].Cells[3].Value);
            }
            textBox4.Text = Math.Round(total, 2).ToString("N2");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox6.Text = (Math.Round(Convert.ToDouble(textBox4.Text) - Convert.ToDouble(textBox5.Text), 2)).ToString();
                textBox8.Text = (Convert.ToDouble(textBox5.Text).ToString());//- Convert.ToDouble(textBox5.Text)).ToString();
            }
            catch
            {

            }
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Inicio.cambiarwifi(textBox7.Text);
        }

        private void DGridListaD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DGridProductos.Rows.Add(DGridListaD.CurrentRow.Cells[3].Value, DGridListaD.CurrentRow.Cells[1].Value, DGridListaD.CurrentRow.Cells[4].Value, 1);
        }

        private void DGridListaA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DGridProductos.Rows.Add(DGridListaA.CurrentRow.Cells[3].Value, DGridListaA.CurrentRow.Cells[1].Value, DGridListaA.CurrentRow.Cells[4].Value, 1);
        }

        private void DGridListaC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DGridProductos.Rows.Add(DGridListaC.CurrentRow.Cells[3].Value, DGridListaC.CurrentRow.Cells[1].Value, DGridListaC.CurrentRow.Cells[4].Value, 1);
        }

        private void DGridListaB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DGridProductos.Rows.Add(DGridListaB.CurrentRow.Cells[3].Value, DGridListaB.CurrentRow.Cells[1].Value, DGridListaB.CurrentRow.Cells[4].Value, 1);

        }

        private void DGridListaE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DGridProductos.Rows.Add(DGridListaE.CurrentRow.Cells[3].Value, DGridListaE.CurrentRow.Cells[1].Value, DGridListaE.CurrentRow.Cells[4].Value, 1);

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dataT = new DataTable();
            dataT = dataC.CrudClienteCI(textBox1.Text, "selectCI");
            try
            {
                DataRow row = dataT.Rows[0];
                textBox2.Text = row["nombre_cliente"].ToString();
            }
            catch
            {
                textBox2.Text = " ";
            }
            
        }

        private void DGridListaD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox9.Text = (Convert.ToDouble(textBox8.Text) - Convert.ToDouble(textBox5.Text)).ToString();
            }
            catch
            {
            }
        }

        private void DGridListaA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox10_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void textBuscador_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (tabControl1.SelectedTab.Name == "tabPage1")
                {
                    DGridListaD.DataSource = dataP.CrudBuscarProducto(textBuscador.Text, "Desayuno", "selectLIKE");
                }
                else if (tabControl1.SelectedTab.Name == "tabPage2")
                {
                    DGridListaA.DataSource = dataP.CrudBuscarProducto(textBuscador.Text, "Almuerzo", "selectLIKE");
                }
                else if (tabControl1.SelectedTab.Name == "tabPage3")
                {
                    DGridListaC.DataSource = dataP.CrudBuscarProducto(textBuscador.Text, "Cena", "selectLIKE");
                }
                else if (tabControl1.SelectedTab.Name == "tabPage4")
                {
                    DGridListaB.DataSource = dataP.CrudBuscarProducto(textBuscador.Text, "Bebidas", "selectLIKE");
                }
                else if (tabControl1.SelectedTab.Name == "tabPage5")
                {
                    DGridListaE.DataSource = dataP.CrudBuscarProducto(textBuscador.Text, "Extras", "selectLIKE");
                }
                /* else if (tabControl1.SelectedTab.Name == "tabPage6")
                 {
                     DGridListaCompras.DataSource = dataP.CrudBuscarProducto(textBuscador.Text, "Compras", "selectLIKE");
                 }
                 else
                 {
                     DGridListaD.DataSource = dataP.CrudProductoCategoria("selectCategoria", "Desayuno");
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

                     DGridListaB.DataSource = dataP.CrudProductoCategoria("selectCategoria", "Bebidas");
                     DGridListaB.Columns[0].Visible = false;
                     DGridListaB.Columns[1].HeaderText = "Nombre";
                     DGridListaB.Columns[2].Visible = false;
                     DGridListaB.Columns[3].HeaderText = "Codigo";
                     DGridListaB.Columns[4].Visible = false;
                     DGridListaB.Columns[5].HeaderText = "Inventario";

                     DGridListaE.DataSource = dataP.CrudProductoCategoria("selectCategoria", "Extras");
                     DGridListaE.Columns[0].Visible = false;
                     DGridListaE.Columns[1].HeaderText = "Nombre";
                     DGridListaE.Columns[2].Visible = false;
                     DGridListaE.Columns[3].HeaderText = "Codigo";
                     DGridListaE.Columns[4].Visible = false;
                     DGridListaE.Columns[5].HeaderText = "Inventario";

                     DGridListaCompras.DataSource = dataP.CrudProductoCategoria("selectCategoria", "Compras");
                     DGridListaCompras.Columns[0].Visible = false;
                     DGridListaCompras.Columns[1].HeaderText = "Nombre";
                     DGridListaCompras.Columns[2].Visible = false;
                     DGridListaCompras.Columns[3].HeaderText = "Codigo";
                     DGridListaCompras.Columns[4].Visible = false;
                     DGridListaCompras.Columns[5].HeaderText = "Inventario";
                 }*/

            }
            catch
            {

            }
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            textBuscador.Text = "";
        }

        private void btnQutarfila_Click(object sender, EventArgs e)
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
