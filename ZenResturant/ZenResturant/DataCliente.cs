using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace ZenResturant
{
    class DataCliente
    {
        MySqlConnection conexion;
        MySqlCommand query;
        MySqlDataAdapter tabla;
        Cnx cn;
        public DataCliente()
        {
            cn = new Cnx();
        }
        public void CrudCliente(string id, string nombre, string ci, string celular, string accion)
        {
            //agregar-new
            //editar-update
            //eliminar-delete
            conexion = cn.AbrirConexion();
            query = new MySqlCommand(string.Format("call crudCliente ({0},'{1}','{2}','{3}','{4}')", id, nombre, ci, celular, accion), conexion);
            query.ExecuteNonQuery();
            cn.CerrarConexion();
        }
        public DataTable CrudCliente(string accion)
        {
            //consulta-select
            DataTable datatable = new DataTable();
            conexion = cn.AbrirConexion();
            tabla = new MySqlDataAdapter(string.Format("call crudCliente ({0},'{1}','{2}','{3}','{4}')", 0, "", "", "", accion), conexion);
            tabla.Fill(datatable);
            return datatable;
        }
        public DataTable CrudCliente(string id, string accion)
        {
            //consulta por id-selectId
            DataTable datatable = new DataTable();
            conexion = cn.AbrirConexion();
            tabla = new MySqlDataAdapter(string.Format("call crudCliente ({0},'{1}','{2}','{3}','{4}')", id, "", "", "", accion), conexion);
            tabla.Fill(datatable);
            return datatable;
        }
        public DataTable CrudClienteCI(string ci, string accion)
        {
            //consulta por id-selectId
            DataTable datatable = new DataTable();
            conexion = cn.AbrirConexion();
            tabla = new MySqlDataAdapter(string.Format("call crudCliente ({0},'{1}','{2}','{3}','{4}')", 0, "", "", "", accion), conexion);
            tabla.Fill(datatable);
            return datatable;
        }
    }
}
