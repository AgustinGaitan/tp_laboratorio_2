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

        public FormAgregar()
        {
            InitializeComponent();

        }

        public FormAgregar(Venta venta) : this()
        {
            this.ventas = venta;
        }

     

        private void buttonAceptarFormAgregar_Click(object sender, EventArgs e)
        {
            //this.comboBoxAgregarProductos.SelectedValue;
            //this.comboBoxCaracteristicas.SelectedValue;

            this.DialogResult = DialogResult.OK;
        }

    
        private void comboBoxAgregarProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAgregarProductos.SelectedIndex == 0)
            {
                comboBoxCaracteristicas.Items.Clear();
                comboBoxCaracteristicas.Items.AddRange(new object[] { "2", "3", "5" });
                this.Controls.Add(comboBoxCaracteristicas);

            }
            else if (comboBoxAgregarProductos.SelectedIndex == 1)
            {
                comboBoxCaracteristicas.Items.Clear();
                comboBoxCaracteristicas.Items.AddRange(new object[] { "2", "5", "10" });
            }
            else
            {
                comboBoxCaracteristicas.Items.Clear();
                comboBoxCaracteristicas.Items.AddRange(new object[] { "azul", "rojo", "verde" });

            }
        }
    }
}
