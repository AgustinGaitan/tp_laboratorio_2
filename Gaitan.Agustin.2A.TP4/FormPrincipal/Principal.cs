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
using System.Threading;

namespace FormPrincipal
{
    public partial class Principal : Form
    {
        private Venta venta;
        private DataTable tabla;
        private AccesoDatos objAcceso;
        protected Thread hilo;
        protected string labelAtributo;
        private int acum;
        public delegate void DelegadoThread();
        //public event DelegadoThread EventoActualizar;

       
        public Principal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //DelegadoThread delegado = new DelegadoThread(EjecutarAccion);
            this.hilo = new Thread(this.EjecutarAccion);

            this.objAcceso = new AccesoDatos();
            this.venta = new Venta(10);
           
         
            this.ConfigurarDT();

         
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Gaitan Agustin";

            if (!this.hilo.IsAlive)
                this.hilo.Start();

        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            FormAgregar formNuevo = new FormAgregar();
            

            formNuevo.StartPosition = FormStartPosition.CenterScreen;

            if (formNuevo.ShowDialog() == DialogResult.OK)
            {
                DataRow fila = this.tabla.NewRow();
                

                fila["id"] = formNuevo.Elemento.Id;
                fila["producto"] = formNuevo.Elemento.Nombre;
                fila["caracteristica"] = formNuevo.Elemento.Caracteristica;
                fila["precio"] = formNuevo.Elemento.Precio;

                int validado = 0;

                if(int.TryParse(formNuevo.Elemento.Precio.ToString(), out validado))
                {
                    acum += validado;
                    this.labelTotal.Text = acum.ToString();
                }
               


                this.tabla.Rows.Add(fila);
                this.dgvGrilla.DataSource = this.tabla;
            }
        }

         
            public void ConfigurarDT()
            {
                this.tabla = new DataTable("gimnasio");

                this.tabla.Columns.Add("id", typeof(int));


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

                    ElementosGimnasio el = new ElementosGimnasio(int.Parse(this.tabla.Rows[indice][0].ToString()),this.tabla.Rows[indice]["producto"].ToString(),
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

                    ElementosGimnasio el = new ElementosGimnasio(int.Parse(this.tabla.Rows[indice][0].ToString()),this.tabla.Rows[indice]["producto"].ToString(),
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


        private void buttonGuardarVentaEntera_Click(object sender, EventArgs e)
        {
            try
            {
                List<ElementosGimnasio> listaE = new List<ElementosGimnasio>();

                if (!(dgvGrilla.Rows.Count == 0))
                {
                    this.dgvGrilla.SelectAll();

                        for(int i = 0; i < this.dgvGrilla.RowCount; i++)
                        {
                           ElementosGimnasio el = new ElementosGimnasio(int.Parse(this.tabla.Rows[i][0].ToString()),this.tabla.Rows[i]["producto"].ToString(),
                            int.Parse(this.tabla.Rows[i][2].ToString()),
                            int.Parse(this.tabla.Rows[i][3].ToString()));
                            listaE.Add(el);
                                                    
                        }

                    venta += listaE;

                    Venta.Guardar(venta);
                    venta -= listaE;
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

        private void buttonRealizarVenta_Click(object sender, EventArgs e)
        {
            this.tabla.Rows.Clear();
            MessageBox.Show("Venta realizada. Los productos le llegaran al cliente en 1 semana.", "ATENCION");
        }

        private void Principal_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                if (this.hilo.IsAlive)
                {
                    this.hilo.Abort();
                }
            }
        }

        private void buttonGuardarXML_Click(object sender, EventArgs e)
        {
            try
            {
                List<ElementosGimnasio> listaE = new List<ElementosGimnasio>();

                if (!(dgvGrilla.Rows.Count == 0))
                {
                    this.dgvGrilla.SelectAll();

                    for (int i = 0; i < this.dgvGrilla.RowCount; i++)
                    {
                        ElementosGimnasio el = new ElementosGimnasio(int.Parse(this.tabla.Rows[i][0].ToString()),
                            this.tabla.Rows[i]["producto"].ToString(),
                         int.Parse(this.tabla.Rows[i][2].ToString()),
                         int.Parse(this.tabla.Rows[i][3].ToString()));
                        listaE.Add(el);

                    }

                    venta += listaE;

                    Venta.GuardarSer(venta);
                    venta -= listaE;
                }
                else
                {
                    throw new NoSePudoGuardarException();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EjecutarAccion()
        {
            try
            {
                
                Thread.Sleep(2000);
                //do
                //{
                    if (this.imagenPictureBox.InvokeRequired)
                    {
                        
                        this.imagenPictureBox.BeginInvoke((MethodInvoker)delegate ()
                        {

                            this.imagenPictureBox.ImageLocation = @"\arriba.jpg";



                            ////this.Invoke(delegado);

                            Thread.Sleep(2000);


                            this.imagenPictureBox.ImageLocation = @"\abajo.jpg";

                        });

                    }

               // } while (true);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

       
    }
}

