namespace WinManteCatalogoServ
{
    partial class FrmListCatalog
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butSeach = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.copiarTlStrpBut = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.Items.Add(copiarTlStrpBut);
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 26);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // butSeach
            // 
            this.butSeach.Location = new System.Drawing.Point(265, 0);
            this.butSeach.Name = "butSeach";
            this.butSeach.Size = new System.Drawing.Size(85, 27);
            this.butSeach.TabIndex = 5;
            this.butSeach.Text = "Search";
            this.butSeach.UseVisualStyleBackColor = true;
            this.butSeach.Click += new System.EventHandler(this.butSeach_Click);
            // 
            // FrmListCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(1243, 606);
            this.Controls.Add(this.butSeach);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmListCatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.SetChildIndex(this.butSeach, 0);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

            
            this.copiarTlStrpBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            // this.copiarTlStrpBut.Image = ((System.Drawing.Image)(resources.GetObject("copiarTlStrpBut.Image")));
            this.copiarTlStrpBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarTlStrpBut.Name = "copiarTlStrpBut";
            this.copiarTlStrpBut.Size = new System.Drawing.Size(24, 24);
            this.copiarTlStrpBut.Text = "copiarTlStrpBut";
            this.copiarTlStrpBut.ToolTipText = "Copiar";
            

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        protected System.Windows.Forms.ToolStripButton copiarTlStrpBut;
        private System.Windows.Forms.Button butSeach;
    }
}
