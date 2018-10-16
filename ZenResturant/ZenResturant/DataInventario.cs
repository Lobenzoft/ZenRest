using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace ZenResturant
{
    class DataInventario
    {
        MySqlConnection conexion;
        MySqlCommand query;
        MySqlDataAdapter tabla;
        Cnx cn;
        public DataInventario()
        {
            cn = new Cnx();
        }
        public void CrudInventario(string codigo, string cantidad, string accion)
        {
            //compra-compra
            //venta-venta
            conexion = cn.AbrirConexion();
            query = new MySqlCommand(string.Format("call crudInventario ('{0}',{1},'{2}')", codigo, cantidad, accion), conexion);
            query.ExecuteNonQuery();
            cn.CerrarConexion();
        }
        public DataTable CrudInventario(string accion)
        {
            //consulta-select
            DataTable datatable = new DataTable();
            conexion = cn.AbrirConexion();
            tabla = new MySqlDataAdapter(string.Format("call crudInventario ('{0}',{1},'{2}')", "", 0, accion), conexion);
            tabla.Fill(datatable);
            return datatable;
        }
    }
}
