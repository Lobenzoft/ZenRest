using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace ZenResturant
{
    class DataVenta
    {

        MySqlConnection conexion;
        MySqlCommand query;
        MySqlDataAdapter tabla;
        Cnx cn;

        public DataVenta()
        {
            cn = new Cnx();
        }

        public void CrudVenta(string id, double nit_ci, string fecha_venta, double importe, string vendedor, string accion)
        {
            //agregar-new
            //editar-update
            //eliminar-delete
            conexion = cn.AbrirConexion();
            query = new MySqlCommand(string.Format("call crudBoletaVenta ({0},{1},'{2}',{3},{4},'{5}')", id, nit_ci, fecha_venta, importe, vendedor, accion), conexion);
            query.ExecuteNonQuery();
            cn.CerrarConexion();
        }

        public void Crudpago(string id, string boleta, double cinit, double monto,string vendedor, string accion)
        {
            //agregar-new
            //editar-update
            //eliminar-delete
            conexion = cn.AbrirConexion();
            query = new MySqlCommand(string.Format("call crudPago ({0},{1},{2},{3},{4},'{5}')", id, boleta, cinit, monto, vendedor, accion), conexion);
            query.ExecuteNonQuery();
            cn.CerrarConexion();
        }

        public void CrudCompraDetalle(string id, string codigo, double precio, double cantidad, double total, string id_boleta, string accion)
        {
            //agregar-new
            //editar-update
            //eliminar-delete
            conexion = cn.AbrirConexion();
            query = new MySqlCommand(string.Format("call crudVenta ({0},'{1}','{2}',{3},{4},'{5}','{6}')", id, codigo, precio, cantidad, total, id_boleta, accion), conexion);
            query.ExecuteNonQuery();
            cn.CerrarConexion();
        }
        public DataTable CrudVenta(string accion)
        {
            //consulta-select
            DataTable datatable = new DataTable();
            conexion = cn.AbrirConexion();
            tabla = new MySqlDataAdapter(string.Format("call crudBoletaVenta ({0},{1},'{2}',{3},{4},'{5}')", "0", "0", "0", "0", "0", accion), conexion);
            tabla.Fill(datatable);
            return datatable;
        }
        public DataTable CrudVenta(string fecha,string accion)
        {
            //consulta-select
            DataTable datatable = new DataTable();
            conexion = cn.AbrirConexion();
            tabla = new MySqlDataAdapter(string.Format("call crudBoletaVenta ({0},{1},'{2}',{3},{4},'{5}')", "0", "0", fecha, "0", "0", accion), conexion);
            tabla.Fill(datatable);
            return datatable;
        }
    }
}
