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
        #region Atributos
        private Venta venta;
        private DataTable tabla;
        private DataTable tablaAerobico;
        private AccesoDatos objAcceso;
        protected Thread hilo;
        protected Thread otroHilo;
        protected string labelAtributo;
        private int acum;
        public delegate void Delegado(Label l);           //delegado para el label
        public delegate void DelegadoImagen(string path); //delegado para la imagen
        public event Delegado evento;                     //evento para el label
        public event DelegadoImagen eventoImagen;           //evento para la imagen
        public event DelegadoImagen eventoImagenAerobico;
        private Bitmap imagen;
        private Bitmap imagenAerobico;

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor por default
        /// </summary>
        public Principal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //El form se abre en el centro de la imagen
            this.evento += this.ReiniciarLabel;                 //Se le agrega al evento el manejador
            this.eventoImagen += this.CambiarImagen;            //Se le agrega al evento el manejador
            this.eventoImagenAerobico += this.CambiarImagenAerobico;


            this.objAcceso = new AccesoDatos();             
            this.venta = new Venta(30); //genera la venta principal con un limite de 30 objetos máximos.
           
         
            this.ConfigurarDT(); //configura la datatable.

         
        }
        #endregion

        #region Load

        /// <summary>
        /// Carga el fomrulario principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Gaitan Agustin 2A";    
            this.hilo = new Thread(this.EjecutarAccion);      //al hilo se le asocia la direccion de memoria del método EjecutarAccion
            if (!this.hilo.IsAlive) //Si el hilo está muerto, lo comienza.
                this.hilo.Start();

            this.otroHilo = new Thread(this.EjecutarAccionDos);      //al hilo se le asocia la direccion de memoria del método EjecutarAccion
            if (!this.otroHilo.IsAlive) //Si el hilo está muerto, lo comienza.
                this.otroHilo.Start();


        }

        #endregion

        #region Configurar DT
        /// <summary>
        /// Configura la data table
        /// </summary>
        public void ConfigurarDT()
        {
            this.tabla = new DataTable("Fuerza");
            this.tablaAerobico = new DataTable("Aerobico");

            
            this.tabla.Columns.Add("id", typeof(int)); //Añade la columna id
            //this.tabla.PrimaryKey = new DataColumn[] { this.tabla.Columns[0] };
            this.tabla.Columns.Add("producto", typeof(string));//Añade la columna producto
            this.tabla.Columns.Add("caracteristica", typeof(int));//Añade la columna caracteristica
            this.tabla.Columns.Add("precio", typeof(int));//Añade la columna precio
            this.tabla.Columns[0].AutoIncrement = true; //HAGO LA COLUMNA AUTOINCREMENTAL
            //this.tabla.Columns[0].AutoIncrementSeed = 1;
            //this.tabla.Columns[0].AutoIncrementStep = 1;

            
            this.tablaAerobico.Columns.Add("id", typeof(int)); //Añade la columna id
           // this.tablaAerobico.PrimaryKey = new DataColumn[] { this.tablaAerobico.Columns[0] };
            this.tablaAerobico.Columns.Add("producto", typeof(string));//Añade la columna producto
            this.tablaAerobico.Columns.Add("color", typeof(string));//Añade la columna color
            this.tablaAerobico.Columns.Add("precio", typeof(int));//Añade la columna precio
            this.tablaAerobico.Columns[0].AutoIncrement = true; //HAGO LA COLUMNA AUTOINCREMENTAL
            this.tablaAerobico.Columns[0].AutoIncrementSeed = 1;
            this.tablaAerobico.Columns[0].AutoIncrementStep = 7;


        }
        #endregion

        #region Botones
        /// <summary>
        /// Agrega un producto abriendo otro form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {

            FormAgregar formNuevo = new FormAgregar();     //Genera la instancia del otro form


            formNuevo.StartPosition = FormStartPosition.CenterScreen; // El form se abre en medio de la pantalla

            if (formNuevo.ShowDialog() == DialogResult.OK)                  //Si el dialogresult es OK...
            {
                DataRow fila = this.tabla.NewRow();    //Crea una nueva fila
                DataRow filaAerobico = this.tablaAerobico.NewRow();


                int validado = 0;

                if (int.TryParse(formNuevo.Elemento.Precio.ToString(), out validado)) //valida que el precio sea un número
                {
                    if (this.labelTotal.Text == "0")                //Si el label es 0, el acumulador de precio se resetea a 0.
                    {

                        acum = 0;
                    }
                    acum += validado;       //Si no es 0, se acumula el precio listo para sumarse y mostrar el total.
                    this.labelTotal.Text = acum.ToString(); //Se le asigna el total acumulado pasado a string
                }

                if (formNuevo.Elemento.Caracteristica == 0)
                {
                    filaAerobico["id"] = formNuevo.Elemento.Id;
                    filaAerobico["producto"] = formNuevo.Elemento.Nombre;
                    filaAerobico["color"] = formNuevo.Elemento.Color;
                    filaAerobico["precio"] = formNuevo.Elemento.Precio;

                    this.tablaAerobico.Rows.Add(filaAerobico);
                    this.datGridAerobico.DataSource = this.tablaAerobico;

                }
                else
                {
                    //Añade el elemento de la propiedad del otro form
                    fila["id"] = formNuevo.Elemento.Id;
                    fila["producto"] = formNuevo.Elemento.Nombre;
                    fila["caracteristica"] = formNuevo.Elemento.Caracteristica;
                    fila["precio"] = formNuevo.Elemento.Precio;
                    this.tabla.Rows.Add(fila); //Agrega la fila
                    this.dgvGrilla.DataSource = this.tabla;
                }


                datGridAerobico.ClearSelection();
                dgvGrilla.ClearSelection();


            }
        }

        /// <summary>
        /// Boton para eliminar un producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if(!(dgvGrilla.Rows.Count == 0))            //Si la grilla tiene filas...
                {
                    int indice = this.dgvGrilla.CurrentRow.Index;    //Obtiene el indice de la grilla seleccionad
                   

                    ElementosGimnasio el = new ElementosGimnasio(int.Parse(this.tabla.Rows[indice][0].ToString()),this.tabla.Rows[indice]["producto"].ToString(),
                        int.Parse(this.tabla.Rows[indice][2].ToString()),
                        int.Parse(this.tabla.Rows[indice][3].ToString()));    //Crea un nuevo elemento de gimnasio con la informacion del indice

                    

                    Eliminar frmMostrar = new Eliminar(el);    //Muestra un nuevo form

                    frmMostrar.StartPosition = FormStartPosition.CenterScreen; 

                    if (frmMostrar.ShowDialog() == DialogResult.OK) //Si el showdialog es OK
                    {
                        int restar = 0;
                        int total;

                        this.tabla.Rows[indice].Delete(); //Borra la fila
                        

                        //RESTA EL LABEL PARA ACTUALIZARLO//
                        restar = int.Parse(this.labelTotal.Text);
                        int precioARestar = el.Precio;
                        total = restar - precioARestar;
                        labelTotal.Text = total.ToString();

                    }

                }
                else
                {
                    throw new FilaVaciaException();
                }
               
            }
            catch(FilaVaciaException ex)
            {
                MessageBox.Show(ex.Informar(), "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error); //Se utiliza el método de extension
                
            }
            
            
        }

        private void buttonEliminarProductoAerobico_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(datGridAerobico.Rows.Count == 0))            //Si la grilla tiene filas...
                {
                    int indice = this.datGridAerobico.CurrentRow.Index;    //Obtiene el indice de la grilla seleccionad

                    ElementosGimnasio el = new ElementosGimnasio(int.Parse(this.tablaAerobico.Rows[indice][0].ToString()), this.tablaAerobico.Rows[indice]["producto"].ToString(),
                        this.tablaAerobico.Rows[indice]["color"].ToString(),
                        int.Parse(this.tablaAerobico.Rows[indice][3].ToString()));


                    Eliminar frmMostrar = new Eliminar(el);    //Muestra un nuevo form

                    frmMostrar.StartPosition = FormStartPosition.CenterScreen;

                    if (frmMostrar.ShowDialog() == DialogResult.OK) //Si el showdialog es OK
                    {
                        int restar = 0;
                        int total;

                        this.tablaAerobico.Rows[indice].Delete(); //Borra la fila


                        //RESTA EL LABEL PARA ACTUALIZARLO//
                        restar = int.Parse(this.labelTotal.Text);
                        int precioARestar = el.Precio;
                        total = restar - precioARestar;
                        labelTotal.Text = total.ToString();

                    }

                }
                else
                {
                    throw new FilaVaciaException();
                }

            }
            catch (FilaVaciaException ex)
            {
                MessageBox.Show(ex.Informar(), "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error); //Se utiliza el método de extension

            }

        }

      


        /// <summary>
        /// Boton para guardar la venta entera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGuardarVentaEntera_Click(object sender, EventArgs e)
        {
            try
            {
                List<ElementosGimnasio> listaE = new List<ElementosGimnasio>();

                if (!(dgvGrilla.Rows.Count == 0) || !(datGridAerobico.Rows.Count == 0)) //Si la grilla tiene filas...
                {
                    //this.dgvGrilla.SelectAll(); 

                        for(int i = 0; i < this.dgvGrilla.RowCount; i++)    //Recorro las filas para obtener la informacion de cada una
                        {
                           ElementosGimnasio el = new ElementosGimnasio(int.Parse(this.tabla.Rows[i][0].ToString()),this.tabla.Rows[i]["producto"].ToString(),
                            int.Parse(this.tabla.Rows[i][2].ToString()),
                            int.Parse(this.tabla.Rows[i][3].ToString()));
                            listaE.Add(el); //añado el elemento a la lista de elementos
                                                    
                        }
                        for (int i = 0; i < this.datGridAerobico.RowCount; i++)    //Recorro las filas para obtener la informacion de cada una
                        {
                           ElementosGimnasio el2 = new ElementosGimnasio(int.Parse(this.tablaAerobico.Rows[i][0].ToString()), this.tablaAerobico.Rows[i]["producto"].ToString(),
                          this.tablaAerobico.Rows[i]["color"].ToString(),
                          int.Parse(this.tablaAerobico.Rows[i][3].ToString()));
                                listaE.Add(el2); //añado el elemento a la lista de elementos

                        }

                    venta += listaE; //añado la lista a la venta

                    Venta.Guardar(venta); //guardo la lista en un .txt
                    MessageBox.Show("Venta guardada!");
                    venta -= listaE; //le saco la lista para no tener duplicados en un futuro.
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

        /// <summary>
        /// Boton para realizar la venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRealizarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(dgvGrilla.Rows.Count == 0) || !(datGridAerobico.Rows.Count == 0))
                {
                    this.tabla.Rows.Clear(); //limpia la tabla.
                    this.tablaAerobico.Rows.Clear();
                    acum = 0; // El acumulador que difiere sobre el label del total, se reinicia a 0
                    this.evento.Invoke(this.labelTotal); //invoco el evento del label para reiniciarlo.
                    MessageBox.Show("Venta realizada. Los productos le llegaran al cliente en 1 semana.", "ATENCION");
                }
                else
                {
                    throw new FilaVaciaException();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }               
        }

        /// <summary>
        /// Boton para leer la venta de un .txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLeerVenta_Click(object sender, EventArgs e)
        {
            try
            {
                FormListadoVentas ventaALeer = new FormListadoVentas();

                ventaALeer.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// Boton para guardar la venta en XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGuardarXML_Click(object sender, EventArgs e)
        {
            try
            {
                List<ElementosGimnasio> listaE = new List<ElementosGimnasio>();

                if (!(dgvGrilla.Rows.Count == 0) || !(datGridAerobico.Rows.Count == 0)) //Si la grilla tiene filas...
                {
                    //this.dgvGrilla.SelectAll(); 

                    for (int i = 0; i < this.dgvGrilla.RowCount; i++)    //Recorro las filas para obtener la informacion de cada una
                    {
                        ElementosGimnasio el = new ElementosGimnasio(int.Parse(this.tabla.Rows[i][0].ToString()), this.tabla.Rows[i]["producto"].ToString(),
                         int.Parse(this.tabla.Rows[i][2].ToString()),
                         int.Parse(this.tabla.Rows[i][3].ToString()));
                        listaE.Add(el); //añado el elemento a la lista de elementos

                    }
                    for (int i = 0; i < this.datGridAerobico.RowCount; i++)    //Recorro las filas para obtener la informacion de cada una
                    {
                        ElementosGimnasio el2 = new ElementosGimnasio(int.Parse(this.tablaAerobico.Rows[i][0].ToString()), this.tablaAerobico.Rows[i]["producto"].ToString(),
                       this.tablaAerobico.Rows[i]["color"].ToString(),
                       int.Parse(this.tablaAerobico.Rows[i][3].ToString()));
                        listaE.Add(el2); //añado el elemento a la lista de elementos

                    }
                }
                else
                {
                    throw new NoSePudoGuardarException();
                }

                venta += listaE; //Agrega la lista a la venta

                Venta.GuardarSer(venta); //Serializa la venta
                MessageBox.Show("Venta serializada!");
                venta -= listaE; //Le resta la venta para que no hayan duplicado
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region Metodos
        public void EjecutarAccion()
        {
            try
            {
                               
                do
                {

                    this.eventoImagen.Invoke(@"arriba.jpg");              //El evento se invoca a los eventos para cambiar la imagen
                    Thread.Sleep(2000);
                    this.eventoImagen.Invoke(@"abajo.jpg");                 
                    Thread.Sleep(2000);
                    this.eventoImagenAerobico.Invoke(@"colchoneta.jpg");
                    Thread.Sleep(2000);
                    this.eventoImagenAerobico.Invoke(@"bici.jpg");
                    Thread.Sleep(2000);

                } while (true);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void EjecutarAccionDos()
        {
            try
            {

                do
                {           
                    this.eventoImagenAerobico.Invoke(@"colchoneta.jpg");
                    Thread.Sleep(2000);
                    this.eventoImagenAerobico.Invoke(@"bici.jpg");
                    Thread.Sleep(2000);

                } while (true);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Metodo que reinicia el label a 0
        /// </summary>
        /// <param name="l"></param>
        public void ReiniciarLabel(Label l)
        {
            l.Text = "0";
        }
       
        /// <summary>
        /// Metodo que cambia la imagen
        /// </summary>
        /// <param name="path">path de la imagen</param>
        public void CambiarImagen(string path)
        {
            this.imagen = new Bitmap(path); //Genera un bitmap con el path de la imagen

            imagenPictureBox.Image = (Image)this.imagen;   //le pasa la imagen casteada a Image
        }

        public void CambiarImagenAerobico(string path)
        {
            this.imagenAerobico = new Bitmap(path); //Genera un bitmap con el path de la imagen

            pictureBoxAerobico.Image = (Image)this.imagenAerobico;   //le pasa la imagen casteada a Image
        }


        #endregion

        #region Closing

        /// <summary>
        /// Form closing que se lanza cuando se cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Principal_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    if (this.hilo.IsAlive && this.otroHilo.IsAlive)       //Si el hilo esta vivo
                    {

                        this.hilo.Abort();      //Lo aborta
                        this.otroHilo.Abort();

                    }


                }
                catch (ThreadAbortException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion
    }
}

