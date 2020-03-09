namespace WinDataWorkBench
{
    partial class FrmPrincDataWB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincDataWB));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlParameters = new System.Windows.Forms.Panel();
            this.txtQry = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ExecQrytlsStrp = new System.Windows.Forms.ToolStripButton();
            this.CleartlsStrp = new System.Windows.Forms.ToolStripButton();
            this.testtlsStrp = new System.Windows.Forms.ToolStripButton();
            this.ExittlsStrp = new System.Windows.Forms.ToolStripButton();
            this.dgrData = new System.Windows.Forms.DataGridView();
            this.pnlParameters.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlParameters
            // 
            this.pnlParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlParameters.Controls.Add(this.txtQry);
            this.pnlParameters.Location = new System.Drawing.Point(0, 28);
            this.pnlParameters.Name = "pnlParameters";
            this.pnlParameters.Size = new System.Drawing.Size(1083, 280);
            this.pnlParameters.TabIndex = 0;
            // 
            // txtQry
            // 
            this.txtQry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQry.Location = new System.Drawing.Point(6, 5);
            this.txtQry.Multiline = true;
            this.txtQry.Name = "txtQry";
            this.txtQry.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtQry.Size = new System.Drawing.Size(1076, 274);
            this.txtQry.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExecQrytlsStrp,
            this.CleartlsStrp,
            this.testtlsStrp,
            this.ExittlsStrp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1083, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ExecQrytlsStrp
            // 
            this.ExecQrytlsStrp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExecQrytlsStrp.Image = ((System.Drawing.Image)(resources.GetObject("ExecQrytlsStrp.Image")));
            this.ExecQrytlsStrp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExecQrytlsStrp.Name = "ExecQrytlsStrp";
            this.ExecQrytlsStrp.Size = new System.Drawing.Size(23, 22);
            this.ExecQrytlsStrp.Text = "toolStripButton1";
            this.ExecQrytlsStrp.ToolTipText = "Execute Query";
            this.ExecQrytlsStrp.Click += new System.EventHandler(this.ExecQrytlsStrp_Click);
            // 
            // CleartlsStrp
            // 
            this.CleartlsStrp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CleartlsStrp.Image = ((System.Drawing.Image)(resources.GetObject("CleartlsStrp.Image")));
            this.CleartlsStrp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CleartlsStrp.Name = "CleartlsStrp";
            this.CleartlsStrp.Size = new System.Drawing.Size(23, 22);
            this.CleartlsStrp.Text = "Clear SQL";
            this.CleartlsStrp.Click += new System.EventHandler(this.CleartlsStrp_Click);
            // 
            // testtlsStrp
            // 
            this.testtlsStrp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.testtlsStrp.Image = ((System.Drawing.Image)(resources.GetObject("testtlsStrp.Image")));
            this.testtlsStrp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.testtlsStrp.Name = "testtlsStrp";
            this.testtlsStrp.Size = new System.Drawing.Size(23, 22);
            this.testtlsStrp.Text = "Test";
            this.testtlsStrp.Click += new System.EventHandler(this.testtlsStrp_Click);
            // 
            // ExittlsStrp
            // 
            this.ExittlsStrp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExittlsStrp.Image = ((System.Drawing.Image)(resources.GetObject("ExittlsStrp.Image")));
            this.ExittlsStrp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExittlsStrp.Name = "ExittlsStrp";
            this.ExittlsStrp.Size = new System.Drawing.Size(23, 22);
            this.ExittlsStrp.Text = "toolStripButton2";
            this.ExittlsStrp.ToolTipText = "Exit";
            this.ExittlsStrp.Click += new System.EventHandler(this.ExittlsStrp_Click);
            // 
            // dgrData
            // 
            this.dgrData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrData.Location = new System.Drawing.Point(0, 314);
            this.dgrData.Name = "dgrData";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgrData.Size = new System.Drawing.Size(1083, 400);
            this.dgrData.TabIndex = 2;
            // 
            // FrmPrincDataWB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 713);
            this.Controls.Add(this.dgrData);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlParameters);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincDataWB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlParameters.ResumeLayout(false);
            this.pnlParameters.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlParameters;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ExecQrytlsStrp;
        private System.Windows.Forms.ToolStripButton ExittlsStrp;
        private System.Windows.Forms.TextBox txtQry;
        private System.Windows.Forms.DataGridView dgrData;
        private System.Windows.Forms.ToolStripButton CleartlsStrp;
        private System.Windows.Forms.ToolStripButton testtlsStrp;
    }
}

