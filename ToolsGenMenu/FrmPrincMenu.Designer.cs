namespace ToolsGenMenu
{
    partial class FrmPrincMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincMenu));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.xmlTrv = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ExitTlStrp = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(-4, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.xmlTrv);
            this.splitContainer1.Size = new System.Drawing.Size(1211, 583);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.TabIndex = 0;
            // 
            // xmlTrv
            // 
            this.xmlTrv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xmlTrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xmlTrv.Location = new System.Drawing.Point(0, 0);
            this.xmlTrv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xmlTrv.Name = "xmlTrv";
            this.xmlTrv.Size = new System.Drawing.Size(287, 583);
            this.xmlTrv.TabIndex = 0;
            this.xmlTrv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.xmlTrv_AfterSelect);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitTlStrp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1207, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ExitTlStrp
            // 
            this.ExitTlStrp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExitTlStrp.Image = ((System.Drawing.Image)(resources.GetObject("ExitTlStrp.Image")));
            this.ExitTlStrp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitTlStrp.Name = "ExitTlStrp";
            this.ExitTlStrp.Size = new System.Drawing.Size(24, 24);
            this.ExitTlStrp.Text = "toolStripButton1";
            this.ExitTlStrp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ExitTlStrp.ToolTipText = "Salir";
            this.ExitTlStrp.Click += new System.EventHandler(this.ExitTlStrp_Click);
            // 
            // FrmPrincMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 611);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shell";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView xmlTrv;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ExitTlStrp;
    }
}

