namespace GUI
{
    partial class FRM_AcercaDe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblRealizadoPor = new System.Windows.Forms.Label();
            this.txtTextoAMostrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "-fecha";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(185, 9);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(97, 13);
            this.lblMateria.TabIndex = 1;
            this.lblMateria.Text = "-Trabajo de Campo";
            // 
            // lblRealizadoPor
            // 
            this.lblRealizadoPor.AutoSize = true;
            this.lblRealizadoPor.Location = new System.Drawing.Point(12, 136);
            this.lblRealizadoPor.Name = "lblRealizadoPor";
            this.lblRealizadoPor.Size = new System.Drawing.Size(70, 13);
            this.lblRealizadoPor.TabIndex = 2;
            this.lblRealizadoPor.Text = "-realizado por";
            // 
            // txtTextoAMostrar
            // 
            this.txtTextoAMostrar.Enabled = false;
            this.txtTextoAMostrar.Location = new System.Drawing.Point(12, 25);
            this.txtTextoAMostrar.Multiline = true;
            this.txtTextoAMostrar.Name = "txtTextoAMostrar";
            this.txtTextoAMostrar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTextoAMostrar.Size = new System.Drawing.Size(360, 108);
            this.txtTextoAMostrar.TabIndex = 3;
            // 
            // FRM_AcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.txtTextoAMostrar);
            this.Controls.Add(this.lblRealizadoPor);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_AcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_AcercaDe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_AcercaDe_FormClosing);
            this.Load += new System.EventHandler(this.FRM_AcercaDe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblRealizadoPor;
        private System.Windows.Forms.TextBox txtTextoAMostrar;
    }
}