namespace GUI
{
    partial class FRM_Principal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboIdioma = new System.Windows.Forms.ComboBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.btnCrearIdioma = new System.Windows.Forms.Button();
            this.llblAcercaDe = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cboIdioma
            // 
            this.cboIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdioma.FormattingEnabled = true;
            this.cboIdioma.Location = new System.Drawing.Point(113, 13);
            this.cboIdioma.Name = "cboIdioma";
            this.cboIdioma.Size = new System.Drawing.Size(159, 21);
            this.cboIdioma.TabIndex = 0;
            this.cboIdioma.SelectedIndexChanged += new System.EventHandler(this.cboIdioma_SelectedIndexChanged);
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(12, 13);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(41, 13);
            this.lblIdioma.TabIndex = 1;
            this.lblIdioma.Text = "-Idioma";
            // 
            // btnCrearIdioma
            // 
            this.btnCrearIdioma.Location = new System.Drawing.Point(15, 57);
            this.btnCrearIdioma.Name = "btnCrearIdioma";
            this.btnCrearIdioma.Size = new System.Drawing.Size(257, 23);
            this.btnCrearIdioma.TabIndex = 2;
            this.btnCrearIdioma.Text = "-Crear nuevo idioma";
            this.btnCrearIdioma.UseVisualStyleBackColor = true;
            this.btnCrearIdioma.Click += new System.EventHandler(this.btnCrearIdioma_Click);
            // 
            // llblAcercaDe
            // 
            this.llblAcercaDe.AutoSize = true;
            this.llblAcercaDe.Location = new System.Drawing.Point(217, 89);
            this.llblAcercaDe.Name = "llblAcercaDe";
            this.llblAcercaDe.Size = new System.Drawing.Size(58, 13);
            this.llblAcercaDe.TabIndex = 3;
            this.llblAcercaDe.TabStop = true;
            this.llblAcercaDe.Text = "-acerca de";
            this.llblAcercaDe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblAcercaDe_LinkClicked);
            // 
            // FRM_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.llblAcercaDe);
            this.Controls.Add(this.btnCrearIdioma);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.cboIdioma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-Segundo Parcial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Principal_FormClosing);
            this.Load += new System.EventHandler(this.FRM_Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboIdioma;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Button btnCrearIdioma;
        private System.Windows.Forms.LinkLabel llblAcercaDe;
    }
}

