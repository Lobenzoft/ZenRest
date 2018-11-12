namespace ZenResturant
{
    partial class FProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FProductos));
            this.DGridProductos = new System.Windows.Forms.DataGridView();
            this.BEliminarProducto = new System.Windows.Forms.Button();
            this.BEditarProducto = new System.Windows.Forms.Button();
            this.BAgregarProducto = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBuscadorP = new System.Windows.Forms.TextBox();
            this.ComboCategoriaB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGridProductos
            // 
            this.DGridProductos.AllowUserToAddRows = false;
            this.DGridProductos.AllowUserToDeleteRows = false;
            this.DGridProductos.AllowUserToResizeColumns = false;
            this.DGridProductos.AllowUserToResizeRows = false;
            this.DGridProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGridProductos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridProductos.Location = new System.Drawing.Point(3, 54);
            this.DGridProductos.Name = "DGridProductos";
            this.DGridProductos.ReadOnly = true;
            this.DGridProductos.RowHeadersWidth = 10;
            this.DGridProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGridProductos.Size = new System.Drawing.Size(694, 582);
            this.DGridProductos.TabIndex = 8;
            // 
            // BEliminarProducto
            // 
            this.BEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEliminarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BEliminarProducto.Image")));
            this.BEliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEliminarProducto.Location = new System.Drawing.Point(235, 3);
            this.BEliminarProducto.Name = "BEliminarProducto";
            this.BEliminarProducto.Size = new System.Drawing.Size(110, 45);
            this.BEliminarProducto.TabIndex = 7;
            this.BEliminarProducto.TabStop = false;
            this.BEliminarProducto.Text = "Eliminar";
            this.BEliminarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEliminarProducto.UseVisualStyleBackColor = true;
            this.BEliminarProducto.Click += new System.EventHandler(this.BEliminarProducto_Click);
            // 
            // BEditarProducto
            // 
            this.BEditarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEditarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BEditarProducto.Image")));
            this.BEditarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEditarProducto.Location = new System.Drawing.Point(119, 3);
            this.BEditarProducto.Name = "BEditarProducto";
            this.BEditarProducto.Size = new System.Drawing.Size(110, 45);
            this.BEditarProducto.TabIndex = 6;
            this.BEditarProducto.TabStop = false;
            this.BEditarProducto.Text = "Editar";
            this.BEditarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEditarProducto.UseVisualStyleBackColor = true;
            this.BEditarProducto.Click += new System.EventHandler(this.BEditarProducto_Click);
            // 
            // BAgregarProducto
            // 
            this.BAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BAgregarProducto.Image")));
            this.BAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAgregarProducto.Location = new System.Drawing.Point(3, 3);
            this.BAgregarProducto.Name = "BAgregarProducto";
            this.BAgregarProducto.Size = new System.Drawing.Size(110, 45);
            this.BAgregarProducto.TabIndex = 5;
            this.BAgregarProducto.TabStop = false;
            this.BAgregarProducto.Text = "Agregar";
            this.BAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAgregarProducto.UseVisualStyleBackColor = true;
            this.BAgregarProducto.Click += new System.EventHandler(this.BAgregarProducto_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(510, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "BUSCAR";
            // 
            // textBuscadorP
            // 
            this.textBuscadorP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBuscadorP.Location = new System.Drawing.Point(567, 16);
            this.textBuscadorP.Name = "textBuscadorP";
            this.textBuscadorP.Size = new System.Drawing.Size(128, 20);
            this.textBuscadorP.TabIndex = 28;
            this.textBuscadorP.TextChanged += new System.EventHandler(this.textBuscadorP_TextChanged);
            // 
            // ComboCategoriaB
            // 
            this.ComboCategoriaB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCategoriaB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboCategoriaB.FormattingEnabled = true;
            this.ComboCategoriaB.Location = new System.Drawing.Point(358, 24);
            this.ComboCategoriaB.Name = "ComboCategoriaB";
            this.ComboCategoriaB.Size = new System.Drawing.Size(111, 21);
            this.ComboCategoriaB.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Categoria";
            // 
            // FProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ComboCategoriaB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBuscadorP);
            this.Controls.Add(this.DGridProductos);
            this.Controls.Add(this.BEliminarProducto);
            this.Controls.Add(this.BEditarProducto);
            this.Controls.Add(this.BAgregarProducto);
            this.Name = "FProductos";
            this.Size = new System.Drawing.Size(1084, 639);
            ((System.ComponentModel.ISupportInitialize)(this.DGridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGridProductos;
        private System.Windows.Forms.Button BEliminarProducto;
        private System.Windows.Forms.Button BEditarProducto;
        private System.Windows.Forms.Button BAgregarProducto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBuscadorP;
        private System.Windows.Forms.ComboBox ComboCategoriaB;
        private System.Windows.Forms.Label label3;
    }
}
