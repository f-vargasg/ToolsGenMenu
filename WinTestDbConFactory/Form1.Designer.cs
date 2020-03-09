namespace WinTestDbConFactory
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
            this.butObtServiceInvoker = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.butObtCallCSharp = new System.Windows.Forms.Button();
            this.butOnlyFunction = new System.Windows.Forms.Button();
            this.butExecSp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butObtServiceInvoker
            // 
            this.butObtServiceInvoker.Location = new System.Drawing.Point(12, 12);
            this.butObtServiceInvoker.Name = "butObtServiceInvoker";
            this.butObtServiceInvoker.Size = new System.Drawing.Size(176, 76);
            this.butObtServiceInvoker.TabIndex = 0;
            this.butObtServiceInvoker.Text = "ObtServiceInvoker";
            this.butObtServiceInvoker.UseVisualStyleBackColor = true;
            this.butObtServiceInvoker.Click += new System.EventHandler(this.butDo_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(-4, 148);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(1043, 524);
            this.txtOutput.TabIndex = 1;
            // 
            // butObtCallCSharp
            // 
            this.butObtCallCSharp.Location = new System.Drawing.Point(238, 12);
            this.butObtCallCSharp.Name = "butObtCallCSharp";
            this.butObtCallCSharp.Size = new System.Drawing.Size(176, 76);
            this.butObtCallCSharp.TabIndex = 2;
            this.butObtCallCSharp.Text = "ObtCallCSharp";
            this.butObtCallCSharp.UseVisualStyleBackColor = true;
            this.butObtCallCSharp.Click += new System.EventHandler(this.butObtCallCSharp_Click);
            // 
            // butOnlyFunction
            // 
            this.butOnlyFunction.Location = new System.Drawing.Point(485, 12);
            this.butOnlyFunction.Name = "butOnlyFunction";
            this.butOnlyFunction.Size = new System.Drawing.Size(176, 76);
            this.butOnlyFunction.TabIndex = 3;
            this.butOnlyFunction.Text = "ObtValor";
            this.butOnlyFunction.UseVisualStyleBackColor = true;
            this.butOnlyFunction.Click += new System.EventHandler(this.butOnlyFunction_Click);
            // 
            // butExecSp
            // 
            this.butExecSp.Location = new System.Drawing.Point(704, 12);
            this.butExecSp.Name = "butExecSp";
            this.butExecSp.Size = new System.Drawing.Size(176, 76);
            this.butExecSp.TabIndex = 4;
            this.butExecSp.Text = "CargarDatos";
            this.butExecSp.UseVisualStyleBackColor = true;
            this.butExecSp.Click += new System.EventHandler(this.butExecSp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 675);
            this.Controls.Add(this.butExecSp);
            this.Controls.Add(this.butOnlyFunction);
            this.Controls.Add(this.butObtCallCSharp);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.butObtServiceInvoker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butObtServiceInvoker;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button butObtCallCSharp;
        private System.Windows.Forms.Button butOnlyFunction;
        private System.Windows.Forms.Button butExecSp;
    }
}

