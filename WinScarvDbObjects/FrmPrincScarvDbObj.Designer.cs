namespace WinScarvDbObjects
{
    partial class FrmPrincScarvDbObj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincScarvDbObj));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlsStrExit = new System.Windows.Forms.ToolStripButton();
            this.tlsStrProcess = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDbObjName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtPathToSave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butGetPath = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsStrExit,
            this.tlsStrProcess});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1107, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlsStrExit
            // 
            this.tlsStrExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsStrExit.Image = ((System.Drawing.Image)(resources.GetObject("tlsStrExit.Image")));
            this.tlsStrExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsStrExit.Name = "tlsStrExit";
            this.tlsStrExit.Size = new System.Drawing.Size(23, 22);
            this.tlsStrExit.Text = "toolStripButton1";
            this.tlsStrExit.ToolTipText = "Salir";
            this.tlsStrExit.Click += new System.EventHandler(this.tlsStrExit_Click);
            // 
            // tlsStrProcess
            // 
            this.tlsStrProcess.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsStrProcess.Image = ((System.Drawing.Image)(resources.GetObject("tlsStrProcess.Image")));
            this.tlsStrProcess.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsStrProcess.Name = "tlsStrProcess";
            this.tlsStrProcess.Size = new System.Drawing.Size(23, 22);
            this.tlsStrProcess.Text = "toolStripButton2";
            this.tlsStrProcess.ToolTipText = "Process";
            this.tlsStrProcess.Click += new System.EventHandler(this.tlsStrProcess_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.butGetPath);
            this.panel1.Controls.Add(this.txtPathToSave);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtOwner);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDbObjName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 171);
            this.panel1.TabIndex = 1;
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(139, 52);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(496, 26);
            this.txtOwner.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Owner:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(139, 84);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(496, 26);
            this.txtType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type:";
            // 
            // txtDbObjName
            // 
            this.txtDbObjName.Location = new System.Drawing.Point(139, 120);
            this.txtDbObjName.Name = "txtDbObjName";
            this.txtDbObjName.Size = new System.Drawing.Size(496, 26);
            this.txtDbObjName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Objeto DB:";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(0, 222);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(1095, 413);
            this.txtResult.TabIndex = 2;
            // 
            // txtPathToSave
            // 
            this.txtPathToSave.Location = new System.Drawing.Point(139, 20);
            this.txtPathToSave.Name = "txtPathToSave";
            this.txtPathToSave.Size = new System.Drawing.Size(496, 26);
            this.txtPathToSave.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Path to Save:";
            // 
            // butGetPath
            // 
            this.butGetPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGetPath.Location = new System.Drawing.Point(654, 23);
            this.butGetPath.Name = "butGetPath";
            this.butGetPath.Size = new System.Drawing.Size(63, 24);
            this.butGetPath.TabIndex = 8;
            this.butGetPath.Text = "...";
            this.butGetPath.UseVisualStyleBackColor = true;
            // 
            // FrmPrincScarvDbObj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 637);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincScarvDbObj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlsStrExit;
        private System.Windows.Forms.ToolStripButton tlsStrProcess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDbObjName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butGetPath;
        private System.Windows.Forms.TextBox txtPathToSave;
        private System.Windows.Forms.Label label4;
    }
}

