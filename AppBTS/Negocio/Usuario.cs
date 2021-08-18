using AppBTS.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Negocio
{
    class Usuario
    {
    
        // ejemplos prop

        private int id_usuario;

        public int Id_usuario
        {
          get { return id_usuario; }
            set { id_usuario = value; }
        }

        //private string nombre;

        //public string Nombre
        //{
        //get { return nombre; }
        //set { nombre = value; }
        //}

        public string Nombre { get; set; }

        public string Password { get; set; }
        public string Email { get; set; }
        public int Id_perfil { get; set; }
        public string Estado { get; set; }
        public bool Borrado { get; set; }

        public int validarUsuario(string nombre, string clave)
        {
            string consulta = "SELECT * FROM [BugsTracker].[dbo].[Usuarios] WHERE usuario='" + nombre + "' AND password ='" + clave + "'";

            BDHelper oDatos = new BDHelper();
            DataTable tabla = oDatos.consultar(consulta);
            if (tabla.Rows.Count > 0 )
            {
                return (int)tabla.Rows[0][0];
            }
            else
            {
                return 0;
            }
            
        }
    }
}
