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
    public partial class Mostrar : Form
    {
        protected ElementosGimnasio elemento;

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
        public Mostrar()
        {
            InitializeComponent();
            this.Text = "Eliminar producto";
        }

        /// <summary>
        /// Constructor al que se le pasa un elemento del gimnasio
        /// </summary>
        /// <param name="eg"></param>
        public Mostrar(ElementosGimnasio eg) : this()
        {
            this.elemento = eg;

            this.labelDondeVaElProducto.Text = eg.Nombre;
            this.labelDondeVaCaracteristica.Text = eg.Caracteristica.ToString();
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
            else                                     //Si el elemento es una colchoneta, agrega una nueva colchoneta
            {
                this.elemento = new Colchoneta(int.Parse(this.labelDondeVaCaracteristica.Text));
            }

            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
