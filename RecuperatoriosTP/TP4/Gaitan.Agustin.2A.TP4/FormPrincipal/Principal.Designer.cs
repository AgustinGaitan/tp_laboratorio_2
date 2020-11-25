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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonAgregarProducto = new System.Windows.Forms.Button();
            this.buttonEliminarProducto = new System.Windows.Forms.Button();
            this.buttonRealizarVenta = new System.Windows.Forms.Button();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.buttonGuardarVentaEntera = new System.Windows.Forms.Button();
            this.buttonGuardarXML = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.imagenPictureBox = new System.Windows.Forms.PictureBox();
            this.datGridAerobico = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEliminarProductoAerobico = new System.Windows.Forms.Button();
            this.pictureBoxAerobico = new System.Windows.Forms.PictureBox();
            this.buttonLeerVenta = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datGridAerobico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerobico)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAgregarProducto
            // 
            this.buttonAgregarProducto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAgregarProducto.Location = new System.Drawing.Point(30, 396);
            this.buttonAgregarProducto.Name = "buttonAgregarProducto";
            this.buttonAgregarProducto.Size = new System.Drawing.Size(120, 32);
            this.buttonAgregarProducto.TabIndex = 1;
            this.buttonAgregarProducto.Text = "Agregar producto";
            this.buttonAgregarProducto.UseVisualStyleBackColor = false;
            this.buttonAgregarProducto.Click += new System.EventHandler(this.buttonAgregarProducto_Click);
            // 
            // buttonEliminarProducto
            // 
            this.buttonEliminarProducto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEliminarProducto.Location = new System.Drawing.Point(30, 434);
            this.buttonEliminarProducto.Name = "buttonEliminarProducto";
            this.buttonEliminarProducto.Size = new System.Drawing.Size(120, 54);
            this.buttonEliminarProducto.TabIndex = 3;
            this.buttonEliminarProducto.Text = "Eliminar producto seleccionado de fuerza";
            this.buttonEliminarProducto.UseVisualStyleBackColor = false;
            this.buttonEliminarProducto.Click += new System.EventHandler(this.buttonEliminarProducto_Click);
            // 
            // buttonRealizarVenta
            // 
            this.buttonRealizarVenta.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonRealizarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRealizarVenta.Location = new System.Drawing.Point(231, 486);
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
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.AllowUserToResizeColumns = false;
            this.dgvGrilla.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.BurlyWood;
            this.dgvGrilla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrilla.BackgroundColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvGrilla.Location = new System.Drawing.Point(140, 12);
            this.dgvGrilla.MultiSelect = false;
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvGrilla.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrilla.Size = new System.Drawing.Size(412, 179);
            this.dgvGrilla.TabIndex = 5;
            // 
            // buttonGuardarVentaEntera
            // 
            this.buttonGuardarVentaEntera.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGuardarVentaEntera.Location = new System.Drawing.Point(231, 396);
            this.buttonGuardarVentaEntera.Name = "buttonGuardarVentaEntera";
            this.buttonGuardarVentaEntera.Size = new System.Drawing.Size(120, 38);
            this.buttonGuardarVentaEntera.TabIndex = 8;
            this.buttonGuardarVentaEntera.Text = "Guardar venta en .txt";
            this.buttonGuardarVentaEntera.UseVisualStyleBackColor = false;
            this.buttonGuardarVentaEntera.Click += new System.EventHandler(this.buttonGuardarVentaEntera_Click);
            // 
            // buttonGuardarXML
            // 
            this.buttonGuardarXML.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGuardarXML.Location = new System.Drawing.Point(231, 440);
            this.buttonGuardarXML.Name = "buttonGuardarXML";
            this.buttonGuardarXML.Size = new System.Drawing.Size(120, 38);
            this.buttonGuardarXML.TabIndex = 9;
            this.buttonGuardarXML.Text = "Guardar venta en .xml";
            this.buttonGuardarXML.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardarXML.UseVisualStyleBackColor = false;
            this.buttonGuardarXML.Click += new System.EventHandler(this.buttonGuardarXML_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "TOTAL";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(474, 539);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(19, 20);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.Text = "0";
            // 
            // imagenPictureBox
            // 
            this.imagenPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("imagenPictureBox.Image")));
            this.imagenPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("imagenPictureBox.InitialImage")));
            this.imagenPictureBox.Location = new System.Drawing.Point(12, 57);
            this.imagenPictureBox.Name = "imagenPictureBox";
            this.imagenPictureBox.Size = new System.Drawing.Size(120, 82);
            this.imagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenPictureBox.TabIndex = 12;
            this.imagenPictureBox.TabStop = false;
            // 
            // datGridAerobico
            // 
            this.datGridAerobico.AllowUserToAddRows = false;
            this.datGridAerobico.AllowUserToResizeColumns = false;
            this.datGridAerobico.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.BurlyWood;
            this.datGridAerobico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.datGridAerobico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datGridAerobico.BackgroundColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datGridAerobico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.datGridAerobico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGridAerobico.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.datGridAerobico.Location = new System.Drawing.Point(140, 197);
            this.datGridAerobico.MultiSelect = false;
            this.datGridAerobico.Name = "datGridAerobico";
            this.datGridAerobico.ReadOnly = true;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.datGridAerobico.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.datGridAerobico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datGridAerobico.Size = new System.Drawing.Size(412, 179);
            this.datGridAerobico.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "FUERZA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "AEROBICO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEliminarProductoAerobico
            // 
            this.buttonEliminarProductoAerobico.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEliminarProductoAerobico.Location = new System.Drawing.Point(30, 494);
            this.buttonEliminarProductoAerobico.Name = "buttonEliminarProductoAerobico";
            this.buttonEliminarProductoAerobico.Size = new System.Drawing.Size(120, 54);
            this.buttonEliminarProductoAerobico.TabIndex = 17;
            this.buttonEliminarProductoAerobico.Text = "Eliminar producto seleccionado aerobico";
            this.buttonEliminarProductoAerobico.UseVisualStyleBackColor = false;
            this.buttonEliminarProductoAerobico.Click += new System.EventHandler(this.buttonEliminarProductoAerobico_Click);
            // 
            // pictureBoxAerobico
            // 
            this.pictureBoxAerobico.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAerobico.Image")));
            this.pictureBoxAerobico.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAerobico.InitialImage")));
            this.pictureBoxAerobico.Location = new System.Drawing.Point(12, 254);
            this.pictureBoxAerobico.Name = "pictureBoxAerobico";
            this.pictureBoxAerobico.Size = new System.Drawing.Size(120, 82);
            this.pictureBoxAerobico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAerobico.TabIndex = 18;
            this.pictureBoxAerobico.TabStop = false;
            // 
            // buttonLeerVenta
            // 
            this.buttonLeerVenta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLeerVenta.Location = new System.Drawing.Point(422, 396);
            this.buttonLeerVenta.Name = "buttonLeerVenta";
            this.buttonLeerVenta.Size = new System.Drawing.Size(120, 38);
            this.buttonLeerVenta.TabIndex = 19;
            this.buttonLeerVenta.Text = "Leer ventas";
            this.buttonLeerVenta.UseVisualStyleBackColor = false;
            this.buttonLeerVenta.Click += new System.EventHandler(this.buttonLeerVenta_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSalir.Location = new System.Drawing.Point(422, 442);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(120, 38);
            this.buttonSalir.TabIndex = 20;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(591, 568);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonLeerVenta);
            this.Controls.Add(this.pictureBoxAerobico);
            this.Controls.Add(this.buttonEliminarProductoAerobico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datGridAerobico);
            this.Controls.Add(this.imagenPictureBox);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGuardarXML);
            this.Controls.Add(this.buttonGuardarVentaEntera);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.buttonRealizarVenta);
            this.Controls.Add(this.buttonEliminarProducto);
            this.Controls.Add(this.buttonAgregarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing_1);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datGridAerobico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerobico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.DataGridView dtGrilla;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Button buttonAgregarProducto;
        private System.Windows.Forms.Button buttonEliminarProducto;
        private System.Windows.Forms.Button buttonRealizarVenta;
        private Button buttonGuardarVentaEntera;
        private Button buttonGuardarXML;
        private Label label1;
        private Label labelTotal;
        private PictureBox imagenPictureBox;
        private DataGridView datGridAerobico;
        private Label label2;
        private Label label3;
        private Button buttonEliminarProductoAerobico;
        private PictureBox pictureBoxAerobico;
        private Button buttonLeerVenta;
        private Button buttonSalir;
    }
}