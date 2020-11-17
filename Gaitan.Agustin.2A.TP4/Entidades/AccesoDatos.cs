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

        public List<Venta> ObtenerBarra()
        {

            Barra barraRetorno;
            List<Venta> listaVentas = new List<Venta>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;

                this.comando.Connection = this.conexion;

                comando.CommandText = "SELECT * FROM tproduc WHERE producto = barra";

                this.conexion.Open();

                SqlDataReader oDr = comando.ExecuteReader();

                barraRetorno = new Barra(oDr.GetInt32(1));
                listaVentas.Add(barraRetorno);

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

            return listaVentas;
        }

    }
}
