namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.Limpiar = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.Operar = new System.Windows.Forms.Button();
            this.ConvertirABinario = new System.Windows.Forms.Button();
            this.ConvertirADecimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(304, 194);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(189, 88);
            this.Limpiar.TabIndex = 1;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(563, 194);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(189, 88);
            this.Cerrar.TabIndex = 2;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            // 
            // Operar
            // 
            this.Operar.Location = new System.Drawing.Point(61, 194);
            this.Operar.Name = "Operar";
            this.Operar.Size = new System.Drawing.Size(189, 88);
            this.Operar.TabIndex = 3;
            this.Operar.Text = "Operar";
            this.Operar.UseVisualStyleBackColor = true;
            // 
            // ConvertirABinario
            // 
            this.ConvertirABinario.Location = new System.Drawing.Point(61, 324);
            this.ConvertirABinario.Name = "ConvertirABinario";
            this.ConvertirABinario.Size = new System.Drawing.Size(324, 84);
            this.ConvertirABinario.TabIndex = 4;
            this.ConvertirABinario.Text = "Convertir a Binario";
            this.ConvertirABinario.UseVisualStyleBackColor = true;
            // 
            // ConvertirADecimal
            // 
            this.ConvertirADecimal.Location = new System.Drawing.Point(414, 324);
            this.ConvertirADecimal.Name = "ConvertirADecimal";
            this.ConvertirADecimal.Size = new System.Drawing.Size(338, 84);
            this.ConvertirADecimal.TabIndex = 5;
            this.ConvertirADecimal.Text = "Convertir a Decimal";
            this.ConvertirADecimal.UseVisualStyleBackColor = true;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.ConvertirADecimal);
            this.Controls.Add(this.ConvertirABinario);
            this.Controls.Add(this.Operar);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Limpiar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(816, 460);
            this.MinimumSize = new System.Drawing.Size(816, 460);
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Button Operar;
        private System.Windows.Forms.Button ConvertirABinario;
        private System.Windows.Forms.Button ConvertirADecimal;
    }
}

