namespace WinEntityAccesors
{
    partial class FrmPrincGenAccesors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincGenAccesors));
            this.txtEntityName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbGetters = new System.Windows.Forms.TabPage();
            this.tbSetters = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbutGen = new System.Windows.Forms.ToolStripButton();
            this.tsButSalir = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tbGetters.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEntityName
            // 
            this.txtEntityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntityName.Location = new System.Drawing.Point(100, 28);
            this.txtEntityName.Name = "txtEntityName";
            this.txtEntityName.Size = new System.Drawing.Size(351, 26);
            this.txtEntityName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entidad:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbGetters);
            this.tabControl1.Controls.Add(this.tbSetters);
            this.tabControl1.Location = new System.Drawing.Point(-3, 90);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1183, 673);
            this.tabControl1.TabIndex = 2;
            // 
            // tbGetters
            // 
            this.tbGetters.Controls.Add(this.txtBody);
            this.tbGetters.Controls.Add(this.label3);
            this.tbGetters.Controls.Add(this.txtSpec);
            this.tbGetters.Controls.Add(this.label2);
            this.tbGetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGetters.Location = new System.Drawing.Point(4, 22);
            this.tbGetters.Name = "tbGetters";
            this.tbGetters.Padding = new System.Windows.Forms.Padding(3);
            this.tbGetters.Size = new System.Drawing.Size(1175, 647);
            this.tbGetters.TabIndex = 0;
            this.tbGetters.Text = "Getters";
            this.tbGetters.UseVisualStyleBackColor = true;
            // 
            // tbSetters
            // 
            this.tbSetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSetters.Location = new System.Drawing.Point(4, 22);
            this.tbSetters.Name = "tbSetters";
            this.tbSetters.Padding = new System.Windows.Forms.Padding(3);
            this.tbSetters.Size = new System.Drawing.Size(875, 519);
            this.tbSetters.TabIndex = 1;
            this.tbSetters.Text = "Setters";
            this.tbSetters.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Spec";
            // 
            // txtSpec
            // 
            this.txtSpec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpec.Location = new System.Drawing.Point(5, 39);
            this.txtSpec.Multiline = true;
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSpec.Size = new System.Drawing.Size(1172, 197);
            this.txtSpec.TabIndex = 1;
            // 
            // txtBody
            // 
            this.txtBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBody.Location = new System.Drawing.Point(0, 272);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBody.Size = new System.Drawing.Size(1172, 374);
            this.txtBody.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Body";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbutGen,
            this.tsButSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1181, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbutGen
            // 
            this.tsbutGen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbutGen.Image = ((System.Drawing.Image)(resources.GetObject("tsbutGen.Image")));
            this.tsbutGen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutGen.Name = "tsbutGen";
            this.tsbutGen.Size = new System.Drawing.Size(23, 22);
            this.tsbutGen.Text = "toolStripButton1";
            this.tsbutGen.Click += new System.EventHandler(this.tsbutGen_Click);
            // 
            // tsButSalir
            // 
            this.tsButSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsButSalir.Image")));
            this.tsButSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButSalir.Name = "tsButSalir";
            this.tsButSalir.Size = new System.Drawing.Size(23, 22);
            this.tsButSalir.Text = "toolStripButton2";
            this.tsButSalir.Click += new System.EventHandler(this.tsButSalir_Click);
            // 
            // FrmPrincGenAccesors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 765);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEntityName);
            this.Name = "FrmPrincGenAccesors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tbGetters.ResumeLayout(false);
            this.tbGetters.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntityName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbGetters;
        private System.Windows.Forms.TabPage tbSetters;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbutGen;
        private System.Windows.Forms.ToolStripButton tsButSalir;
    }
}

