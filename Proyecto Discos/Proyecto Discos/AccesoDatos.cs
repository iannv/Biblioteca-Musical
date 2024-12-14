using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Discos
{
    internal class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector { get { return lector; } }

        // Método para acceder a la BD con la conexión y la query
        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true");
            comando = new SqlCommand();
        }


        // Método para setear la query
        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }


        // Método para leer de la BD
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // Método para guardar en la BD
        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // Método para acceder a los parámetros
        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }


        // Método para cerrar la conexión
        public void cerrarConexion()
        {
            if(lector != null)
                lector.Close();
            conexion.Close();
        }


    }
}
