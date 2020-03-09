namespace WinConsCatalogoSabNet
{
    partial class FrmPrincConsCatSabNet
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincConsCatSabNet));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tstButExit = new System.Windows.Forms.ToolStripButton();
            this.tstButFind = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNom_Servicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDes_invocador = new System.Windows.Forms.TextBox();
            this.dgrData = new System.Windows.Forms.DataGridView();
            this.chkBoxLike = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrData)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstButExit,
            this.tstButFind});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1200, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tstButExit
            // 
            this.tstButExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstButExit.Image = ((System.Drawing.Image)(resources.GetObject("tstButExit.Image")));
            this.tstButExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstButExit.Name = "tstButExit";
            this.tstButExit.Size = new System.Drawing.Size(23, 22);
            this.tstButExit.Text = "toolStripButton1";
            this.tstButExit.ToolTipText = "Salir";
            this.tstButExit.Click += new System.EventHandler(this.tstButExit_Click);
            // 
            // tstButFind
            // 
            this.tstButFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstButFind.Image = ((System.Drawing.Image)(resources.GetObject("tstButFind.Image")));
            this.tstButFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstButFind.Name = "tstButFind";
            this.tstButFind.Size = new System.Drawing.Size(23, 22);
            this.tstButFind.Text = "Buscar";
            this.tstButFind.Click += new System.EventHandler(this.tstButFind_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.chkBoxLike);
            this.panel1.Controls.Add(this.txtNom_Servicio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 86);
            this.panel1.TabIndex = 1;
            // 
            // txtNom_Servicio
            // 
            this.txtNom_Servicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom_Servicio.Location = new System.Drawing.Point(136, 8);
            this.txtNom_Servicio.Name = "txtNom_Servicio";
            this.txtNom_Servicio.Size = new System.Drawing.Size(342, 26);
            this.txtNom_Servicio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod.Servicio:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txtDes_invocador);
            this.panel2.Controls.Add(this.dgrData);
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 496);
            this.panel2.TabIndex = 2;
            // 
            // txtDes_invocador
            // 
            this.txtDes_invocador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDes_invocador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes_invocador.Location = new System.Drawing.Point(3, 155);
            this.txtDes_invocador.Multiline = true;
            this.txtDes_invocador.Name = "txtDes_invocador";
            this.txtDes_invocador.Size = new System.Drawing.Size(1194, 338);
            this.txtDes_invocador.TabIndex = 2;
            // 
            // dgrData
            // 
            this.dgrData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrData.Location = new System.Drawing.Point(3, 4);
            this.dgrData.Name = "dgrData";
            this.dgrData.Size = new System.Drawing.Size(1194, 145);
            this.dgrData.TabIndex = 0;
            this.dgrData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // chkBoxLike
            // 
            this.chkBoxLike.AutoSize = true;
            this.chkBoxLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxLike.Location = new System.Drawing.Point(558, 7);
            this.chkBoxLike.Name = "chkBoxLike";
            this.chkBoxLike.Size = new System.Drawing.Size(171, 24);
            this.chkBoxLike.TabIndex = 2;
            this.chkBoxLike.Text = "Busqueda Compleja";
            this.chkBoxLike.UseVisualStyleBackColor = true;
            // 
            // FrmPrincConsCatSabNet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincConsCatSabNet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sab.net Catalog Browser";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tstButExit;
        private System.Windows.Forms.ToolStripButton tstButFind;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNom_Servicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDes_invocador;
        private System.Windows.Forms.DataGridView dgrData;
        private System.Windows.Forms.CheckBox chkBoxLike;
    }
}

