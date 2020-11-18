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
    public partial class FormAgregar : Form
    {
        private Venta ventas;
        private ElementosGimnasio elemento;


        public ElementosGimnasio Elemento
        {
            get
            {
                return this.elemento;
            }
        }

        public FormAgregar()
        {
            InitializeComponent();
            

        }
  

        private void buttonAceptarFormAgregar_Click(object sender, EventArgs e)
        {
            AccesoDatos ac = new AccesoDatos();
            


            if (comboBoxAgregarProductos.SelectedIndex == 0)
            {
                if(this.comboBoxCaracteristicas.SelectedIndex == 0)
                {
                    this.elemento = ac.ObtenerBarra(2);
                  
                }
                else if (this.comboBoxCaracteristicas.SelectedIndex == 1)
                {
                    this.elemento = ac.ObtenerBarra(3);
                }
                else
                {
                    this.elemento = ac.ObtenerBarra(5);
                }
            }
            else if (this.comboBoxAgregarProductos.SelectedIndex == 1)
            {
                if (this.comboBoxCaracteristicas.SelectedIndex == 0)
                {
                    this.elemento = ac.ObtenerMancuerna(2);
                }
                else if (this.comboBoxCaracteristicas.SelectedIndex == 1)
                {
                    this.elemento = ac.ObtenerMancuerna(5);
                }
                else
                {
                    this.elemento = ac.ObtenerMancuerna(10);
                }
            }
            else
            {
                if (this.comboBoxCaracteristicas.SelectedIndex == 0)
                {
                    this.elemento = ac.ObtenerColchoneta(2);
                }
                else if (this.comboBoxCaracteristicas.SelectedIndex == 1)
                {
                    this.elemento = ac.ObtenerColchoneta(5);
                }
                else
                {
                    this.elemento = ac.ObtenerColchoneta(10);
                }

            }

            int validado = 0;

            if(int.TryParse(this.labelPrecio.Text, out validado))
            {
                this.Elemento.Precio = validado;
            }
            
            this.DialogResult = DialogResult.OK;
        }

    
        private void comboBoxAgregarProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxAgregarProductos.SelectedIndex == 0)
            {
                this.comboBoxCaracteristicas.Items.Clear();
                this.labelPrecio.Text = "0";
                this.comboBoxCaracteristicas.Items.AddRange(new object[] { "2", "3", "5" });
               
            }
            else if (comboBoxAgregarProductos.SelectedIndex == 1)
            {
                this.comboBoxCaracteristicas.Items.Clear();
                this.labelPrecio.Text = "0";
                this.comboBoxCaracteristicas.Items.AddRange(new object[] { "2", "5", "10" });
            }
            else
            {
                this.comboBoxCaracteristicas.Items.Clear();
                this.labelPrecio.Text = "0";
                this.comboBoxCaracteristicas.Items.AddRange(new object[] { "2", "3", "10" });

            }
        }

        private void labelPrecio_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCaracteristicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxAgregarProductos.SelectedIndex == 0)
            {

                    if (this.comboBoxCaracteristicas.SelectedIndex == 0)
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

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            this.elemento = new ElementosGimnasio();
        }
    }
}
