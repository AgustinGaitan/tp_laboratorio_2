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
        public ElementosGimnasio Elemento
        {
            get
            {
                return this.elemento;
            }
        }

        public Mostrar()
        {
            InitializeComponent();
        }

        public Mostrar(ElementosGimnasio eg) : this()
        {
            this.elemento = eg;

            this.labelDondeVaElProducto.Text = eg.Nombre;
            this.labelDondeVaCaracteristica.Text = eg.Caracteristica.ToString();
            this.labelDondeVaPrecio.Text = eg.Precio.ToString();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (this.elemento is Barra)
            {
                this.elemento = new Barra(int.Parse(this.labelDondeVaCaracteristica.Text));
            }
            else if (this.elemento is Mancuerna)
            {
                this.elemento = new Mancuerna(int.Parse(this.labelDondeVaCaracteristica.Text));
            }
            else
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
