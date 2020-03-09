namespace GenMenuFrmUI
{
    partial class FrmPrincXmlInvoker
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.butGenerate = new System.Windows.Forms.Button();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.pnlSelector = new System.Windows.Forms.Panel();
            this.butSelFile = new System.Windows.Forms.Button();
            this.fileToProcess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlSelector.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.butGenerate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 564);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 105);
            this.panel1.TabIndex = 9;
            // 
            // butGenerate
            // 
            this.butGenerate.Location = new System.Drawing.Point(268, 15);
            this.butGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.butGenerate.Name = "butGenerate";
            this.butGenerate.Size = new System.Drawing.Size(275, 76);
            this.butGenerate.TabIndex = 0;
            this.butGenerate.Text = "Generate Call";
            this.butGenerate.UseVisualStyleBackColor = true;
            // 
            // txtSalida
            // 
            this.txtSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalida.Location = new System.Drawing.Point(16, 101);
            this.txtSalida.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSalida.Size = new System.Drawing.Size(901, 455);
            this.txtSalida.TabIndex = 8;
            // 
            // pnlSelector
            // 
            this.pnlSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSelector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSelector.Controls.Add(this.butSelFile);
            this.pnlSelector.Controls.Add(this.fileToProcess);
            this.pnlSelector.Controls.Add(this.label1);
            this.pnlSelector.Location = new System.Drawing.Point(3, 0);
            this.pnlSelector.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSelector.Name = "pnlSelector";
            this.pnlSelector.Size = new System.Drawing.Size(914, 93);
            this.pnlSelector.TabIndex = 7;
            // 
            // butSelFile
            // 
            this.butSelFile.Location = new System.Drawing.Point(577, 37);
            this.butSelFile.Margin = new System.Windows.Forms.Padding(4);
            this.butSelFile.Name = "butSelFile";
            this.butSelFile.Size = new System.Drawing.Size(48, 21);
            this.butSelFile.TabIndex = 4;
            this.butSelFile.Text = "button1";
            this.butSelFile.UseVisualStyleBackColor = true;
            // 
            // fileToProcess
            // 
            this.fileToProcess.Location = new System.Drawing.Point(168, 34);
            this.fileToProcess.Margin = new System.Windows.Forms.Padding(4);
            this.fileToProcess.Name = "fileToProcess";
            this.fileToProcess.Size = new System.Drawing.Size(379, 22);
            this.fileToProcess.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Archivo Xml:";
            // 
            // FrmPrincXmlInvoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 669);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.pnlSelector);
            this.Name = "FrmPrincXmlInvoker";
            this.Text = "FrmPrincXmlInvoker";
            this.panel1.ResumeLayout(false);
            this.pnlSelector.ResumeLayout(false);
            this.pnlSelector.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butGenerate;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Panel pnlSelector;
        private System.Windows.Forms.Button butSelFile;
        private System.Windows.Forms.TextBox fileToProcess;
        private System.Windows.Forms.Label label1;
    }
}