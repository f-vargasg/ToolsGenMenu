namespace WinCmpFondos
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath1 = new System.Windows.Forms.TextBox();
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtPath1NoPath2 = new System.Windows.Forms.TextBox();
            this.txtPath2NoPath1 = new System.Windows.Forms.TextBox();
            this.butSearchRut1 = new System.Windows.Forms.Button();
            this.butSearchRut2 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlStrpExit = new System.Windows.Forms.ToolStripButton();
            this.tlStrpCmp = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta 1:";
            // 
            // txtPath1
            // 
            this.txtPath1.Location = new System.Drawing.Point(134, 35);
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.Size = new System.Drawing.Size(398, 26);
            this.txtPath1.TabIndex = 1;
            // 
            // txtPath2
            // 
            this.txtPath2.Location = new System.Drawing.Point(134, 67);
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.Size = new System.Drawing.Size(398, 26);
            this.txtPath2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ruta 2:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(2, 146);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtPath1NoPath2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtPath2NoPath1);
            this.splitContainer1.Size = new System.Drawing.Size(829, 501);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 4;
            // 
            // txtPath1NoPath2
            // 
            this.txtPath1NoPath2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath1NoPath2.Location = new System.Drawing.Point(0, 0);
            this.txtPath1NoPath2.Multiline = true;
            this.txtPath1NoPath2.Name = "txtPath1NoPath2";
            this.txtPath1NoPath2.Size = new System.Drawing.Size(829, 226);
            this.txtPath1NoPath2.TabIndex = 2;
            // 
            // txtPath2NoPath1
            // 
            this.txtPath2NoPath1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath2NoPath1.Location = new System.Drawing.Point(0, 0);
            this.txtPath2NoPath1.Multiline = true;
            this.txtPath2NoPath1.Name = "txtPath2NoPath1";
            this.txtPath2NoPath1.Size = new System.Drawing.Size(829, 271);
            this.txtPath2NoPath1.TabIndex = 3;
            // 
            // butSearchRut1
            // 
            this.butSearchRut1.Location = new System.Drawing.Point(559, 34);
            this.butSearchRut1.Name = "butSearchRut1";
            this.butSearchRut1.Size = new System.Drawing.Size(51, 29);
            this.butSearchRut1.TabIndex = 5;
            this.butSearchRut1.Text = "...";
            this.butSearchRut1.UseVisualStyleBackColor = true;
            this.butSearchRut1.Click += new System.EventHandler(this.butSearchRut1_Click);
            // 
            // butSearchRut2
            // 
            this.butSearchRut2.Location = new System.Drawing.Point(559, 66);
            this.butSearchRut2.Name = "butSearchRut2";
            this.butSearchRut2.Size = new System.Drawing.Size(51, 29);
            this.butSearchRut2.TabIndex = 6;
            this.butSearchRut2.Text = "...";
            this.butSearchRut2.UseVisualStyleBackColor = true;
            this.butSearchRut2.Click += new System.EventHandler(this.butSearchRut2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlStrpCmp,
            this.tlStrpExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(825, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlStrpExit
            // 
            this.tlStrpExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStrpExit.Image = ((System.Drawing.Image)(resources.GetObject("tlStrpExit.Image")));
            this.tlStrpExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStrpExit.Name = "tlStrpExit";
            this.tlStrpExit.Size = new System.Drawing.Size(23, 22);
            this.tlStrpExit.Text = "toolStripButton1";
            this.tlStrpExit.ToolTipText = "Exit";
            this.tlStrpExit.Click += new System.EventHandler(this.tlStrpExit_Click);
            // 
            // tlStrpCmp
            // 
            this.tlStrpCmp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStrpCmp.Image = ((System.Drawing.Image)(resources.GetObject("tlStrpCmp.Image")));
            this.tlStrpCmp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStrpCmp.Name = "tlStrpCmp";
            this.tlStrpCmp.Size = new System.Drawing.Size(23, 22);
            this.tlStrpCmp.Text = "toolStripButton2";
            this.tlStrpCmp.ToolTipText = "Compare Directories";
            this.tlStrpCmp.Click += new System.EventHandler(this.tlStrpCmp_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 648);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.butSearchRut2);
            this.Controls.Add(this.butSearchRut1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.txtPath2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPath1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath1;
        private System.Windows.Forms.TextBox txtPath2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button butSearchRut1;
        private System.Windows.Forms.Button butSearchRut2;
        private System.Windows.Forms.TextBox txtPath1NoPath2;
        private System.Windows.Forms.TextBox txtPath2NoPath1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlStrpExit;
        private System.Windows.Forms.ToolStripButton tlStrpCmp;
    }
}

