using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormPrincipal
{
    public partial class Principal : Form
    {
        private Venta venta;
        private DataTable tabla;
        private AccesoDatos objAcceso;

        public Principal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.objAcceso = new AccesoDatos();
            this.venta = new Venta(5, 5, 5);

            ////this.ConfigurarDA();
            this.ConfigurarDT();

            //this.tabla = this.objAcceso.ObtenerTablaVentas();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Gaitan Agustin";

        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            FormAgregar formNuevo = new FormAgregar();

            formNuevo.StartPosition = FormStartPosition.CenterScreen;

            if (formNuevo.ShowDialog() == DialogResult.OK)
            {
                DataRow fila = this.tabla.NewRow();

                fila["producto"] = formNuevo.Elemento.GetType().Name;
                fila["caracteristica"] = formNuevo.Elemento.Caracteristica;
                fila["precio"] = formNuevo.Elemento.Precio;

                this.venta.ListaTotal.Add(formNuevo.Elemento);
                if(formNuevo.Elemento is Barra)
                {
                    venta.ListaBarras.Add((Barra)formNuevo.Elemento);
                }
                else if (formNuevo.Elemento is Mancuerna)
                {
                    venta.ListaMancuernas.Add((Mancuerna)formNuevo.Elemento);
                }
                if (formNuevo.Elemento is Colchoneta)
                {
                    venta.ListaColchonetas.Add((Colchoneta)formNuevo.Elemento);
                }


                this.tabla.Rows.Add(fila);
                this.dgvGrilla.DataSource = this.tabla;
            }
        }

            //public bool ConfigurarDA()
            //{
            //    bool todoOk = true;

            //    this.data = new SqlDataAdapter();
            //    try
            //    {
            //        this.conexion = new SqlConnection(Properties.Settings.Default.conexionBD);

            //        this.data.SelectCommand = new SqlCommand("SELECT * FROM [gimnasio].[dbo].[tablaproductos] ", this.conexion);

            //    }
            //    catch (Exception e)
            //    {
            //        MessageBox.Show(e.Message);
            //        todoOk = false;
            //    }

            //    return todoOk;
            //}

            public void ConfigurarDT()
            {
                this.tabla = new DataTable("gimnasio");

                this.tabla.Columns.Add("id", typeof(int));

                this.tabla.PrimaryKey = new DataColumn[] { this.tabla.Columns[0] };

                this.tabla.Columns[0].AutoIncrement = true;
                this.tabla.Columns[0].AutoIncrementSeed = 1;
                this.tabla.Columns[0].AutoIncrementStep = 1;

                this.tabla.Columns.Add("producto", typeof(string));
                this.tabla.Columns.Add("caracteristica", typeof(int));
                this.tabla.Columns.Add("precio", typeof(int));


            }

        private void buttonEliminarProducto_Click(object sender, EventArgs e)
        {
            int i = this.dgvGrilla.SelectedRows[0].Index;

            //DataRow fila = this.tabla.Rows[i];

            object[] objeto = this.tabla.Rows[i].ItemArray;  //obtiene la fila a punto de ser eliminada, para tambien eliminarla de la venta.
            this.venta.ListaBarras.Remove(new Barra((int)objeto[2]));



         
            this.tabla.Rows[i].Delete();
            this.tabla.AcceptChanges();
        }

        private void buttonGuardarVentaTXT_Click(object sender, EventArgs e)
        {
            Venta.Guardar(this.venta);
        }
    }
}
