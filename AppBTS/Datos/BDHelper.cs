using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos
{
    class BDHelper
    {

        private SqlConnection conexion = new SqlConnection();
        private SqlCommand comando = new SqlCommand();
        private string cadenaConexion = @"Data Source=DESKTOP-IDESOLO\SQLEXPRESS;Integrated Security=True";

        public DataTable consultar(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }
    }
}
