namespace WinXmlToSqlInvoker
{
    partial class FrmPrincXmlInvoker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincXmlInvoker));
            this.pnlSelector = new System.Windows.Forms.Panel();
            this.butSelFile = new System.Windows.Forms.Button();
            this.fileToProcess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butGenerate = new System.Windows.Forms.Button();
            this.pnlSelector.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSelector
            // 
            this.pnlSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSelector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSelector.Controls.Add(this.butSelFile);
            this.pnlSelector.Controls.Add(this.fileToProcess);
            this.pnlSelector.Controls.Add(this.label1);
            this.pnlSelector.Location = new System.Drawing.Point(2, 1);
            this.pnlSelector.Name = "pnlSelector";
            this.pnlSelector.Size = new System.Drawing.Size(640, 76);
            this.pnlSelector.TabIndex = 4;
            // 
            // butSelFile
            // 
            this.butSelFile.Location = new System.Drawing.Point(433, 30);
            this.butSelFile.Name = "butSelFile";
            this.butSelFile.Size = new System.Drawing.Size(36, 17);
            this.butSelFile.TabIndex = 4;
            this.butSelFile.Text = "button1";
            this.butSelFile.UseVisualStyleBackColor = true;
            this.butSelFile.Click += new System.EventHandler(this.butSelFile_Click);
            // 
            // fileToProcess
            // 
            this.fileToProcess.Location = new System.Drawing.Point(126, 28);
            this.fileToProcess.Name = "fileToProcess";
            this.fileToProcess.Size = new System.Drawing.Size(285, 20);
            this.fileToProcess.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Archivo Xml:";
            // 
            // txtSalida
            // 
            this.txtSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalida.Location = new System.Drawing.Point(12, 83);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSalida.Size = new System.Drawing.Size(630, 413);
            this.txtSalida.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.butGenerate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 86);
            this.panel1.TabIndex = 6;
            // 
            // butGenerate
            // 
            this.butGenerate.Location = new System.Drawing.Point(201, 12);
            this.butGenerate.Name = "butGenerate";
            this.butGenerate.Size = new System.Drawing.Size(206, 62);
            this.butGenerate.TabIndex = 0;
            this.butGenerate.Text = "Generate Call";
            this.butGenerate.UseVisualStyleBackColor = true;
            this.butGenerate.Click += new System.EventHandler(this.butGenerate_Click);
            // 
            // FrmPrincXmlInvoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 586);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.pnlSelector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincXmlInvoker";
            this.Text = "Xml Invoker";
            this.pnlSelector.ResumeLayout(false);
            this.pnlSelector.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSelector;
        private System.Windows.Forms.Button butSelFile;
        private System.Windows.Forms.TextBox fileToProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butGenerate;

    }
}

