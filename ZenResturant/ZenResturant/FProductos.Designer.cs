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
            this.DGridProductos = new System.Windows.Forms.DataGridView();
            this.BEliminarProducto = new System.Windows.Forms.Button();
            this.BEditarProducto = new System.Windows.Forms.Button();
            this.BAgregarProducto = new System.Windows.Forms.Button();
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
            this.DGridProductos.Size = new System.Drawing.Size(657, 582);
            this.DGridProductos.TabIndex = 8;
            // 
            // BEliminarProducto
            // 
            this.BEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            // FProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DGridProductos);
            this.Controls.Add(this.BEliminarProducto);
            this.Controls.Add(this.BEditarProducto);
            this.Controls.Add(this.BAgregarProducto);
            this.Name = "FProductos";
            this.Size = new System.Drawing.Size(1084, 639);
            ((System.ComponentModel.ISupportInitialize)(this.DGridProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGridProductos;
        private System.Windows.Forms.Button BEliminarProducto;
        private System.Windows.Forms.Button BEditarProducto;
        private System.Windows.Forms.Button BAgregarProducto;
    }
}
