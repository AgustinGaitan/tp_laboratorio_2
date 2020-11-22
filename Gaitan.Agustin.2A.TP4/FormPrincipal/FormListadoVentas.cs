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
using Archivos;

namespace FormPrincipal
{
    public partial class FormListadoVentas : Form
    {
        public FormListadoVentas()
        {
            InitializeComponent();
            richTextBox.Text = Venta.Leer();
        }

     
    }
}
