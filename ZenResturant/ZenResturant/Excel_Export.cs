using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ZenResturant
{
    class Excel_Export
    {
        private Microsoft.Office.Interop.Excel.Application excel;
        private Workbook worKbooK;
        private Worksheet worKsheeT;
        private Range celLrangE;

        private string mesanum(string mes)
        {
            string num = "";
            if (mes == "ENERO")
            {
                num = "01";
            }
            if (mes == "FEBRERO")
            {
                num = "02";
            }
            if (mes == "MARZO")
            {
                num = "03";
            }
            if (mes == "ABRIL")
            {
                num = "04";
            }
            if (mes == "MAYO")
            {
                num = "05";
            }
            if (mes == "JUNIO")
            {
                num = "06";
            }
            if (mes == "JULIO")
            {
                num = "07";
            }
            if (mes == "AGOSTO")
            {
                num = "08";
            }
            if (mes == "SEPTIEMBRE")
            {
                num = "09";
            }
            if (mes == "OCTUBRE")
            {
                num = "10";
            }
            if (mes == "NOVIEMBRE")
            {
                num = "11";
            }
            if (mes == "DICIEMBRE")
            {
                num = "12";
            }
            return num;
        }
        private void crear_cabecera_compras(ref Worksheet hoja, string nombre_empresa, string lugar_empresa, string desde, string hasta, string nit)
        {
            celLrangE = null;

           // hoja.Cells[1, 1] = nombre_empresa;
           // hoja.Cells[2, 1] = lugar_empresa;
            //hoja.Cells[3, 1] = "NIT: " + nit;
            celLrangE = hoja.Range[worKsheeT.Cells[5, 2], worKsheeT.Cells[5, 2]];
            celLrangE.ColumnWidth = 30;
            
            celLrangE.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue);

            celLrangE.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            celLrangE = hoja.Range[worKsheeT.Cells[5, 3], worKsheeT.Cells[5, 3]];
            celLrangE.ColumnWidth = 70;
            celLrangE.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            celLrangE.WrapText = true;
            celLrangE.EntireColumn.AutoFit();

            celLrangE.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue);
            celLrangE.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            celLrangE = hoja.Range[worKsheeT.Cells[5, 4], worKsheeT.Cells[5, 4]];
            celLrangE.ColumnWidth = 15;
            celLrangE.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            celLrangE.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue);

            celLrangE.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            celLrangE = hoja.Range[worKsheeT.Cells[5, 5], worKsheeT.Cells[5, 5]];
            celLrangE.ColumnWidth = 15;
            celLrangE.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue);
            celLrangE.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            celLrangE = hoja.Range[worKsheeT.Cells[5, 6], worKsheeT.Cells[5, 5]];
            celLrangE.ColumnWidth = 15;
            celLrangE.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            celLrangE.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue);
            celLrangE = hoja.Range[worKsheeT.Cells[5, 7], worKsheeT.Cells[5, 7]];
            celLrangE.ColumnWidth = 15;
            celLrangE.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            celLrangE.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue);


           // celLrangE = hoja.Range[worKsheeT.Cells[3, 2], worKsheeT.Cells[10, 7]];
           // celLrangE.ColumnWidth = 40;
            //celLrangE.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            //celLrangE.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue);



            //celLrangE.HorizontalAlignment = HorizontalAlignment.Center;
            celLrangE.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //hoja.Cells[4, 5] = "REPORTE DE COMPRAS";
           // hoja.Cells[6, 5] = "NANNYGOURMET ";
           // hoja.Cells[7, 5] = "(EXPRESADO EN BOLIVIANOS)";

            hoja.Cells[5, 2] = "COD_PRODUCTO";
            hoja.Cells[5, 3] = "GLOSA";
            hoja.Cells[5, 4] = "FECHA";
            hoja.Cells[5, 5] = "CANTIDAD";
            hoja.Cells[5, 6] = "PRECIO_COMPRA";
            hoja.Cells[5, 7] = "IMPORTE";
        }
        public string crear_exel_compras(DataGridView data )
        {
            string direccion = @"C:\";
            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //excel.Columns.WrapText = true;
                //excel.Columns.AutoFit();

                worKbooK = excel.Workbooks.Add(Type.Missing);
                worKsheeT = (Microsoft.Office.Interop.Excel.Worksheet)worKbooK.ActiveSheet;
                worKsheeT.Name = "Compras";
                crear_cabecera_compras(ref worKsheeT,"", "", "", "","");
                int i = 0;
                for (i = 0; i < data.Rows.Count; i++)
                {
                    

                    //excel.Range[worKsheeT.Cells[i + 1, 4], worKsheeT.Cells[i + 2, 11]].NumberFormat = "0";

                    worKsheeT.Cells[i + 6, 2] = data.Rows[i].Cells[0].Value.ToString();
                    worKsheeT.Cells[i + 6, 3] = data.Rows[i].Cells[1].Value.ToString();
                    worKsheeT.Cells[i + 6, 4] = data.Rows[i].Cells[2].Value.ToString();
                    worKsheeT.Cells[i + 6, 5] = data.Rows[i].Cells[3].Value.ToString();
                    worKsheeT.Cells[i + 6, 6] = data.Rows[i].Cells[4].Value.ToString();
                    worKsheeT.Cells[i + 6, 7] = data.Rows[i].Cells[5].Value.ToString();



                    // worKsheeT.Cells[i + 12, 4] = data.Rows[i].Cells[4].Value.ToString();



                }

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = @"C:\";
                saveFileDialog1.Title = "Guardar Archivo Excel";
                saveFileDialog1.DefaultExt = "xlsx";
                saveFileDialog1.Filter = "Archivo Excel (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                string fechaa = System.DateTime.Now.ToString("ddMMyyyy");
                saveFileDialog1.FileName = "REPORTE_COMPRAS_" + ".xlsx";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    direccion = saveFileDialog1.FileName;
                    worKbooK.SaveAs(direccion);
                    MessageBox.Show("Compras Creado!");
                }
                else
                {
                    direccion = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                worKbooK.Close();
                excel.Quit();
                worKsheeT = null;
                celLrangE = null;
                worKbooK = null;
            }
            return direccion;
        }
        private void crear_cabecera_ventas(ref Worksheet hoja, string nombre_empresa, string lugar_empresa, string desde, string hasta, string nit)
        {
            celLrangE = null;

            // hoja.Cells[1, 1] = nombre_empresa;
            // hoja.Cells[2, 1] = lugar_empresa;
            //hoja.Cells[3, 1] = "NIT: " + nit;
            celLrangE = hoja.Range[worKsheeT.Cells[11, 2], worKsheeT.Cells[11, 2]];
            celLrangE.ColumnWidth = 70;
            celLrangE.WrapText = true;
            celLrangE.EntireColumn.AutoFit();
            celLrangE.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue);

            celLrangE.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            celLrangE = hoja.Range[worKsheeT.Cells[11, 3], worKsheeT.Cells[11, 3]];
            celLrangE.ColumnWidth = 30;
            celLrangE.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue);
            celLrangE.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            celLrangE = hoja.Range[worKsheeT.Cells[11, 4], worKsheeT.Cells[11, 4]];
            celLrangE.ColumnWidth = 30;
            celLrangE.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            celLrangE.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue);


            celLrangE = hoja.Range[worKsheeT.Cells[3, 2], worKsheeT.Cells[10, 4]];
            celLrangE.ColumnWidth = 50;
            celLrangE.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            celLrangE.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue);



            //celLrangE.HorizontalAlignment = HorizontalAlignment.Center;
            celLrangE.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            hoja.Cells[4, 3] = "REPORTE DE VENTAS";
            hoja.Cells[6, 3] = "NANNYGOURMET ";
            hoja.Cells[7, 3] = "(EXPRESADO EN BOLIVIANOS)";

            hoja.Cells[11, 2] = "NIT_CI";
            hoja.Cells[11, 3] = "FECHA";
            hoja.Cells[11, 4] = "IMPORTE BS.";
        }
        public string crear_exel_ventas(DataGridView data)
        {
            string direccion = @"C:\";
            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //excel.Columns.WrapText = true;
                //excel.Columns.AutoFit();

                worKbooK = excel.Workbooks.Add(Type.Missing);
                worKsheeT = (Microsoft.Office.Interop.Excel.Worksheet)worKbooK.ActiveSheet;
                worKsheeT.Name = "VENTAS";
                crear_cabecera_ventas(ref worKsheeT, "", "", "", "", "");
                int i = 0;
                for (i = 0; i < data.Rows.Count; i++)
                {


                    excel.Range[worKsheeT.Cells[i + 2, 4], worKsheeT.Cells[i + 2, 11]].NumberFormat = "0";

                    worKsheeT.Cells[i + 12, 2] = data.Rows[i].Cells[1].Value.ToString();
                    worKsheeT.Cells[i + 12, 3] = data.Rows[i].Cells[2].Value.ToString();
                    worKsheeT.Cells[i + 12, 4] = data.Rows[i].Cells[3].Value.ToString();


                    // worKsheeT.Cells[i + 12, 4] = data.Rows[i].Cells[4].Value.ToString();



                }

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = @"C:\";
                saveFileDialog1.Title = "Guardar Archivo Excel";
                saveFileDialog1.DefaultExt = "xlsx";
                saveFileDialog1.Filter = "Archivo Excel (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                string fechaa = System.DateTime.Now.ToString("ddMMyyyy");
                saveFileDialog1.FileName = "REPORTE_VENTAS" + ".xlsx";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    direccion = saveFileDialog1.FileName;
                    worKbooK.SaveAs(direccion);
                    MessageBox.Show("Ventas Creado!");
                }
                else
                {
                    direccion = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                worKbooK.Close();
                excel.Quit();
                worKsheeT = null;
                celLrangE = null;
                worKbooK = null;
            }
            return direccion;
        }
    }
}
