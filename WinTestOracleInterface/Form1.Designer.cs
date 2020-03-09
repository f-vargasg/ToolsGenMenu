namespace WinTestOracleInterface
{
    partial class Form1
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
            this.butExecSp = new System.Windows.Forms.Button();
            this.butOnlyFunction = new System.Windows.Forms.Button();
            this.butObtCallCSharp = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.butObtServiceInvoker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butExecSp
            // 
            this.butExecSp.Location = new System.Drawing.Point(693, 2);
            this.butExecSp.Name = "butExecSp";
            this.butExecSp.Size = new System.Drawing.Size(176, 76);
            this.butExecSp.TabIndex = 9;
            this.butExecSp.Text = "CargarDatos";
            this.butExecSp.UseVisualStyleBackColor = true;
            this.butExecSp.Click += new System.EventHandler(this.butExecSp_Click);
            // 
            // butOnlyFunction
            // 
            this.butOnlyFunction.Location = new System.Drawing.Point(474, 2);
            this.butOnlyFunction.Name = "butOnlyFunction";
            this.butOnlyFunction.Size = new System.Drawing.Size(176, 76);
            this.butOnlyFunction.TabIndex = 8;
            this.butOnlyFunction.Text = "ObtValor";
            this.butOnlyFunction.UseVisualStyleBackColor = true;
            this.butOnlyFunction.Click += new System.EventHandler(this.butOnlyFunction_Click);
            // 
            // butObtCallCSharp
            // 
            this.butObtCallCSharp.Location = new System.Drawing.Point(227, 2);
            this.butObtCallCSharp.Name = "butObtCallCSharp";
            this.butObtCallCSharp.Size = new System.Drawing.Size(176, 76);
            this.butObtCallCSharp.TabIndex = 7;
            this.butObtCallCSharp.Text = "ObtCallCSharp";
            this.butObtCallCSharp.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(-15, 138);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(1043, 524);
            this.txtOutput.TabIndex = 6;
            // 
            // butObtServiceInvoker
            // 
            this.butObtServiceInvoker.Location = new System.Drawing.Point(1, 2);
            this.butObtServiceInvoker.Name = "butObtServiceInvoker";
            this.butObtServiceInvoker.Size = new System.Drawing.Size(176, 76);
            this.butObtServiceInvoker.TabIndex = 5;
            this.butObtServiceInvoker.Text = "ObtServiceInvoker";
            this.butObtServiceInvoker.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 663);
            this.Controls.Add(this.butExecSp);
            this.Controls.Add(this.butOnlyFunction);
            this.Controls.Add(this.butObtCallCSharp);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.butObtServiceInvoker);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butExecSp;
        private System.Windows.Forms.Button butOnlyFunction;
        private System.Windows.Forms.Button butObtCallCSharp;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button butObtServiceInvoker;
    }
}

