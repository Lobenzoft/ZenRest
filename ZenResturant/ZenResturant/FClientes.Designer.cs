namespace ZenResturant
{
    partial class FClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FClientes));
            this.BAgregarCliente = new System.Windows.Forms.Button();
            this.BEditarCliente = new System.Windows.Forms.Button();
            this.BEliminarCliente = new System.Windows.Forms.Button();
            this.DGridClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // BAgregarCliente
            // 
            this.BAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BAgregarCliente.Image")));
            this.BAgregarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAgregarCliente.Location = new System.Drawing.Point(3, 3);
            this.BAgregarCliente.Name = "BAgregarCliente";
            this.BAgregarCliente.Size = new System.Drawing.Size(110, 45);
            this.BAgregarCliente.TabIndex = 1;
            this.BAgregarCliente.TabStop = false;
            this.BAgregarCliente.Text = "Agregar";
            this.BAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAgregarCliente.UseVisualStyleBackColor = true;
            this.BAgregarCliente.Click += new System.EventHandler(this.BAgregarCliente_Click);
            // 
            // BEditarCliente
            // 
            this.BEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEditarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BEditarCliente.Image")));
            this.BEditarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEditarCliente.Location = new System.Drawing.Point(119, 3);
            this.BEditarCliente.Name = "BEditarCliente";
            this.BEditarCliente.Size = new System.Drawing.Size(110, 45);
            this.BEditarCliente.TabIndex = 2;
            this.BEditarCliente.TabStop = false;
            this.BEditarCliente.Text = "Editar";
            this.BEditarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEditarCliente.UseVisualStyleBackColor = true;
            this.BEditarCliente.Click += new System.EventHandler(this.BEditarCliente_Click);
            // 
            // BEliminarCliente
            // 
            this.BEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEliminarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BEliminarCliente.Image")));
            this.BEliminarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEliminarCliente.Location = new System.Drawing.Point(235, 3);
            this.BEliminarCliente.Name = "BEliminarCliente";
            this.BEliminarCliente.Size = new System.Drawing.Size(110, 45);
            this.BEliminarCliente.TabIndex = 3;
            this.BEliminarCliente.TabStop = false;
            this.BEliminarCliente.Text = "Eliminar";
            this.BEliminarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEliminarCliente.UseVisualStyleBackColor = true;
            this.BEliminarCliente.Click += new System.EventHandler(this.BEliminarCliente_Click);
            // 
            // DGridClientes
            // 
            this.DGridClientes.AllowUserToAddRows = false;
            this.DGridClientes.AllowUserToDeleteRows = false;
            this.DGridClientes.AllowUserToResizeColumns = false;
            this.DGridClientes.AllowUserToResizeRows = false;
            this.DGridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGridClientes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridClientes.Location = new System.Drawing.Point(3, 54);
            this.DGridClientes.Name = "DGridClientes";
            this.DGridClientes.ReadOnly = true;
            this.DGridClientes.RowHeadersWidth = 10;
            this.DGridClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGridClientes.Size = new System.Drawing.Size(657, 582);
            this.DGridClientes.TabIndex = 4;
            // 
            // FClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.DGridClientes);
            this.Controls.Add(this.BEliminarCliente);
            this.Controls.Add(this.BEditarCliente);
            this.Controls.Add(this.BAgregarCliente);
            this.Name = "FClientes";
            this.Size = new System.Drawing.Size(1084, 639);
            ((System.ComponentModel.ISupportInitialize)(this.DGridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BAgregarCliente;
        private System.Windows.Forms.Button BEditarCliente;
        private System.Windows.Forms.Button BEliminarCliente;
        private System.Windows.Forms.DataGridView DGridClientes;
    }
}
