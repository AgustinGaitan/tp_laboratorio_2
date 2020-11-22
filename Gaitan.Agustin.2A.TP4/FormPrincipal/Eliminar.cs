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

namespace FormPrincipal
{
    public partial class Eliminar : Form
    {
        private ElementosGimnasio elemento;

        /// <summary>
        /// Propiedad de solo lectura que retorna el elemento
        /// del form
        /// </summary>
        public ElementosGimnasio Elemento
        {
            get
            {
                return this.elemento;
            }
        }

        /// <summary>
        /// Constructor por default que inicializa el componente y cambia
        /// el nombre de la ventana
        /// </summary>
        public Eliminar()
        {
            InitializeComponent();
            this.Text = "Eliminar producto";
        }

        /// <summary>
        /// Constructor al que se le pasa un elemento del gimnasio
        /// </summary>
        /// <param name="eg"></param>
        public Eliminar(ElementosGimnasio eg) : this()
        {

            this.labelDondeVaCaracteristica.Visible = true;
            this.labelColor.Visible = true;

            this.labelDondeVaElProducto.Text = eg.Nombre;

           if(eg.Caracteristica == 0)
            {
                this.labelDondeVaCaracteristica.Visible = false;
                this.labelColor.Text = eg.Color;
            }
           else
            {
                this.labelColor.Visible = false;
                this.labelDondeVaCaracteristica.Text = eg.Caracteristica.ToString();
            }
                
    
                
               
            

            this.labelDondeVaPrecio.Text = eg.Precio.ToString();
        }

        /// <summary>
        /// Boton para aceptar los cambios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (this.elemento is Barra)     //Si el elemento es barra agrega una nueva barra
            {
                this.elemento = new Barra(int.Parse(this.labelDondeVaCaracteristica.Text));
            }
            else if (this.elemento is Mancuerna)    //Si el elemento es mancuerna agrega una nueva mancuerna
            {
                this.elemento = new Mancuerna(int.Parse(this.labelDondeVaCaracteristica.Text));
            }
            else if(this.elemento is Colchoneta)                                 //Si el elemento es una colchoneta, agrega una nueva colchoneta
            {
                this.elemento = new Colchoneta(this.labelDondeVaCaracteristica.Text);
            }
            else
            {
                this.elemento = new Bici(this.labelDondeVaCaracteristica.Text);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
