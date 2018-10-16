namespace ZenResturant
{
    partial class FInventarios
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
            this.DGridInventarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGridInventarios)).BeginInit();
            this.SuspendLayout();
            // 
            // DGridInventarios
            // 
            this.DGridInventarios.AllowUserToAddRows = false;
            this.DGridInventarios.AllowUserToDeleteRows = false;
            this.DGridInventarios.AllowUserToResizeColumns = false;
            this.DGridInventarios.AllowUserToResizeRows = false;
            this.DGridInventarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGridInventarios.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGridInventarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridInventarios.Location = new System.Drawing.Point(3, 54);
            this.DGridInventarios.Name = "DGridInventarios";
            this.DGridInventarios.ReadOnly = true;
            this.DGridInventarios.RowHeadersWidth = 10;
            this.DGridInventarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGridInventarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGridInventarios.Size = new System.Drawing.Size(657, 582);
            this.DGridInventarios.TabIndex = 5;
            // 
            // FInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DGridInventarios);
            this.Name = "FInventarios";
            this.Size = new System.Drawing.Size(1084, 639);
            ((System.ComponentModel.ISupportInitialize)(this.DGridInventarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGridInventarios;
    }
}
