using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;

        /// <summary>
        /// Constructor por default que establece la conexion
        /// </summary>
        public AccesoDatos()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
        }

        /// <summary>
        /// Obtiene un elemento de la base de datos mediante el ID
        /// </summary>
        /// <param name="id">id a buscar</param>
        /// <returns></returns>
        public ElementosGimnasio ObtenerElemento(int id)
        {


            ElementosGimnasio elemento = default;

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;

                this.comando.Connection = this.conexion;
                this.comando.Parameters.AddWithValue("@id", id);
                SqlDataReader oDr;
                this.conexion.Open();
                
                

                if (id > 0 && id <= 6)
                {
                    this.comando.CommandText = "SELECT * FROM [gimnasio].[dbo].[tablaproductos] WHERE id  = @id";
                     oDr = comando.ExecuteReader();
                    if (oDr.Read())
                    {
                        elemento = new ElementosGimnasio(oDr.GetInt32(0), oDr.GetString(1), oDr.GetInt32(2),oDr.GetInt32(3));
                    }
                }
                else
                {
                    this.comando.CommandText = "SELECT * FROM [gimnasio].[dbo].[tablaaerobico] WHERE id  = @id";
                     oDr = comando.ExecuteReader();
                    if (oDr.Read())
                    {
                        elemento = new ElementosGimnasio(oDr.GetInt32(0), oDr.GetString(1), oDr.GetString(2), oDr.GetInt32(3));
                    }

                }
          

                oDr.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
                 
            }

            return  elemento;
        }
    }
}
