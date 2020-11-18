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
using Excepciones;
using Archivos;

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
            this.venta = new Venta(10);
            

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

                fila["producto"] = formNuevo.Elemento.Nombre;
                fila["caracteristica"] = formNuevo.Elemento.Caracteristica;
                fila["precio"] = formNuevo.Elemento.Precio;

                


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
            try
            {
                if(!(dgvGrilla.Rows.Count == 0))
                {
                    int indice = this.dgvGrilla.CurrentRow.Index;

                    ElementosGimnasio el = new ElementosGimnasio(this.tabla.Rows[indice]["producto"].ToString(),
                        int.Parse(this.tabla.Rows[indice][2].ToString()),
                        int.Parse(this.tabla.Rows[indice][3].ToString()));



                    Mostrar frmMostrar = new Mostrar(el);

                    frmMostrar.StartPosition = FormStartPosition.CenterScreen;

                    if (frmMostrar.ShowDialog() == DialogResult.OK)
                    {
                        this.tabla.Rows[indice].Delete();
                    }

                }
                else
                {
                    throw new FilaVaciaException();
                }
               
            }
            catch(FilaVaciaException ex)
            {
                MessageBox.Show(ex.Informar(), "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
            
        }

        private void buttonGuardarVentaTXT_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(dgvGrilla.Rows.Count == 0))
                {
                    int indice = this.dgvGrilla.CurrentRow.Index;

                    ElementosGimnasio el = new ElementosGimnasio(this.tabla.Rows[indice]["producto"].ToString(),
                        int.Parse(this.tabla.Rows[indice][2].ToString()),
                        int.Parse(this.tabla.Rows[indice][3].ToString()));


                    ElementosGimnasio.Guardar(el);
                }
                else
                {
                    throw new NoSePudoGuardarException();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void buttonAceptarCambios_Click(object sender, EventArgs e)
        {
            this.tabla.AcceptChanges();
          
        }

        private void buttonGuardarVentaEntera_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(dgvGrilla.Rows.Count == 0))
                {
                    this.dgvGrilla.SelectAll();

                        for(int i = 0; i < this.dgvGrilla.RowCount; i++)
                        {
                            ElementosGimnasio el = new ElementosGimnasio(this.tabla.Rows[i]["producto"].ToString(),
                            int.Parse(this.tabla.Rows[i][2].ToString()),
                            int.Parse(this.tabla.Rows[i][3].ToString()));
                            venta += el;
                            if(i == this.dgvGrilla.RowCount -1)
                            {
                                Venta.Guardar(venta);
                                venta -= el;
                            }
                        }
                    
                    

                    
                    
                }
                else
                {
                    throw new NoSePudoGuardarException();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATENCION" ,MessageBoxButtons.OK, MessageBoxIcon.Error) ; 
            }
        }

 

        private void Principal_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
