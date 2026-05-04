namespace pryManasseroFerro
{
    partial class frmOrganizacionferro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrganizacionferro));
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblDiasEstadia = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.numDias = new System.Windows.Forms.NumericUpDown();
            this.grpBoletos = new System.Windows.Forms.GroupBox();
            this.pMostrar = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.distancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).BeginInit();
            this.grpBoletos.SuspendLayout();
            this.pMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistancia.Location = new System.Drawing.Point(3, 29);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(93, 17);
            this.lblDistancia.TabIndex = 1;
            this.lblDistancia.Text = "Distancia (km):";
            // 
            // lblDiasEstadia
            // 
            this.lblDiasEstadia.AutoSize = true;
            this.lblDiasEstadia.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasEstadia.Location = new System.Drawing.Point(3, 66);
            this.lblDiasEstadia.Name = "lblDiasEstadia";
            this.lblDiasEstadia.Size = new System.Drawing.Size(101, 17);
            this.lblDiasEstadia.TabIndex = 2;
            this.lblDiasEstadia.Text = "Días de estadía:";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(107, 29);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(121, 20);
            this.txtDistancia.TabIndex = 5;
            this.txtDistancia.TextChanged += new System.EventHandler(this.txtDistancia_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(152, 110);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // numDias
            // 
            this.numDias.Location = new System.Drawing.Point(107, 66);
            this.numDias.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDias.Name = "numDias";
            this.numDias.Size = new System.Drawing.Size(120, 20);
            this.numDias.TabIndex = 8;
            this.numDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpBoletos
            // 
            this.grpBoletos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpBoletos.Controls.Add(this.txtDistancia);
            this.grpBoletos.Controls.Add(this.lblDistancia);
            this.grpBoletos.Controls.Add(this.numDias);
            this.grpBoletos.Controls.Add(this.btnCalcular);
            this.grpBoletos.Controls.Add(this.lblDiasEstadia);
            this.grpBoletos.Location = new System.Drawing.Point(12, 12);
            this.grpBoletos.Name = "grpBoletos";
            this.grpBoletos.Size = new System.Drawing.Size(234, 143);
            this.grpBoletos.TabIndex = 10;
            this.grpBoletos.TabStop = false;
            this.grpBoletos.Text = "Boletos";
            // 
            // pMostrar
            // 
            this.pMostrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pMostrar.Controls.Add(this.dataGridView1);
            this.pMostrar.Location = new System.Drawing.Point(252, 12);
            this.pMostrar.Name = "pMostrar";
            this.pMostrar.Size = new System.Drawing.Size(345, 143);
            this.pMostrar.TabIndex = 11;
            this.pMostrar.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.distancia,
            this.dias,
            this.precio});
            this.dataGridView1.Location = new System.Drawing.Point(3, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(339, 123);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // distancia
            // 
            this.distancia.HeaderText = "Distancia";
            this.distancia.Name = "distancia";
            // 
            // dias
            // 
            this.dias.HeaderText = "Días de estadia ";
            this.dias.Name = "dias";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // frmOrganizacionferro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(609, 169);
            this.Controls.Add(this.pMostrar);
            this.Controls.Add(this.grpBoletos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrganizacionferro";
            this.Text = "Organización Ferro";
            this.Load += new System.EventHandler(this.frmOrganizacionferro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).EndInit();
            this.grpBoletos.ResumeLayout(false);
            this.grpBoletos.PerformLayout();
            this.pMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblDiasEstadia;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.NumericUpDown numDias;
        private System.Windows.Forms.GroupBox grpBoletos;
        private System.Windows.Forms.Panel pMostrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn distancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
    }
}

