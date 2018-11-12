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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBoletaCompra));
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
            this.TotalCompra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.DGridListaCompras = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.DGridListaB = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label11 = new System.Windows.Forms.Label();
            this.textBuscadorC = new System.Windows.Forms.TextBox();
            this.btnQutarfilaC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGridProductos)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGridListaCompras)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGridListaB)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlosaCompra
            // 
            this.GlosaCompra.Location = new System.Drawing.Point(79, 69);
            this.GlosaCompra.Multiline = true;
            this.GlosaCompra.Name = "GlosaCompra";
            this.GlosaCompra.Size = new System.Drawing.Size(437, 60);
            this.GlosaCompra.TabIndex = 0;
            // 
            // FechaCompra
            // 
            this.FechaCompra.Location = new System.Drawing.Point(16, 30);
            this.FechaCompra.Name = "FechaCompra";
            this.FechaCompra.Size = new System.Drawing.Size(200, 20);
            this.FechaCompra.TabIndex = 1;
            this.FechaCompra.ValueChanged += new System.EventHandler(this.FechaCompra_ValueChanged);
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
            this.label2.Location = new System.Drawing.Point(77, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Glosa";
            // 
            // AceptarCompra
            // 
            this.AceptarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AceptarCompra.Image = ((System.Drawing.Image)(resources.GetObject("AceptarCompra.Image")));
            this.AceptarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AceptarCompra.Location = new System.Drawing.Point(550, 69);
            this.AceptarCompra.Name = "AceptarCompra";
            this.AceptarCompra.Size = new System.Drawing.Size(110, 60);
            this.AceptarCompra.TabIndex = 8;
            this.AceptarCompra.Text = "Comprar";
            this.AceptarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AceptarCompra.UseVisualStyleBackColor = true;
            this.AceptarCompra.Click += new System.EventHandler(this.button1_Click);
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
            this.TotalCompra.TextChanged += new System.EventHandler(this.TotalCompra_TextChanged);
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
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.DGridListaCompras);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(402, 541);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Compras";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // DGridListaCompras
            // 
            this.DGridListaCompras.AllowUserToAddRows = false;
            this.DGridListaCompras.AllowUserToDeleteRows = false;
            this.DGridListaCompras.AllowUserToResizeColumns = false;
            this.DGridListaCompras.AllowUserToResizeRows = false;
            this.DGridListaCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGridListaCompras.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGridListaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridListaCompras.Location = new System.Drawing.Point(1, 2);
            this.DGridListaCompras.Name = "DGridListaCompras";
            this.DGridListaCompras.ReadOnly = true;
            this.DGridListaCompras.RowHeadersWidth = 10;
            this.DGridListaCompras.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGridListaCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGridListaCompras.Size = new System.Drawing.Size(400, 600);
            this.DGridListaCompras.TabIndex = 11;
            this.DGridListaCompras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridListaCompras_CellDoubleClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DGridListaB);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(402, 541);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Bebidas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // DGridListaB
            // 
            this.DGridListaB.AllowUserToAddRows = false;
            this.DGridListaB.AllowUserToDeleteRows = false;
            this.DGridListaB.AllowUserToResizeColumns = false;
            this.DGridListaB.AllowUserToResizeRows = false;
            this.DGridListaB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGridListaB.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGridListaB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridListaB.Location = new System.Drawing.Point(1, 2);
            this.DGridListaB.Name = "DGridListaB";
            this.DGridListaB.ReadOnly = true;
            this.DGridListaB.RowHeadersWidth = 10;
            this.DGridListaB.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGridListaB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGridListaB.Size = new System.Drawing.Size(400, 600);
            this.DGridListaB.TabIndex = 11;
            this.DGridListaB.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridListaB_CellDoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(672, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(410, 567);
            this.tabControl1.TabIndex = 13;
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(672, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "BUSCAR";
            // 
            // textBuscadorC
            // 
            this.textBuscadorC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBuscadorC.Location = new System.Drawing.Point(729, 43);
            this.textBuscadorC.Name = "textBuscadorC";
            this.textBuscadorC.Size = new System.Drawing.Size(174, 20);
            this.textBuscadorC.TabIndex = 28;
            this.textBuscadorC.TextChanged += new System.EventHandler(this.textBuscadorC_TextChanged);
            // 
            // btnQutarfilaC
            // 
            this.btnQutarfilaC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQutarfilaC.Image = ((System.Drawing.Image)(resources.GetObject("btnQutarfilaC.Image")));
            this.btnQutarfilaC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQutarfilaC.Location = new System.Drawing.Point(3, 69);
            this.btnQutarfilaC.Name = "btnQutarfilaC";
            this.btnQutarfilaC.Size = new System.Drawing.Size(74, 60);
            this.btnQutarfilaC.TabIndex = 30;
            this.btnQutarfilaC.Text = "Elimi. F.";
            this.btnQutarfilaC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQutarfilaC.UseVisualStyleBackColor = true;
            this.btnQutarfilaC.Click += new System.EventHandler(this.btnQutarfilaC_Click);
            // 
            // FBoletaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnQutarfilaC);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBuscadorC);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TotalCompra);
            this.Controls.Add(this.AceptarCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGridProductos);
            this.Controls.Add(this.FechaCompra);
            this.Controls.Add(this.GlosaCompra);
            this.Name = "FBoletaCompra";
            this.Size = new System.Drawing.Size(1084, 639);
            ((System.ComponentModel.ISupportInitialize)(this.DGridProductos)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGridListaCompras)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGridListaB)).EndInit();
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox TotalCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView DGridListaCompras;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView DGridListaB;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBuscadorC;
        private System.Windows.Forms.Button btnQutarfilaC;
    }
}
