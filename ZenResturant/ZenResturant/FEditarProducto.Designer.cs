namespace ZenResturant
{
    partial class FEditarProducto
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComboOpcion = new System.Windows.Forms.ComboBox();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BAceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextCodigo = new System.Windows.Forms.TextBox();
            this.TextNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextPrecio = new System.Windows.Forms.TextBox();
            this.ComboCategoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboOpcion
            // 
            this.ComboOpcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboOpcion.Enabled = false;
            this.ComboOpcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboOpcion.FormattingEnabled = true;
            this.ComboOpcion.Location = new System.Drawing.Point(15, 300);
            this.ComboOpcion.Name = "ComboOpcion";
            this.ComboOpcion.Size = new System.Drawing.Size(150, 21);
            this.ComboOpcion.TabIndex = 24;
            // 
            // BCancelar
            // 
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCancelar.Location = new System.Drawing.Point(312, 271);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(110, 45);
            this.BCancelar.TabIndex = 23;
            this.BCancelar.TabStop = false;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BAceptar
            // 
            this.BAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAceptar.Location = new System.Drawing.Point(192, 271);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(110, 45);
            this.BAceptar.TabIndex = 22;
            this.BAceptar.TabStop = false;
            this.BAceptar.Text = "Aceptar";
            this.BAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAceptar.UseVisualStyleBackColor = true;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Codigo de Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre de Producto";
            // 
            // TextCodigo
            // 
            this.TextCodigo.Enabled = false;
            this.TextCodigo.Location = new System.Drawing.Point(15, 120);
            this.TextCodigo.Name = "TextCodigo";
            this.TextCodigo.Size = new System.Drawing.Size(150, 20);
            this.TextCodigo.TabIndex = 18;
            // 
            // TextNombre
            // 
            this.TextNombre.Location = new System.Drawing.Point(15, 60);
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.Size = new System.Drawing.Size(150, 20);
            this.TextNombre.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Precio Producto";
            // 
            // TextPrecio
            // 
            this.TextPrecio.Location = new System.Drawing.Point(15, 180);
            this.TextPrecio.Name = "TextPrecio";
            this.TextPrecio.Size = new System.Drawing.Size(150, 20);
            this.TextPrecio.TabIndex = 25;
            // 
            // ComboCategoria
            // 
            this.ComboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboCategoria.FormattingEnabled = true;
            this.ComboCategoria.Location = new System.Drawing.Point(15, 240);
            this.ComboCategoria.Name = "ComboCategoria";
            this.ComboCategoria.Size = new System.Drawing.Size(150, 21);
            this.ComboCategoria.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Producto de Invetario";
            // 
            // FEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextPrecio);
            this.Controls.Add(this.ComboOpcion);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BAceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextCodigo);
            this.Controls.Add(this.TextNombre);
            this.Name = "FEditarProducto";
            this.Size = new System.Drawing.Size(1084, 639);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboOpcion;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BAceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextCodigo;
        private System.Windows.Forms.TextBox TextNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextPrecio;
        private System.Windows.Forms.ComboBox ComboCategoria;
        private System.Windows.Forms.Label label5;
    }
}
