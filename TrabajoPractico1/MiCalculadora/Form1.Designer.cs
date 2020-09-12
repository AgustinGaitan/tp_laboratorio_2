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
            this.Numero1 = new System.Windows.Forms.TextBox();
            this.Numero2 = new System.Windows.Forms.TextBox();
            this.Operador = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(305, 194);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(189, 88);
            this.Limpiar.TabIndex = 5;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(549, 194);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(189, 88);
            this.Cerrar.TabIndex = 6;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            // 
            // Operar
            // 
            this.Operar.Location = new System.Drawing.Point(61, 194);
            this.Operar.Name = "Operar";
            this.Operar.Size = new System.Drawing.Size(189, 88);
            this.Operar.TabIndex = 4;
            this.Operar.Text = "Operar";
            this.Operar.UseVisualStyleBackColor = true;
            // 
            // ConvertirABinario
            // 
            this.ConvertirABinario.Location = new System.Drawing.Point(61, 324);
            this.ConvertirABinario.Name = "ConvertirABinario";
            this.ConvertirABinario.Size = new System.Drawing.Size(324, 84);
            this.ConvertirABinario.TabIndex = 7;
            this.ConvertirABinario.Text = "Convertir a Binario";
            this.ConvertirABinario.UseVisualStyleBackColor = true;
            // 
            // ConvertirADecimal
            // 
            this.ConvertirADecimal.Location = new System.Drawing.Point(414, 324);
            this.ConvertirADecimal.Name = "ConvertirADecimal";
            this.ConvertirADecimal.Size = new System.Drawing.Size(338, 84);
            this.ConvertirADecimal.TabIndex = 8;
            this.ConvertirADecimal.Text = "Convertir a Decimal";
            this.ConvertirADecimal.UseVisualStyleBackColor = true;
            // 
            // Numero1
            // 
            this.Numero1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Numero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero1.Location = new System.Drawing.Point(61, 83);
            this.Numero1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 7);
            this.Numero1.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.Numero1.MinimumSize = new System.Drawing.Size(10, 10);
            this.Numero1.Name = "Numero1";
            this.Numero1.Size = new System.Drawing.Size(206, 83);
            this.Numero1.TabIndex = 1;
            this.Numero1.TextChanged += new System.EventHandler(this.Numero1_TextChanged);
            // 
            // Numero2
            // 
            this.Numero2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Numero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero2.Location = new System.Drawing.Point(524, 83);
            this.Numero2.Name = "Numero2";
            this.Numero2.Size = new System.Drawing.Size(214, 83);
            this.Numero2.TabIndex = 3;
            // 
            // Operador
            // 
            this.Operador.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operador.FormattingEnabled = true;
            this.Operador.Location = new System.Drawing.Point(335, 83);
            this.Operador.Name = "Operador";
            this.Operador.Size = new System.Drawing.Size(119, 84);
            this.Operador.TabIndex = 9;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.Operador);
            this.Controls.Add(this.Numero2);
            this.Controls.Add(this.Numero1);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Button Operar;
        private System.Windows.Forms.Button ConvertirABinario;
        private System.Windows.Forms.Button ConvertirADecimal;
        private System.Windows.Forms.TextBox Numero1;
        private System.Windows.Forms.TextBox Numero2;
        private System.Windows.Forms.ComboBox Operador;
    }
}

