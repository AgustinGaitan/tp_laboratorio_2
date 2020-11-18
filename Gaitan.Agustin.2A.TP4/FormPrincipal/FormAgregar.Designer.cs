namespace FormPrincipal
{
    partial class FormAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAceptarFormAgregar = new System.Windows.Forms.Button();
            this.comboBoxAgregarProductos = new System.Windows.Forms.ComboBox();
            this.comboBoxCaracteristicas = new System.Windows.Forms.ComboBox();
            this.Producto = new System.Windows.Forms.Label();
            this.Caracteristica = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAceptarFormAgregar
            // 
            this.buttonAceptarFormAgregar.Location = new System.Drawing.Point(67, 178);
            this.buttonAceptarFormAgregar.Name = "buttonAceptarFormAgregar";
            this.buttonAceptarFormAgregar.Size = new System.Drawing.Size(125, 30);
            this.buttonAceptarFormAgregar.TabIndex = 3;
            this.buttonAceptarFormAgregar.Text = "Aceptar";
            this.buttonAceptarFormAgregar.UseVisualStyleBackColor = true;
            this.buttonAceptarFormAgregar.Click += new System.EventHandler(this.buttonAceptarFormAgregar_Click);
            // 
            // comboBoxAgregarProductos
            // 
            this.comboBoxAgregarProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAgregarProductos.FormattingEnabled = true;
            this.comboBoxAgregarProductos.Items.AddRange(new object[] {
            "Barra",
            "Mancuerna",
            "Colchoneta"});
            this.comboBoxAgregarProductos.Location = new System.Drawing.Point(13, 29);
            this.comboBoxAgregarProductos.MaxDropDownItems = 3;
            this.comboBoxAgregarProductos.MaximumSize = new System.Drawing.Size(200, 0);
            this.comboBoxAgregarProductos.Name = "comboBoxAgregarProductos";
            this.comboBoxAgregarProductos.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAgregarProductos.TabIndex = 5;
            this.comboBoxAgregarProductos.SelectedIndexChanged += new System.EventHandler(this.comboBoxAgregarProductos_SelectedIndexChanged);
            // 
            // comboBoxCaracteristicas
            // 
            this.comboBoxCaracteristicas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCaracteristicas.FormattingEnabled = true;
            this.comboBoxCaracteristicas.Location = new System.Drawing.Point(13, 84);
            this.comboBoxCaracteristicas.Name = "comboBoxCaracteristicas";
            this.comboBoxCaracteristicas.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCaracteristicas.TabIndex = 6;
            this.comboBoxCaracteristicas.SelectedIndexChanged += new System.EventHandler(this.comboBoxCaracteristicas_SelectedIndexChanged);
            // 
            // Producto
            // 
            this.Producto.AutoSize = true;
            this.Producto.Location = new System.Drawing.Point(13, 10);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(50, 13);
            this.Producto.TabIndex = 7;
            this.Producto.Text = "Producto";
            // 
            // Caracteristica
            // 
            this.Caracteristica.AutoSize = true;
            this.Caracteristica.Location = new System.Drawing.Point(10, 68);
            this.Caracteristica.Name = "Caracteristica";
            this.Caracteristica.Size = new System.Drawing.Size(71, 13);
            this.Caracteristica.TabIndex = 8;
            this.Caracteristica.Text = "Caracteristica";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(82, 134);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(18, 18);
            this.labelPrecio.TabIndex = 9;
            this.labelPrecio.Text = "0";
            this.labelPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Precio";
            // 
            // FormAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 232);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.Caracteristica);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.comboBoxCaracteristicas);
            this.Controls.Add(this.comboBoxAgregarProductos);
            this.Controls.Add(this.buttonAceptarFormAgregar);
            this.Name = "FormAgregar";
            this.Text = "FormAgregar";
            this.Load += new System.EventHandler(this.FormAgregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAceptarFormAgregar;
        private System.Windows.Forms.ComboBox comboBoxAgregarProductos;
        private System.Windows.Forms.ComboBox comboBoxCaracteristicas;
        private System.Windows.Forms.Label Producto;
        private System.Windows.Forms.Label Caracteristica;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label label1;
    }
}