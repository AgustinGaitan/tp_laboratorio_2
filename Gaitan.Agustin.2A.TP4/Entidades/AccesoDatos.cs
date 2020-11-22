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
        /// Metodo para obtener la barra
        /// </summary>
        /// <param name="longitud"></param>
        /// <returns>La barra obtenida de la base de datos</returns>
        public Barra ObtenerBarra(int longitud)
        {


            Barra barra = default;

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;

                this.comando.Connection = this.conexion;
                this.comando.Parameters.AddWithValue("@longitud", longitud);
                this.comando.Parameters.AddWithValue("@barra", "barra");
                comando.CommandText = "SELECT * FROM [gimnasio].[dbo].[tablaproductos] WHERE producto = @barra AND caracteristica = @longitud";

                this.conexion.Open();

                SqlDataReader oDr = comando.ExecuteReader();

                if(oDr.Read())
                {
                    barra = new Barra(oDr.GetInt32(0), oDr.GetInt32(2));
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

            return barra;
        }

        /// <summary>
        /// Metodo para obtener una mancuerna
        /// de la base de datos
        /// </summary>
        /// <param name="peso">Peso de la mancuerna</param>
        /// <returns>La mancuerna obtenida de la base de datos</returns>
        public Mancuerna ObtenerMancuerna(int peso)
        {
            Mancuerna mancuerna = default;

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;

                this.comando.Connection = this.conexion;

                this.comando.Parameters.AddWithValue("@peso", peso);
                this.comando.Parameters.AddWithValue("@mancuerna", "mancuerna");

                comando.CommandText = "SELECT * FROM [gimnasio].[dbo].[tablaproductos] WHERE producto = @mancuerna AND caracteristica = @peso";

                this.conexion.Open();

                SqlDataReader oDr = comando.ExecuteReader();

                if (oDr.Read())
                {
                    mancuerna = new Mancuerna(oDr.GetInt32(0), oDr.GetInt32(2));
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

            return mancuerna;
        }

        /// <summary>
        /// Metodo para obtener una colchoneta
        /// </summary>
        /// <param name="longitud">longitud de la colchoneta</param>
        /// <returns>Colchoneta obtenida de la base de datos</returns>
        public Colchoneta ObtenerColchoneta(string color)
        {


            Colchoneta colchoneta = default;

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;

                this.comando.Connection = this.conexion;

                this.comando.Parameters.AddWithValue("@color", color);
                this.comando.Parameters.AddWithValue("@colchoneta", "colchoneta");

                comando.CommandText = "SELECT * FROM [gimnasio].[dbo].[tablaaerobico] WHERE producto = @colchoneta AND color = @color";

                this.conexion.Open();

                SqlDataReader oDr = comando.ExecuteReader();

                if (oDr.Read())
                {
                    colchoneta = new Colchoneta(oDr.GetInt32(0), oDr.GetString(1), oDr.GetString(2), oDr.GetInt32(3));
                    
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

            return colchoneta;
        }

        public Bici ObtenerBici(string color)
        {


            Bici bici = default;

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;

                this.comando.Connection = this.conexion;

                this.comando.Parameters.AddWithValue("@color", color);
                this.comando.Parameters.AddWithValue("@bici", "bici");

                comando.CommandText = "SELECT * FROM [gimnasio].[dbo].[tablaaerobico] WHERE producto = @bici AND color = @color";

                this.conexion.Open();

                SqlDataReader oDr = comando.ExecuteReader();

                if (oDr.Read())
                {
                    bici = new Bici(oDr.GetInt32(0), oDr.GetString(1), oDr.GetString(2), oDr.GetInt32(3));

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

            return bici;
        }


    }
}
