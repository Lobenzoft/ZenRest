using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace ZenResturant
{
    class Cnx
    {
        private MySqlConnection Conexion;

        public Cnx()
        {
            Conexion = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=zen-restaurant;Uid=root;Pwd='';SslMode=none");
        }

        public MySqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public MySqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
