using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    //Esta es la clase Acceso Datos, es una clase hecha para realizar cualquier tipo de conexión contra una base de datos.
    //Una consulta, un update, un delete, etc.
    //Tiene varias funciones para cada necesidad en especifico .
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return Lector; }
        }

        //Conexion a la base de datos
        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true");
            comando = new SqlCommand();
        }

        //Esta función establece una consulta recibida por parametro
        public void setQuery(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        //Esta función intenta ejecutar el lector para la consulta previamente hecha
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
        //Esta funcion intenta ejecutar una accion que no sea una conuslta (un NonQuery)
        public void ejectuarAccion()
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
        //Esta función esta hecha para etablecer valores por parametro a la hora de reemplazar datos.
        //Primero recibe el nombre de la variable/dato y luego el valor que se le quiere asignar
        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        } 
        //Esta función cierra la conexión. Tambien valida que el lector este leyendo
        public void cerrarConexion()
        {
            if (lector != null)
            {
                lector.Close();
            }
            conexion.Close();
        }
    }
}
