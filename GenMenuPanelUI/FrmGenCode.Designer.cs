namespace GenMenuFrmUI
{
    partial class FrmGenCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenCode));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlStrExecSql = new System.Windows.Forms.ToolStripButton();
            this.tlStrSalir = new System.Windows.Forms.ToolStripButton();
            this.pnlParams = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMethodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEsquema = new System.Windows.Forms.ComboBox();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTargetLang = new System.Windows.Forms.ComboBox();
            this.txtCodeRes = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.pnlParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlStrExecSql,
            this.tlStrSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1109, 27);
            this.toolStrip1.TabIndex = 12;
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
            this.pnlParams.Location = new System.Drawing.Point(4, 31);
            this.pnlParams.Margin = new System.Windows.Forms.Padding(4);
            this.pnlParams.Name = "pnlParams";
            this.pnlParams.Size = new System.Drawing.Size(1097, 182);
            this.pnlParams.TabIndex = 10;
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
            this.txtMethodName.Margin = new System.Windows.Forms.Padding(4);
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
            "SAB_CUS"});
            this.cmbEsquema.Location = new System.Drawing.Point(172, 12);
            this.cmbEsquema.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEsquema.Name = "cmbEsquema";
            this.cmbEsquema.Size = new System.Drawing.Size(348, 33);
            this.cmbEsquema.TabIndex = 3;
            // 
            // txtPackageName
            // 
            this.txtPackageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageName.Location = new System.Drawing.Point(172, 57);
            this.txtPackageName.Margin = new System.Windows.Forms.Padding(4);
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
            this.cmbTargetLang.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTargetLang.Name = "cmbTargetLang";
            this.cmbTargetLang.Size = new System.Drawing.Size(348, 33);
            this.cmbTargetLang.TabIndex = 0;
            // 
            // txtCodeRes
            // 
            this.txtCodeRes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodeRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeRes.Location = new System.Drawing.Point(4, 221);
            this.txtCodeRes.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodeRes.Multiline = true;
            this.txtCodeRes.Name = "txtCodeRes";
            this.txtCodeRes.Size = new System.Drawing.Size(1088, 319);
            this.txtCodeRes.TabIndex = 11;
            // 
            // FrmGenCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 542);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlParams);
            this.Controls.Add(this.txtCodeRes);
            this.Name = "FrmGenCode";
            this.Text = "FrmGenCode";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlParams.ResumeLayout(false);
            this.pnlParams.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlStrExecSql;
        private System.Windows.Forms.ToolStripButton tlStrSalir;
        private System.Windows.Forms.Panel pnlParams;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMethodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEsquema;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTargetLang;
        private System.Windows.Forms.TextBox txtCodeRes;

    }
}