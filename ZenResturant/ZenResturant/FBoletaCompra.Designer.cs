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
            this.TotalCompra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGridListaD = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.DGridListaA = new System.Windows.Forms.DataGridView();
            this.DGridListaC = new System.Windows.Forms.DataGridView();
            this.DGridListaB = new System.Windows.Forms.DataGridView();
            this.DGridListaE = new System.Windows.Forms.DataGridView();
            this.DGridListaCompras = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGridProductos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGridListaD)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGridListaA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGridListaC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGridListaB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGridListaE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGridListaCompras)).BeginInit();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(672, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(410, 631);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.DGridListaE);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(402, 605);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Extras";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DGridListaB);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(402, 605);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Bebidas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DGridListaC);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(402, 605);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cena";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGridListaA);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(402, 605);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alumerzo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGridListaD
            // 
            this.DGridListaD.AllowUserToAddRows = false;
            this.DGridListaD.AllowUserToDeleteRows = false;
            this.DGridListaD.AllowUserToResizeColumns = false;
            this.DGridListaD.AllowUserToResizeRows = false;
            this.DGridListaD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGridListaD.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGridListaD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridListaD.Location = new System.Drawing.Point(1, 2);
            this.DGridListaD.Name = "DGridListaD";
            this.DGridListaD.ReadOnly = true;
            this.DGridListaD.RowHeadersWidth = 10;
            this.DGridListaD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGridListaD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGridListaD.Size = new System.Drawing.Size(400, 600);
            this.DGridListaD.TabIndex = 9;
            this.DGridListaD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridLista_CellDoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGridListaD);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(402, 605);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Desayuno";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.DGridListaCompras);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(402, 605);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Compras";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // DGridListaA
            // 
            this.DGridListaA.AllowUserToAddRows = false;
            this.DGridListaA.AllowUserToDeleteRows = false;
            this.DGridListaA.AllowUserToResizeColumns = false;
            this.DGridListaA.AllowUserToResizeRows = false;
            this.DGridListaA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGridListaA.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGridListaA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridListaA.Location = new System.Drawing.Point(1, 2);
            this.DGridListaA.Name = "DGridListaA";
            this.DGridListaA.ReadOnly = true;
            this.DGridListaA.RowHeadersWidth = 10;
            this.DGridListaA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGridListaA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGridListaA.Size = new System.Drawing.Size(400, 600);
            this.DGridListaA.TabIndex = 10;
            this.DGridListaA.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridListaA_CellDoubleClick);
            // 
            // DGridListaC
            // 
            this.DGridListaC.AllowUserToAddRows = false;
            this.DGridListaC.AllowUserToDeleteRows = false;
            this.DGridListaC.AllowUserToResizeColumns = false;
            this.DGridListaC.AllowUserToResizeRows = false;
            this.DGridListaC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGridListaC.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGridListaC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridListaC.Location = new System.Drawing.Point(1, 2);
            this.DGridListaC.Name = "DGridListaC";
            this.DGridListaC.ReadOnly = true;
            this.DGridListaC.RowHeadersWidth = 10;
            this.DGridListaC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGridListaC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGridListaC.Size = new System.Drawing.Size(400, 600);
            this.DGridListaC.TabIndex = 11;
            this.DGridListaC.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridListaC_CellDoubleClick);
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
            // DGridListaE
            // 
            this.DGridListaE.AllowUserToAddRows = false;
            this.DGridListaE.AllowUserToDeleteRows = false;
            this.DGridListaE.AllowUserToResizeColumns = false;
            this.DGridListaE.AllowUserToResizeRows = false;
            this.DGridListaE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGridListaE.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGridListaE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridListaE.Location = new System.Drawing.Point(1, 2);
            this.DGridListaE.Name = "DGridListaE";
            this.DGridListaE.ReadOnly = true;
            this.DGridListaE.RowHeadersWidth = 10;
            this.DGridListaE.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGridListaE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGridListaE.Size = new System.Drawing.Size(400, 600);
            this.DGridListaE.TabIndex = 11;
            this.DGridListaE.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridListaE_CellDoubleClick);
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
            // FBoletaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGridListaD)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGridListaA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGridListaC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGridListaB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGridListaE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGridListaCompras)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DGridListaD;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView DGridListaA;
        private System.Windows.Forms.DataGridView DGridListaC;
        private System.Windows.Forms.DataGridView DGridListaB;
        private System.Windows.Forms.DataGridView DGridListaE;
        private System.Windows.Forms.DataGridView DGridListaCompras;
    }
}
