using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace ZenResturant
{
    class DataProducto
    {
        MySqlConnection conexion;
        MySqlCommand query;
        MySqlDataAdapter tabla;
        Cnx cn;
        public DataProducto()
        {
            cn = new Cnx();
        }

        public void CrudProducto(string id, string nombre,string categoria,string precio, string codigo, string opcion_inventario, string accion)
        {
            //agregar-new
            //editar-update
            //eliminar-delete
            conexion = cn.AbrirConexion();
            query = new MySqlCommand(string.Format("call crudProducto ({0},'{1}','{2}',{3},'{4}','{5}','{6}')", id, nombre, categoria, precio, codigo, opcion_inventario, accion), conexion);
            query.ExecuteNonQuery();
            cn.CerrarConexion();
        }



        public DataTable CrudProducto(string accion)
        {
            //consulta-select
            DataTable datatable = new DataTable(); ;
            conexion = cn.AbrirConexion();
            tabla = new MySqlDataAdapter(string.Format("call crudProducto ({0},'{1}','{2}',{3},'{4}','{5}','{6}')", 0, "", "", 0, "", "", accion), conexion);
            tabla.Fill(datatable);
            return datatable;
        }

        public DataTable CrudProductoCategoria(string accion,string categoria)
        {
            //consulta-select
            DataTable datatable = new DataTable(); ;
            conexion = cn.AbrirConexion();
            tabla = new MySqlDataAdapter(string.Format("call crudProducto ({0},'{1}','{2}',{3},'{4}','{5}','{6}')", 0, "", categoria, 0, "", "", accion), conexion);
            tabla.Fill(datatable);
            return datatable;
        }

        public DataTable CrudProducto(string id, string accion)
        {
            //consulta por id-selectId
            DataTable datatable = new DataTable(); ;
            conexion = cn.AbrirConexion();
            tabla = new MySqlDataAdapter(string.Format("call crudProducto ({0},'{1}','{2}',{3},'{4}','{5}','{6}')", id, "", "", 0, "", "", accion), conexion);
            tabla.Fill(datatable);
            return datatable;
        }

        public DataTable CrudBuscarProducto(string nombre, string categoria, string accion)
        {
            //consulta por id-selectId
            DataTable datatable = new DataTable();
            conexion = cn.AbrirConexion();
            string consulta = string.Format("call crudProducto ({0},'{1}%','{2}',{3},'{4}','{5}','{6}')", 0, nombre, categoria, 0, "", "", accion);
            tabla = new MySqlDataAdapter(consulta,conexion);
            tabla.Fill(datatable);
            return datatable;
        }
    }
}
