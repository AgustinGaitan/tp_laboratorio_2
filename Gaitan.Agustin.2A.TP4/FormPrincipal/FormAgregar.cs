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
            this.elemento = new ElementosGimnasio();

        }


        private void buttonAceptarFormAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                AccesoDatos ac = new AccesoDatos();
                if (!(this.comboBoxAgregarProductos.SelectedIndex == -1))
                {
                    if(!(this.comboBoxCaracteristicas.SelectedIndex == -1))
                    {
                        switch (this.comboBoxAgregarProductos.SelectedIndex)
                        {
                            case 0:
                                switch (this.comboBoxCaracteristicas.SelectedIndex)
                                {
                                    case 0:
                                        this.elemento = ac.ObtenerBarra(2);
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
                                        this.elemento = ac.ObtenerMancuerna(2);
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
                                        this.elemento = ac.ObtenerColchoneta(2);
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
                    this.Elemento.Precio = validado;
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void comboBoxAgregarProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
          


            if (this.comboBoxAgregarProductos.SelectedIndex == 0)
            {
                this.comboBoxCaracteristicas.Items.Clear();
                this.labelPrecio.Text = "0";
                this.comboBoxCaracteristicas.Items.AddRange(new object[] { "2 mts", "3 mts", "5 mts" });

            }
            else if (comboBoxAgregarProductos.SelectedIndex == 1)
            {
                this.comboBoxCaracteristicas.Items.Clear();
                this.labelPrecio.Text = "0";
                this.comboBoxCaracteristicas.Items.AddRange(new object[] { "2 kg", "5 kg", "10 kg" });
            }
            else
            {
                this.comboBoxCaracteristicas.Items.Clear();
                this.labelPrecio.Text = "0";
                this.comboBoxCaracteristicas.Items.AddRange(new object[] { "2 mts", "3 mts", "5 mts" });

            }
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
           
            this.Text = "Gaitan Agustin";
        }
    }
}
