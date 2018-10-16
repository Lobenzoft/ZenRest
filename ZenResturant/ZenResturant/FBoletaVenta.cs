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
            
            DGridLista.DataSource = dataP.CrudProducto("select");
            DGridLista.Columns[0].Visible = false;
            DGridLista.Columns[1].HeaderText = "Nombre";
            DGridLista.Columns[2].HeaderText = "Codigo";
            DGridLista.Columns[3].HeaderText = "Precio";
            //DGridLista.Columns[3].Visible = false;
            DGridLista.Columns[4].Visible = false;
            DataTable tabla = new DataTable();
            tabla = dataV.CrudVenta(dateTimePicker1.Value.ToString("yyyy-MM-dd"), "obtener_norden");
            DataRow row = tabla.Rows[0];
            textBox3.Text = row[0].ToString();
            textBox7.Text = Inicio.cambiarwifi();
        }

        private void DGridLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DGridProductos.Rows.Add(DGridLista.CurrentRow.Cells[2].Value, DGridLista.CurrentRow.Cells[1].Value, DGridLista.CurrentRow.Cells[3].Value, 0);
        }

        private void AceptarVenta_Click(object sender, EventArgs e)
        {
            /*
            dataV.CrudVenta("0", Convert.ToDouble(textBox1.Text),dateTimePicker1.Value.ToString("yyyy-MM-dd"),Math.Round(Convert.ToDouble(textBox4.Text),2),"0","new");
            DataTable tabla = new DataTable();
            tabla = dataV.CrudVenta("ultimo_id");
            DataRow row = tabla.Rows[0];
            for (int fila = DGridProductos.Rows.Count - 1; fila >= 0; fila--)
            {
                dataV.CrudCompraDetalle("0", DGridProductos.Rows[fila].Cells[0].Value.ToString(), Convert.ToDouble(DGridProductos.Rows[fila].Cells[2].Value), Convert.ToDouble(DGridProductos.Rows[fila].Cells[3].Value), Convert.ToDouble(DGridProductos.Rows[fila].Cells[2].Value) * Convert.ToDouble(DGridProductos.Rows[fila].Cells[3].Value), row[0].ToString(), "new");
            }
            dataV.Crudpago("0",row[0].ToString(), Convert.ToDouble(textBox1.Text),Math.Round(Convert.ToDouble(textBox5.Text),2),"0","new");
            FBoletaVenta fBoletaventa = new FBoletaVenta();
            */

            ImprimirTckt(textBox7.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss"), textBox3.Text,Convert.ToDouble( textBox4.Text).ToString("N2"));
            //Inicio.Cargarf(fBoletaventa);
        }

        private void ImprimirTckt(string wifi,string fecha,string orden,string total)
        {
            tckt = new Ticket();
            
            tckt.TextoCentro("WIFI: " + wifi);
            tckt.TextoCentro("NOTA DE VENTA");
            tckt.lineasGuio();
            tckt.TextoPar("FECHA: " + fecha,"#ORDEN : " + orden);
            //tckt.TextoIzquierda("FECHA: "+fecha);
            //tckt.TextoDerecha("#ORDEN : " + orden);
            tckt.lineasGuio();
            tckt.Textodetalle("Cant.","Detalle","P.Unit","Sub.Total");
            tckt.lineasGuio();
            for (int fila = DGridProductos.Rows.Count - 1; fila >= 0; fila--)
            {
                tckt.Textodetalle(DGridProductos.Rows[fila].Cells[3].Value.ToString(),DGridProductos.Rows[fila].Cells[1].Value.ToString(), DGridProductos.Rows[fila].Cells[2].Value.ToString(),(Convert.ToDouble( DGridProductos.Rows[fila].Cells[2].Value)*Convert.ToDouble( DGridProductos.Rows[fila].Cells[3].Value)).ToString("N2"));
            }
            tckt.lineasGuio();
            tckt.TextoPar("", "Total : " + total);
            tckt.TextoCentro("");
            tckt.TextoCentro("GRACIAS POR SU PREFERENCIA");
            tckt.TextoCentro("LO ESPERAMOS PRONTO");
            //ticket.TextoCentro("1234567890123456789012345678901234567890");
            for (int i = 0; i <= 3; i++)
            {
                tckt.TextoCentro("");
            }
            tckt.TextoCentro("NOTA DE PEDIDO #ORDEN : " + orden);
            tckt.lineasGuio();
            tckt.Textodetalle("", "Detalle", "Cantidad", "");
            tckt.CortaTicket();
            for (int fila = DGridProductos.Rows.Count - 1; fila >= 0; fila--)
            {
                tckt.Textodetalle("", DGridProductos.Rows[fila].Cells[1].Value.ToString(), DGridProductos.Rows[fila].Cells[3].Value.ToString(), "");
            }
            for (int i = 0; i <= 3; i++)
            {
                tckt.TextoCentro("");
            }
            tckt.TextoCentro("BART RESTAURAT NANNY-GOURMET");
            tckt.TextoCentro("DIRECCION: AV. EL REMANSO #9025");
            tckt.TextoCentro("TELEFONO:77646295-63507961");
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
            textBox6.Text = (Math.Round(Convert.ToDouble(textBox4.Text)-Convert.ToDouble(textBox5.Text),2)).ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Inicio.cambiarwifi(textBox7.Text);
        }
    }
}
