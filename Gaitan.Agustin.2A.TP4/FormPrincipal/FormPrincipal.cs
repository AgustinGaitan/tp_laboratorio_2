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
    public partial class FormPrincipal : Form
    {
        private List<Venta> ventas;
        private DataTable tabla;
        private AccesoDatos objAcceso;

        public FormPrincipal()
        {
            InitializeComponent();

            this.objAcceso = new AccesoDatos();
            this.tabla = this.objAcceso.ObtenerTablaVentas();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.dgvGrilla.DataSource = this.tabla;
        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            FormAgregar formNuevo = new FormAgregar();

            formNuevo.StartPosition = FormStartPosition.CenterScreen;

            formNuevo.ShowDialog();
        }
    }
}
