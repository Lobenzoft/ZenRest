namespace ZenResturant
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.VentaButon = new System.Windows.Forms.Button();
            this.CompraButon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VentaButon
            // 
            this.VentaButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VentaButon.Image = ((System.Drawing.Image)(resources.GetObject("VentaButon.Image")));
            this.VentaButon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VentaButon.Location = new System.Drawing.Point(3, 2);
            this.VentaButon.Name = "VentaButon";
            this.VentaButon.Size = new System.Drawing.Size(110, 45);
            this.VentaButon.TabIndex = 0;
            this.VentaButon.TabStop = false;
            this.VentaButon.Text = "Venta";
            this.VentaButon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VentaButon.UseVisualStyleBackColor = true;
            this.VentaButon.Click += new System.EventHandler(this.VentaButon_Click);
            // 
            // CompraButon
            // 
            this.CompraButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompraButon.Image = ((System.Drawing.Image)(resources.GetObject("CompraButon.Image")));
            this.CompraButon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CompraButon.Location = new System.Drawing.Point(119, 2);
            this.CompraButon.Name = "CompraButon";
            this.CompraButon.Size = new System.Drawing.Size(110, 45);
            this.CompraButon.TabIndex = 1;
            this.CompraButon.TabStop = false;
            this.CompraButon.Text = "Compra";
            this.CompraButon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CompraButon.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(235, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 45);
            this.button1.TabIndex = 2;
            this.button1.TabStop = false;
            this.button1.Text = "Clientes";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(351, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 45);
            this.button2.TabIndex = 3;
            this.button2.TabStop = false;
            this.button2.Text = "Inventarios";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(467, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 45);
            this.button3.TabIndex = 4;
            this.button3.TabStop = false;
            this.button3.Text = "Productos";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(583, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 45);
            this.button4.TabIndex = 5;
            this.button4.TabStop = false;
            this.button4.Text = "Reportes";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CompraButon);
            this.Controls.Add(this.VentaButon);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(1084, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VentaButon;
        private System.Windows.Forms.Button CompraButon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
