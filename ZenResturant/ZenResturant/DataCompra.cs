using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ZenResturant
{
    class DataCompra
    {
        MySqlConnection conexion;
        MySqlCommand query;
        MySqlDataAdapter tabla;
        Cnx cn;

        public DataCompra()
        {
            cn = new Cnx();
        }

        public void CrudCompra(string id, string glosa_compra, string fecha_compra, double importe,string vendedor, string accion)
        {
            //agregar-new
            //editar-update
            //eliminar-delete
            conexion = cn.AbrirConexion();
            query = new MySqlCommand(string.Format("call crudBoletaCompra ({0},'{1}','{2}',{3},{4},'{5}')", id, glosa_compra, fecha_compra, importe, vendedor, accion), conexion);
            query.ExecuteNonQuery();
            cn.CerrarConexion();
        }
        public void CrudCompraDetalle(string id, string codigo, double precio, double cantidad, double total,string id_boleta, string accion)
        {
            //agregar-new
            //editar-update
            //eliminar-delete
            conexion = cn.AbrirConexion();
            query = new MySqlCommand(string.Format("call crudCompra ({0},'{1}','{2}',{3},{4},'{5}','{6}')", id, codigo, precio, cantidad, total, id_boleta, accion), conexion);
            query.ExecuteNonQuery();
            cn.CerrarConexion();
        }
        public DataTable CrudCompra(string accion)
        {
            //consulta-select
            DataTable datatable = new DataTable(); ;
            conexion = cn.AbrirConexion();
            tabla = new MySqlDataAdapter(string.Format("call crudBoletaCompra ({0},'{1}','{2}',{3},{4},'{5}')", "0", "0", "0", "0", "0", accion), conexion);
            tabla.Fill(datatable);
            return datatable;
        }
    }
}
