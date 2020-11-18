using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Excepciones;

namespace FormPrincipal
{
    public partial class FormAgregar : Form
    {
        private ElementosGimnasio elemento;
      
        /// <summary>
        /// Propiedad de solo lectura que retorna el elemento de éste form
        /// </summary>
        public ElementosGimnasio Elemento
        {
            get
            {
                return this.elemento;
            }
        }

        /// <summary>
        /// Constructor por default. Inicializa el atributo.
        /// </summary>
        public FormAgregar()
        {
            InitializeComponent();
            this.elemento = new ElementosGimnasio();

        }

        /// <summary>
        /// Load. Cambia el nombre de la ventana y carga el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAgregar_Load(object sender, EventArgs e)
        {

            this.Text = "Agregar producto";
        }

        /// <summary>
        /// Agrega el producto a la grilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAceptarFormAgregar_Click(object sender, EventArgs e) //botón para agregar el prod
        {
            try
            {
                AccesoDatos ac = new AccesoDatos();
                if (!(this.comboBoxAgregarProductos.SelectedIndex == -1)) //Si el combobox del producto no tiene nada seleccionado lanza excepcion
                {
                    if(!(this.comboBoxCaracteristicas.SelectedIndex == -1)) //Si el combobox de la caracteristica no tiene nada seleccionado lanza exception
                    {
                        switch (this.comboBoxAgregarProductos.SelectedIndex)  //Depende del producto seleccionado...
                        {
                            case 0:
                                switch (this.comboBoxCaracteristicas.SelectedIndex)  //Depende de la caracteristica seleccionada...
                                {
                                    case 0: 
                                        this.elemento = ac.ObtenerBarra(2);          //Obtiene una barra    
                                        break;
                                    case 1:
                                        this.elemento = ac.ObtenerBarra(3);
                                        break;
                                    case 2:
                                        this.elemento = ac.ObtenerBarra(5);
                                        break;

                                }
                                break;
                            case 1:
                                switch (this.comboBoxCaracteristicas.SelectedIndex)
                                {
                                    case 0:
                                        this.elemento = ac.ObtenerMancuerna(2);        //Obtiene una mancuerna 
                                        break;
                                    case 1:
                                        this.elemento = ac.ObtenerMancuerna(5);
                                        break;
                                    case 2:
                                        this.elemento = ac.ObtenerMancuerna(10);
                                        break;

                                }
                                break;
                            case 2:
                                switch (this.comboBoxCaracteristicas.SelectedIndex)
                                {
                                    case 0:
                                        this.elemento = ac.ObtenerColchoneta(2);            //Obtiene una colchoneta
                                        break;
                                    case 1:
                                        this.elemento = ac.ObtenerColchoneta(3);
                                        break;
                                    case 2:
                                        this.elemento = ac.ObtenerColchoneta(5);
                                        break;

                                }
                                break;
                        }
                    }
                    else 
                    {
                        throw new CaracteristicaSinSeleccionarException();
                    }
                   
                }
                else
                {
                    throw new ProductoSinSeleccionarException();
                }

                int validado = 0;

                if (int.TryParse(this.labelPrecio.Text, out validado))
                {
                    this.Elemento.Precio = validado;             //Le agrega el label del precio al precio del elemento para luego
                                                                //pasarlo al otro form.
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        /// <summary>
        /// Combobox para agregar productos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAgregarProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
          


            if (this.comboBoxAgregarProductos.SelectedIndex == 0)   //Si el producto es barra...
            {
                this.comboBoxCaracteristicas.Items.Clear();
                this.labelPrecio.Text = "0";
                this.comboBoxCaracteristicas.Items.AddRange(new object[] { "2 mts", "3 mts", "5 mts" }); //Se le agregan estos parametros al combobox de caracteristica

            }
            else if (comboBoxAgregarProductos.SelectedIndex == 1)   //Si el producto es mancuerna...
            {
                this.comboBoxCaracteristicas.Items.Clear();
                this.labelPrecio.Text = "0";
                this.comboBoxCaracteristicas.Items.AddRange(new object[] { "2 kg", "5 kg", "10 kg" });//Se le agregan estos parametros al combobox de caracteristica
            }
            else                                                       //Si el producto es colchoneta...
            {
                this.comboBoxCaracteristicas.Items.Clear();
                this.labelPrecio.Text = "0";
                this.comboBoxCaracteristicas.Items.AddRange(new object[] { "2 mts", "3 mts", "5 mts" });//Se le agregan estos parametros al combobox de caracteristica

            }
        }       
           
        /// <summary>
        /// Combobox de caracteristicas. Depende de él se establece el label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxCaracteristicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxAgregarProductos.SelectedIndex == 0) //Depende de la caracteristica...
            {

                    if (this.comboBoxCaracteristicas.SelectedIndex == 0) //Se elige el precio del label.
                    {
                        this.labelPrecio.Text = "2000";
                    }
                    else if (this.comboBoxCaracteristicas.SelectedIndex == 1)
                    {
                        this.labelPrecio.Text = "4000";
                    }
                    else
                    {
                        this.labelPrecio.Text = "7500";
                    }

            }
            else if (this.comboBoxAgregarProductos.SelectedIndex == 1)
            {
                if (this.comboBoxCaracteristicas.SelectedIndex == 0)
                {
                    this.labelPrecio.Text = "1000";
                }
                else if (this.comboBoxCaracteristicas.SelectedIndex == 1)
                {
                    this.labelPrecio.Text = "2000";
                }
                else
                {
                    this.labelPrecio.Text = "5000";
                }

            }
            else
            {
                if (this.comboBoxCaracteristicas.SelectedIndex == 0)
                {
                    this.labelPrecio.Text = "1000";
                }
                else if (this.comboBoxCaracteristicas.SelectedIndex == 1)
                {
                    this.labelPrecio.Text = "3000";
                }
                else
                {
                    this.labelPrecio.Text = "5000";
                }

            }
        }

     
    }
}
