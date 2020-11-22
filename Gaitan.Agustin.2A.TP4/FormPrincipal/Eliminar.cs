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
        #region Constructores
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
        #endregion

        #region Botones
        /// <summary>
        /// Boton para aceptar los cambios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAceptar_Click(object sender, EventArgs e)
        { 
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        #endregion
    }
}
