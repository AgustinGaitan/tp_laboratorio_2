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

        public AccesoDatos()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
        }

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
                    barra = new Barra(oDr.GetInt32(2));
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
                    mancuerna = new Mancuerna(oDr.GetInt32(2));
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

        public Colchoneta ObtenerColchoneta(int longitud)
        {


            Colchoneta colchoneta = default;

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;

                this.comando.Connection = this.conexion;

                this.comando.Parameters.AddWithValue("@longitud", longitud);
                this.comando.Parameters.AddWithValue("@colchoneta", "colchoneta");

                comando.CommandText = "SELECT * FROM [gimnasio].[dbo].[tablaproductos] WHERE producto = @colchoneta AND caracteristica = @longitud";

                this.conexion.Open();

                SqlDataReader oDr = comando.ExecuteReader();

                if (oDr.Read())
                {
                    colchoneta = new Colchoneta(oDr.GetInt32(2));
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

        
    }
}
