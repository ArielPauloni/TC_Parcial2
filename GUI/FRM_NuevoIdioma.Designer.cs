namespace GUI
{
    partial class FRM_NuevoIdioma
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
            this.lblCodIdioma = new System.Windows.Forms.Label();
            this.lblDescripcionIdioma = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtCodIdioma = new System.Windows.Forms.TextBox();
            this.txtDescripcionIdioma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCodIdioma
            // 
            this.lblCodIdioma.AutoSize = true;
            this.lblCodIdioma.Location = new System.Drawing.Point(13, 19);
            this.lblCodIdioma.Name = "lblCodIdioma";
            this.lblCodIdioma.Size = new System.Drawing.Size(63, 13);
            this.lblCodIdioma.TabIndex = 0;
            this.lblCodIdioma.Text = "-Cod Idioma";
            // 
            // lblDescripcionIdioma
            // 
            this.lblDescripcionIdioma.AutoSize = true;
            this.lblDescripcionIdioma.Location = new System.Drawing.Point(13, 51);
            this.lblDescripcionIdioma.Name = "lblDescripcionIdioma";
            this.lblDescripcionIdioma.Size = new System.Drawing.Size(97, 13);
            this.lblDescripcionIdioma.TabIndex = 1;
            this.lblDescripcionIdioma.Text = "-descripcion idioma";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(197, 76);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 2;
            this.btnGrabar.Text = "-grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtCodIdioma
            // 
            this.txtCodIdioma.Location = new System.Drawing.Point(158, 12);
            this.txtCodIdioma.MaxLength = 2;
            this.txtCodIdioma.Name = "txtCodIdioma";
            this.txtCodIdioma.Size = new System.Drawing.Size(114, 20);
            this.txtCodIdioma.TabIndex = 3;
            // 
            // txtDescripcionIdioma
            // 
            this.txtDescripcionIdioma.Location = new System.Drawing.Point(158, 44);
            this.txtDescripcionIdioma.Name = "txtDescripcionIdioma";
            this.txtDescripcionIdioma.Size = new System.Drawing.Size(114, 20);
            this.txtDescripcionIdioma.TabIndex = 4;
            // 
            // FRM_NuevoIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.txtDescripcionIdioma);
            this.Controls.Add(this.txtCodIdioma);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.lblDescripcionIdioma);
            this.Controls.Add(this.lblCodIdioma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_NuevoIdioma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_NuevoIdioma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_NuevoIdioma_FormClosing);
            this.Load += new System.EventHandler(this.FRM_NuevoIdioma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodIdioma;
        private System.Windows.Forms.Label lblDescripcionIdioma;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtCodIdioma;
        private System.Windows.Forms.TextBox txtDescripcionIdioma;
    }
}