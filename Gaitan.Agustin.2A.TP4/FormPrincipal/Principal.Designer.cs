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
            this.buttonAgregarProducto = new System.Windows.Forms.Button();
            this.buttonEliminarProducto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.buttonGuardarVentaTXT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAgregarProducto
            // 
            this.buttonAgregarProducto.Location = new System.Drawing.Point(30, 406);
            this.buttonAgregarProducto.Name = "buttonAgregarProducto";
            this.buttonAgregarProducto.Size = new System.Drawing.Size(120, 32);
            this.buttonAgregarProducto.TabIndex = 1;
            this.buttonAgregarProducto.Text = "Agregar producto";
            this.buttonAgregarProducto.UseVisualStyleBackColor = true;
            this.buttonAgregarProducto.Click += new System.EventHandler(this.buttonAgregarProducto_Click);
            // 
            // buttonEliminarProducto
            // 
            this.buttonEliminarProducto.Location = new System.Drawing.Point(30, 457);
            this.buttonEliminarProducto.Name = "buttonEliminarProducto";
            this.buttonEliminarProducto.Size = new System.Drawing.Size(120, 34);
            this.buttonEliminarProducto.TabIndex = 3;
            this.buttonEliminarProducto.Text = "Eliminar producto";
            this.buttonEliminarProducto.UseVisualStyleBackColor = true;
            this.buttonEliminarProducto.Click += new System.EventHandler(this.buttonEliminarProducto_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Realizar venta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.RowsDefaultCellStyle.SelectionBackColor = Color.DarkOliveGreen;
            this.dgvGrilla.RowsDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            this.dgvGrilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrilla.ColumnHeadersDefaultCellStyle.Font = new Font(dgvGrilla.Font, FontStyle.Bold);
            this.dgvGrilla.AlternatingRowsDefaultCellStyle.BackColor = Color.BurlyWood;
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToResizeColumns = false;
            this.dgvGrilla.AllowUserToResizeRows = false;
            this.dgvGrilla.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvGrilla.Location = new System.Drawing.Point(30, 12);
            this.dgvGrilla.MultiSelect = false;
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrilla.Size = new System.Drawing.Size(522, 375);
            this.dgvGrilla.TabIndex = 5;
            // 
            // buttonGuardarVentaTXT
            // 
            this.buttonGuardarVentaTXT.Location = new System.Drawing.Point(432, 406);
            this.buttonGuardarVentaTXT.Name = "buttonGuardarVentaTXT";
            this.buttonGuardarVentaTXT.Size = new System.Drawing.Size(120, 32);
            this.buttonGuardarVentaTXT.TabIndex = 6;
            this.buttonGuardarVentaTXT.Text = "Guardar Venta TXT";
            this.buttonGuardarVentaTXT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardarVentaTXT.UseVisualStyleBackColor = true;
            this.buttonGuardarVentaTXT.Click += new System.EventHandler(this.buttonGuardarVentaTXT_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(591, 568);
            this.Controls.Add(this.buttonGuardarVentaTXT);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEliminarProducto);
            this.Controls.Add(this.buttonAgregarProducto);
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.DataGridView dtGrilla;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Button buttonAgregarProducto;
        private System.Windows.Forms.Button buttonEliminarProducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonGuardarVentaTXT;
    }
}