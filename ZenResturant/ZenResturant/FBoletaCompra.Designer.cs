namespace ZenResturant
{
    partial class FBoletaCompra
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
            this.GlosaCompra = new System.Windows.Forms.TextBox();
            this.FechaCompra = new System.Windows.Forms.DateTimePicker();
            this.DGridProductos = new System.Windows.Forms.DataGridView();
            this.codigo_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AceptarCompra = new System.Windows.Forms.Button();
            this.DGridLista = new System.Windows.Forms.DataGridView();
            this.TotalCompra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGridLista)).BeginInit();
            this.SuspendLayout();
            // 
            // GlosaCompra
            // 
            this.GlosaCompra.Location = new System.Drawing.Point(16, 69);
            this.GlosaCompra.Multiline = true;
            this.GlosaCompra.Name = "GlosaCompra";
            this.GlosaCompra.Size = new System.Drawing.Size(500, 60);
            this.GlosaCompra.TabIndex = 0;
            // 
            // FechaCompra
            // 
            this.FechaCompra.Location = new System.Drawing.Point(16, 30);
            this.FechaCompra.Name = "FechaCompra";
            this.FechaCompra.Size = new System.Drawing.Size(200, 20);
            this.FechaCompra.TabIndex = 1;
            // 
            // DGridProductos
            // 
            this.DGridProductos.AllowUserToAddRows = false;
            this.DGridProductos.AllowUserToResizeColumns = false;
            this.DGridProductos.AllowUserToResizeRows = false;
            this.DGridProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGridProductos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_producto,
            this.nombre_producto,
            this.precio,
            this.cantidad});
            this.DGridProductos.Location = new System.Drawing.Point(3, 135);
            this.DGridProductos.Name = "DGridProductos";
            this.DGridProductos.RowHeadersWidth = 10;
            this.DGridProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGridProductos.Size = new System.Drawing.Size(657, 475);
            this.DGridProductos.TabIndex = 5;
            this.DGridProductos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridProductos_CellEndEdit);
            this.DGridProductos.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DGridProductos_RowStateChanged);
            // 
            // codigo_producto
            // 
            this.codigo_producto.FillWeight = 99.61929F;
            this.codigo_producto.HeaderText = "Codigo Producto";
            this.codigo_producto.Name = "codigo_producto";
            // 
            // nombre_producto
            // 
            this.nombre_producto.FillWeight = 99.61929F;
            this.nombre_producto.HeaderText = "Nombre de Producto";
            this.nombre_producto.Name = "nombre_producto";
            // 
            // precio
            // 
            this.precio.FillWeight = 99.61929F;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // cantidad
            // 
            this.cantidad.FillWeight = 99.61929F;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Glosa";
            // 
            // AceptarCompra
            // 
            this.AceptarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AceptarCompra.Location = new System.Drawing.Point(580, 99);
            this.AceptarCompra.Name = "AceptarCompra";
            this.AceptarCompra.Size = new System.Drawing.Size(80, 30);
            this.AceptarCompra.TabIndex = 8;
            this.AceptarCompra.Text = "Comprar";
            this.AceptarCompra.UseVisualStyleBackColor = true;
            this.AceptarCompra.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGridLista
            // 
            this.DGridLista.AllowUserToAddRows = false;
            this.DGridLista.AllowUserToDeleteRows = false;
            this.DGridLista.AllowUserToResizeColumns = false;
            this.DGridLista.AllowUserToResizeRows = false;
            this.DGridLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGridLista.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridLista.Location = new System.Drawing.Point(680, 15);
            this.DGridLista.Name = "DGridLista";
            this.DGridLista.ReadOnly = true;
            this.DGridLista.RowHeadersWidth = 10;
            this.DGridLista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGridLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGridLista.Size = new System.Drawing.Size(400, 622);
            this.DGridLista.TabIndex = 9;
            this.DGridLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridLista_CellDoubleClick);
            // 
            // TotalCompra
            // 
            this.TotalCompra.BackColor = System.Drawing.Color.White;
            this.TotalCompra.Location = new System.Drawing.Point(560, 616);
            this.TotalCompra.Name = "TotalCompra";
            this.TotalCompra.ReadOnly = true;
            this.TotalCompra.Size = new System.Drawing.Size(100, 20);
            this.TotalCompra.TabIndex = 11;
            this.TotalCompra.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 623);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "TOTAL :";
            // 
            // FBoletaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TotalCompra);
            this.Controls.Add(this.DGridLista);
            this.Controls.Add(this.AceptarCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGridProductos);
            this.Controls.Add(this.FechaCompra);
            this.Controls.Add(this.GlosaCompra);
            this.Name = "FBoletaCompra";
            this.Size = new System.Drawing.Size(1084, 639);
            ((System.ComponentModel.ISupportInitialize)(this.DGridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGridLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GlosaCompra;
        private System.Windows.Forms.DateTimePicker FechaCompra;
        private System.Windows.Forms.DataGridView DGridProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AceptarCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridView DGridLista;
        private System.Windows.Forms.TextBox TotalCompra;
        private System.Windows.Forms.Label label3;
    }
}
