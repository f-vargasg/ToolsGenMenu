namespace WinXmlToSqlInvoker
{
    partial class FrnPrincGenCall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrnPrincGenCall));
            this.pnlParams = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMethodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEsquema = new System.Windows.Forms.ComboBox();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTargetLang = new System.Windows.Forms.ComboBox();
            this.pnlRes = new System.Windows.Forms.Panel();
            this.txtCodeRes = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlStrExecSql = new System.Windows.Forms.ToolStripButton();
            this.tlStrSalir = new System.Windows.Forms.ToolStripButton();
            this.pnlParams.SuspendLayout();
            this.pnlRes.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlParams
            // 
            this.pnlParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlParams.Controls.Add(this.label4);
            this.pnlParams.Controls.Add(this.label3);
            this.pnlParams.Controls.Add(this.txtMethodName);
            this.pnlParams.Controls.Add(this.label2);
            this.pnlParams.Controls.Add(this.cmbEsquema);
            this.pnlParams.Controls.Add(this.txtPackageName);
            this.pnlParams.Controls.Add(this.label1);
            this.pnlParams.Controls.Add(this.cmbTargetLang);
            this.pnlParams.Location = new System.Drawing.Point(0, 34);
            this.pnlParams.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlParams.Name = "pnlParams";
            this.pnlParams.Size = new System.Drawing.Size(1097, 182);
            this.pnlParams.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Source Dest:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Esquema:";
            // 
            // txtMethodName
            // 
            this.txtMethodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMethodName.Location = new System.Drawing.Point(172, 96);
            this.txtMethodName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMethodName.Name = "txtMethodName";
            this.txtMethodName.Size = new System.Drawing.Size(303, 30);
            this.txtMethodName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Method:";
            // 
            // cmbEsquema
            // 
            this.cmbEsquema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEsquema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEsquema.FormattingEnabled = true;
            this.cmbEsquema.Items.AddRange(new object[] {
            "SAB",
            "SAB_NET",
            "PSI",
            "SAB_CUS",
            "MYTEST"});
            this.cmbEsquema.Location = new System.Drawing.Point(172, 12);
            this.cmbEsquema.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEsquema.Name = "cmbEsquema";
            this.cmbEsquema.Size = new System.Drawing.Size(348, 33);
            this.cmbEsquema.TabIndex = 3;
            // 
            // txtPackageName
            // 
            this.txtPackageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageName.Location = new System.Drawing.Point(172, 57);
            this.txtPackageName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(303, 30);
            this.txtPackageName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Package:";
            // 
            // cmbTargetLang
            // 
            this.cmbTargetLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTargetLang.FormattingEnabled = true;
            this.cmbTargetLang.Items.AddRange(new object[] {
            "C#",
            "PL/SQL"});
            this.cmbTargetLang.Location = new System.Drawing.Point(172, 135);
            this.cmbTargetLang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTargetLang.Name = "cmbTargetLang";
            this.cmbTargetLang.Size = new System.Drawing.Size(348, 33);
            this.cmbTargetLang.TabIndex = 0;
            // 
            // pnlRes
            // 
            this.pnlRes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRes.Controls.Add(this.txtCodeRes);
            this.pnlRes.Location = new System.Drawing.Point(0, 224);
            this.pnlRes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRes.Name = "pnlRes";
            this.pnlRes.Size = new System.Drawing.Size(1097, 370);
            this.pnlRes.TabIndex = 1;
            // 
            // txtCodeRes
            // 
            this.txtCodeRes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodeRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeRes.Location = new System.Drawing.Point(4, 4);
            this.txtCodeRes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodeRes.Multiline = true;
            this.txtCodeRes.Name = "txtCodeRes";
            this.txtCodeRes.Size = new System.Drawing.Size(1088, 366);
            this.txtCodeRes.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlStrExecSql,
            this.tlStrSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1093, 27);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlStrExecSql
            // 
            this.tlStrExecSql.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStrExecSql.Image = ((System.Drawing.Image)(resources.GetObject("tlStrExecSql.Image")));
            this.tlStrExecSql.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStrExecSql.Name = "tlStrExecSql";
            this.tlStrExecSql.Size = new System.Drawing.Size(24, 24);
            this.tlStrExecSql.Text = "toolStripButton1";
            this.tlStrExecSql.ToolTipText = "Execute SQL";
            this.tlStrExecSql.Click += new System.EventHandler(this.tlStrExecSql_Click);
            // 
            // tlStrSalir
            // 
            this.tlStrSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStrSalir.Image = ((System.Drawing.Image)(resources.GetObject("tlStrSalir.Image")));
            this.tlStrSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStrSalir.Name = "tlStrSalir";
            this.tlStrSalir.Size = new System.Drawing.Size(24, 24);
            this.tlStrSalir.Text = "toolStripButton1";
            this.tlStrSalir.ToolTipText = "Salir";
            this.tlStrSalir.Visible = false;
            this.tlStrSalir.Click += new System.EventHandler(this.tlStrSalir_Click);
            // 
            // FrnPrincGenCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 597);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlRes);
            this.Controls.Add(this.pnlParams);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrnPrincGenCall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generador Invocador Llamados";
            this.pnlParams.ResumeLayout(false);
            this.pnlParams.PerformLayout();
            this.pnlRes.ResumeLayout(false);
            this.pnlRes.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlParams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTargetLang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMethodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEsquema;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.Panel pnlRes;
        private System.Windows.Forms.TextBox txtCodeRes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlStrExecSql;
        private System.Windows.Forms.ToolStripButton tlStrSalir;
    }
}

