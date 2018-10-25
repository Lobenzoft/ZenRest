using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace ZenResturant
{
    class DataReporte
    {
        MySqlConnection conexion;
        MySqlCommand query;
        MySqlDataAdapter tabla;
        Cnx cn;
        public DataReporte()
        {
            cn = new Cnx();
        }

        public DataTable CrudReporte(string fecha_ini,string fecha_fin,string accion)
        {
            DataTable datatable = new DataTable();
            conexion = cn.AbrirConexion();
            tabla = new MySqlDataAdapter(string.Format("call CrudReporte ('{0}','{1}','{2}')", fecha_ini, fecha_fin, accion), conexion);
            tabla.Fill(datatable);
            return datatable;
        }
    }
}
