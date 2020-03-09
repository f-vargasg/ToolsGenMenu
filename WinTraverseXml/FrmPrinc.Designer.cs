namespace WinTraverseXml
{
    partial class FrmPrincipal
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
            this.txtXml = new System.Windows.Forms.TextBox();
            this.butDo = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.ViewDataTab = new System.Windows.Forms.TabControl();
            this.ViewTreeTbPg = new System.Windows.Forms.TabPage();
            this.XmlTrV = new System.Windows.Forms.TreeView();
            this.ViewTextTbPg = new System.Windows.Forms.TabPage();
            this.AddNodeBut = new System.Windows.Forms.Button();
            this.lblCurNode = new System.Windows.Forms.Label();
            this.LoadXmlBut = new System.Windows.Forms.Button();
            this.ViewDataTab.SuspendLayout();
            this.ViewTreeTbPg.SuspendLayout();
            this.ViewTextTbPg.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtXml
            // 
            this.txtXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXml.Location = new System.Drawing.Point(-3, 1);
            this.txtXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtXml.Multiline = true;
            this.txtXml.Name = "txtXml";
            this.txtXml.Size = new System.Drawing.Size(873, 387);
            this.txtXml.TabIndex = 0;
            // 
            // butDo
            // 
            this.butDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDo.Location = new System.Drawing.Point(16, 396);
            this.butDo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butDo.Name = "butDo";
            this.butDo.Size = new System.Drawing.Size(219, 70);
            this.butDo.TabIndex = 1;
            this.butDo.Text = "Do";
            this.butDo.UseVisualStyleBackColor = true;
            this.butDo.Click += new System.EventHandler(this.butDo_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(8, 4);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(851, 432);
            this.txtOutput.TabIndex = 2;
            // 
            // ViewDataTab
            // 
            this.ViewDataTab.Controls.Add(this.ViewTreeTbPg);
            this.ViewDataTab.Controls.Add(this.ViewTextTbPg);
            this.ViewDataTab.Location = new System.Drawing.Point(-3, 474);
            this.ViewDataTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewDataTab.Name = "ViewDataTab";
            this.ViewDataTab.SelectedIndex = 0;
            this.ViewDataTab.Size = new System.Drawing.Size(875, 473);
            this.ViewDataTab.TabIndex = 3;
            // 
            // ViewTreeTbPg
            // 
            this.ViewTreeTbPg.Controls.Add(this.XmlTrV);
            this.ViewTreeTbPg.Location = new System.Drawing.Point(4, 25);
            this.ViewTreeTbPg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewTreeTbPg.Name = "ViewTreeTbPg";
            this.ViewTreeTbPg.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewTreeTbPg.Size = new System.Drawing.Size(867, 444);
            this.ViewTreeTbPg.TabIndex = 1;
            this.ViewTreeTbPg.Text = "View Tree";
            this.ViewTreeTbPg.UseVisualStyleBackColor = true;
            // 
            // XmlTrV
            // 
            this.XmlTrV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XmlTrV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XmlTrV.Location = new System.Drawing.Point(4, 7);
            this.XmlTrV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XmlTrV.Name = "XmlTrV";
            this.XmlTrV.Size = new System.Drawing.Size(857, 431);
            this.XmlTrV.TabIndex = 0;
            this.XmlTrV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.XmlTrV_AfterSelect);
            // 
            // ViewTextTbPg
            // 
            this.ViewTextTbPg.Controls.Add(this.txtOutput);
            this.ViewTextTbPg.Location = new System.Drawing.Point(4, 25);
            this.ViewTextTbPg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewTextTbPg.Name = "ViewTextTbPg";
            this.ViewTextTbPg.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewTextTbPg.Size = new System.Drawing.Size(867, 444);
            this.ViewTextTbPg.TabIndex = 0;
            this.ViewTextTbPg.Text = "View Text";
            this.ViewTextTbPg.UseVisualStyleBackColor = true;
            // 
            // AddNodeBut
            // 
            this.AddNodeBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNodeBut.Location = new System.Drawing.Point(260, 396);
            this.AddNodeBut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddNodeBut.Name = "AddNodeBut";
            this.AddNodeBut.Size = new System.Drawing.Size(219, 70);
            this.AddNodeBut.TabIndex = 4;
            this.AddNodeBut.Text = "Add Node";
            this.AddNodeBut.UseVisualStyleBackColor = true;
            this.AddNodeBut.Click += new System.EventHandler(this.AddNodeBut_Click);
            // 
            // lblCurNode
            // 
            this.lblCurNode.AutoSize = true;
            this.lblCurNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurNode.Location = new System.Drawing.Point(751, 418);
            this.lblCurNode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurNode.Name = "lblCurNode";
            this.lblCurNode.Size = new System.Drawing.Size(64, 25);
            this.lblCurNode.TabIndex = 5;
            this.lblCurNode.Text = "label1";
            // 
            // LoadXmlBut
            // 
            this.LoadXmlBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadXmlBut.Location = new System.Drawing.Point(499, 396);
            this.LoadXmlBut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadXmlBut.Name = "LoadXmlBut";
            this.LoadXmlBut.Size = new System.Drawing.Size(219, 70);
            this.LoadXmlBut.TabIndex = 6;
            this.LoadXmlBut.Text = "Load Nodes";
            this.LoadXmlBut.UseVisualStyleBackColor = true;
            this.LoadXmlBut.Click += new System.EventHandler(this.LoadXmlBut_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 948);
            this.Controls.Add(this.LoadXmlBut);
            this.Controls.Add(this.lblCurNode);
            this.Controls.Add(this.AddNodeBut);
            this.Controls.Add(this.ViewDataTab);
            this.Controls.Add(this.butDo);
            this.Controls.Add(this.txtXml);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ViewDataTab.ResumeLayout(false);
            this.ViewTreeTbPg.ResumeLayout(false);
            this.ViewTextTbPg.ResumeLayout(false);
            this.ViewTextTbPg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtXml;
        private System.Windows.Forms.Button butDo;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TabControl ViewDataTab;
        private System.Windows.Forms.TabPage ViewTextTbPg;
        private System.Windows.Forms.TabPage ViewTreeTbPg;
        private System.Windows.Forms.TreeView XmlTrV;
        private System.Windows.Forms.Button AddNodeBut;
        private System.Windows.Forms.Label lblCurNode;
        private System.Windows.Forms.Button LoadXmlBut;
    }
}

