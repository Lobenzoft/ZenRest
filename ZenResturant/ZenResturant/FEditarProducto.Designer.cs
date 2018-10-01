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
            this.SuspendLayout();
            // 
            // ComboOpcion
            // 
            this.ComboOpcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboOpcion.Enabled = false;
            this.ComboOpcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboOpcion.FormattingEnabled = true;
            this.ComboOpcion.Location = new System.Drawing.Point(15, 177);
            this.ComboOpcion.Name = "ComboOpcion";
            this.ComboOpcion.Size = new System.Drawing.Size(150, 21);
            this.ComboOpcion.TabIndex = 24;
            // 
            // BCancelar
            // 
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCancelar.Location = new System.Drawing.Point(300, 210);
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
            this.BAceptar.Location = new System.Drawing.Point(180, 210);
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
            this.label3.Location = new System.Drawing.Point(15, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Producto de Invetario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 101);
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
            // FEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
    }
}
