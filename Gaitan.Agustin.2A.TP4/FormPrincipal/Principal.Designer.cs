using System.Drawing;
using System.Windows.Forms;

namespace FormPrincipal
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.buttonAgregarProducto = new System.Windows.Forms.Button();
            this.buttonEliminarProducto = new System.Windows.Forms.Button();
            this.buttonRealizarVenta = new System.Windows.Forms.Button();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.buttonGuardarVentaTXT = new System.Windows.Forms.Button();
            this.buttonGuardarVentaEntera = new System.Windows.Forms.Button();
            this.buttonGuardarXML = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.imagenPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAgregarProducto
            // 
            this.buttonAgregarProducto.Location = new System.Drawing.Point(30, 396);
            this.buttonAgregarProducto.Name = "buttonAgregarProducto";
            this.buttonAgregarProducto.Size = new System.Drawing.Size(120, 32);
            this.buttonAgregarProducto.TabIndex = 1;
            this.buttonAgregarProducto.Text = "Agregar producto";
            this.buttonAgregarProducto.UseVisualStyleBackColor = true;
            this.buttonAgregarProducto.Click += new System.EventHandler(this.buttonAgregarProducto_Click);
            // 
            // buttonEliminarProducto
            // 
            this.buttonEliminarProducto.Location = new System.Drawing.Point(30, 444);
            this.buttonEliminarProducto.Name = "buttonEliminarProducto";
            this.buttonEliminarProducto.Size = new System.Drawing.Size(120, 34);
            this.buttonEliminarProducto.TabIndex = 3;
            this.buttonEliminarProducto.Text = "Eliminar producto";
            this.buttonEliminarProducto.UseVisualStyleBackColor = true;
            this.buttonEliminarProducto.Click += new System.EventHandler(this.buttonEliminarProducto_Click);
            // 
            // buttonRealizarVenta
            // 
            this.buttonRealizarVenta.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonRealizarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRealizarVenta.Location = new System.Drawing.Point(231, 494);
            this.buttonRealizarVenta.Name = "buttonRealizarVenta";
            this.buttonRealizarVenta.Size = new System.Drawing.Size(120, 62);
            this.buttonRealizarVenta.TabIndex = 4;
            this.buttonRealizarVenta.Text = "Realizar venta";
            this.buttonRealizarVenta.UseVisualStyleBackColor = false;
            this.buttonRealizarVenta.Click += new System.EventHandler(this.buttonRealizarVenta_Click);
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToResizeColumns = false;
            this.dgvGrilla.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BurlyWood;
            this.dgvGrilla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrilla.BackgroundColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvGrilla.Location = new System.Drawing.Point(30, 12);
            this.dgvGrilla.MultiSelect = false;
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvGrilla.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrilla.Size = new System.Drawing.Size(522, 375);
            this.dgvGrilla.TabIndex = 5;
            // 
            // buttonGuardarVentaTXT
            // 
            this.buttonGuardarVentaTXT.Location = new System.Drawing.Point(231, 396);
            this.buttonGuardarVentaTXT.Name = "buttonGuardarVentaTXT";
            this.buttonGuardarVentaTXT.Size = new System.Drawing.Size(120, 38);
            this.buttonGuardarVentaTXT.TabIndex = 6;
            this.buttonGuardarVentaTXT.Text = "Guardar producto seleccionado en .txt";
            this.buttonGuardarVentaTXT.UseVisualStyleBackColor = true;
            this.buttonGuardarVentaTXT.Click += new System.EventHandler(this.buttonGuardarVentaTXT_Click);
            // 
            // buttonGuardarVentaEntera
            // 
            this.buttonGuardarVentaEntera.Location = new System.Drawing.Point(231, 440);
            this.buttonGuardarVentaEntera.Name = "buttonGuardarVentaEntera";
            this.buttonGuardarVentaEntera.Size = new System.Drawing.Size(120, 38);
            this.buttonGuardarVentaEntera.TabIndex = 8;
            this.buttonGuardarVentaEntera.Text = "Guardar venta en .txt";
            this.buttonGuardarVentaEntera.UseVisualStyleBackColor = true;
            this.buttonGuardarVentaEntera.Click += new System.EventHandler(this.buttonGuardarVentaEntera_Click);
            // 
            // buttonGuardarXML
            // 
            this.buttonGuardarXML.Location = new System.Drawing.Point(432, 396);
            this.buttonGuardarXML.Name = "buttonGuardarXML";
            this.buttonGuardarXML.Size = new System.Drawing.Size(120, 38);
            this.buttonGuardarXML.TabIndex = 9;
            this.buttonGuardarXML.Text = "Guardar producto seleccionado en .xml";
            this.buttonGuardarXML.UseVisualStyleBackColor = true;
            this.buttonGuardarXML.Click += new System.EventHandler(this.buttonGuardarXML_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "TOTAL";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(474, 515);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(19, 20);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.Text = "0";
            // 
            // imagenPictureBox
            // 
            this.imagenPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("imagenPictureBox.Image")));
            this.imagenPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("imagenPictureBox.InitialImage")));
            this.imagenPictureBox.Location = new System.Drawing.Point(30, 484);
            this.imagenPictureBox.Name = "imagenPictureBox";
            this.imagenPictureBox.Size = new System.Drawing.Size(120, 82);
            this.imagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenPictureBox.TabIndex = 12;
            this.imagenPictureBox.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(591, 568);
            this.Controls.Add(this.imagenPictureBox);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGuardarXML);
            this.Controls.Add(this.buttonGuardarVentaEntera);
            this.Controls.Add(this.buttonGuardarVentaTXT);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.buttonRealizarVenta);
            this.Controls.Add(this.buttonEliminarProducto);
            this.Controls.Add(this.buttonAgregarProducto);
            this.Name = "Principal";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing_1);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.DataGridView dtGrilla;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Button buttonAgregarProducto;
        private System.Windows.Forms.Button buttonEliminarProducto;
        private System.Windows.Forms.Button buttonRealizarVenta;
        private System.Windows.Forms.Button buttonGuardarVentaTXT;
        private Button buttonGuardarVentaEntera;
        private Button buttonGuardarXML;
        private Label label1;
        private Label labelTotal;
        private PictureBox imagenPictureBox;
    }
}