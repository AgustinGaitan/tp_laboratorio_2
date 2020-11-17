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
        //private SqlConnection conexion;
        //private SqlCommand comando;

        //public AccesoDatos()
        //{
        //    this.conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
        //}

        //public List<Venta> ObtenerBarra()
        //{


        //    List<Venta> listaVentas = new List<Venta>();

        //    try
        //    {
        //        this.comando = new SqlCommand();

        //        this.comando.CommandType = CommandType.Text;

        //        this.comando.Connection = this.conexion;

        //        comando.CommandText = "SELECT * FROM tproduc WHERE producto = barra";

        //        this.conexion.Open();

        //        SqlDataReader oDr = comando.ExecuteReader();


        //        listaVentas.Add(new Barra(oDr.GetInt32(2)));

        //        oDr.Close();
        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //    }
        //    finally
        //    {
        //        if (this.conexion.State == ConnectionState.Open)
        //        {
        //            this.conexion.Close();
        //        }
        //    }

        //    return listaVentas;
        //}

        //public List<Venta> ObtenerMancuerna()
        //{


        //    List<Venta> listaVentas = new List<Venta>();

        //    try
        //    {
        //        this.comando = new SqlCommand();

        //        this.comando.CommandType = CommandType.Text;

        //        this.comando.Connection = this.conexion;

        //        comando.CommandText = "SELECT * FROM tproduc WHERE producto = mancuerna";

        //        this.conexion.Open();

        //        SqlDataReader oDr = comando.ExecuteReader();


        //        listaVentas.Add(new Mancuerna(oDr.GetInt32(2)));

        //        oDr.Close();
        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //    }
        //    finally
        //    {
        //        if (this.conexion.State == ConnectionState.Open)
        //        {
        //            this.conexion.Close();
        //        }
        //    }

        //    return listaVentas;
        //}

        //public List<Venta> ObtenerColchoneta()
        //{


        //    List<Venta> listaVentas = new List<Venta>();

        //    try
        //    {
        //        this.comando = new SqlCommand();

        //        this.comando.CommandType = CommandType.Text;

        //        this.comando.Connection = this.conexion;

        //        comando.CommandText = "SELECT * FROM tproduc WHERE producto = colchoneta";

        //        this.conexion.Open();

        //        SqlDataReader oDr = comando.ExecuteReader();


        //        listaVentas.Add(new Colchoneta(oDr.GetString(3)));

        //        oDr.Close();
        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //    }
        //    finally
        //    {
        //        if (this.conexion.State == ConnectionState.Open)
        //        {
        //            this.conexion.Close();
        //        }
        //    }

        //    return listaVentas;
        //}

        //public DataTable ObtenerTablaVentas()
        //{
        //    DataTable tabla = new DataTable("Ventas");

        //    try
        //    {
        //        this.comando = new SqlCommand();

        //        this.comando.CommandType = CommandType.Text;

        //        this.comando.Connection = this.conexion;

        //        this.comando.CommandText = "SELECT * FROM tproduc ORDER BY id DESC";

        //        this.conexion.Open();

        //        SqlDataReader oDr = this.comando.ExecuteReader();

        //        tabla.Load(oDr);

        //        oDr.Close();
        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //    }
        //    finally
        //    {
        //        if (this.conexion.State == ConnectionState.Open)
        //        {
        //            this.conexion.Close();
        //        }
        //    }

        //    return tabla;
        //}
    }
}
