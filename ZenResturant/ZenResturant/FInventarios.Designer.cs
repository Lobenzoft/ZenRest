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
            this.ComboCategoriaBIn = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBuscadorIn = new System.Windows.Forms.TextBox();
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
            this.DGridInventarios.Location = new System.Drawing.Point(3, 70);
            this.DGridInventarios.Name = "DGridInventarios";
            this.DGridInventarios.ReadOnly = true;
            this.DGridInventarios.RowHeadersWidth = 10;
            this.DGridInventarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGridInventarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGridInventarios.Size = new System.Drawing.Size(792, 566);
            this.DGridInventarios.TabIndex = 5;
            // 
            // ComboCategoriaBIn
            // 
            this.ComboCategoriaBIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCategoriaBIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboCategoriaBIn.FormattingEnabled = true;
            this.ComboCategoriaBIn.Location = new System.Drawing.Point(457, 27);
            this.ComboCategoriaBIn.Name = "ComboCategoriaBIn";
            this.ComboCategoriaBIn.Size = new System.Drawing.Size(111, 21);
            this.ComboCategoriaBIn.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Categoria";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(609, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "BUSCAR";
            // 
            // textBuscadorIn
            // 
            this.textBuscadorIn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBuscadorIn.Location = new System.Drawing.Point(666, 19);
            this.textBuscadorIn.Name = "textBuscadorIn";
            this.textBuscadorIn.Size = new System.Drawing.Size(128, 20);
            this.textBuscadorIn.TabIndex = 32;
            this.textBuscadorIn.TextChanged += new System.EventHandler(this.textBuscadorIn_TextChanged);
            // 
            // FInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ComboCategoriaBIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBuscadorIn);
            this.Controls.Add(this.DGridInventarios);
            this.Name = "FInventarios";
            this.Size = new System.Drawing.Size(1084, 639);
            ((System.ComponentModel.ISupportInitialize)(this.DGridInventarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGridInventarios;
        private System.Windows.Forms.ComboBox ComboCategoriaBIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBuscadorIn;
    }
}
