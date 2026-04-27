namespace pryManasseroFerro
{
    partial class frmCarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarga));
            this.lblDatosElegidos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDatosElegidos
            // 
            this.lblDatosElegidos.AutoSize = true;
            this.lblDatosElegidos.Location = new System.Drawing.Point(114, 19);
            this.lblDatosElegidos.Name = "lblDatosElegidos";
            this.lblDatosElegidos.Size = new System.Drawing.Size(77, 13);
            this.lblDatosElegidos.TabIndex = 0;
            this.lblDatosElegidos.Text = "Datos elegidos";
            // 
            // frmCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(293, 236);
            this.Controls.Add(this.lblDatosElegidos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCarga";
            this.Text = "Carga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosElegidos;
    }
}