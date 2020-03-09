namespace WinManteCatalogoServ
{
    partial class FrmPrincCatalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincCatalogo));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tLstripButRefresh = new System.Windows.Forms.ToolStripButton();
            this.tLstripButAdd = new System.Windows.Forms.ToolStripButton();
            this.tLstripButVer = new System.Windows.Forms.ToolStripButton();
            this.tLstripButIndexar = new System.Windows.Forms.ToolStripButton();
            this.tLstripButEnv = new System.Windows.Forms.ToolStripButton();
            this.tLstripButUpDoc = new System.Windows.Forms.ToolStripButton();
            this.tLstripButSeal = new System.Windows.Forms.ToolStripButton();
            this.tLstripButGetNumber = new System.Windows.Forms.ToolStripButton();
            this.tLstripButSalir = new System.Windows.Forms.ToolStripButton();
            this.dgrData = new System.Windows.Forms.DataGridView();
            this.tLstripButDel = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.mantenimientoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "&Mantenimiento";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tLstripButRefresh,
            this.tLstripButAdd,
            this.tLstripButDel,
            this.tLstripButVer,
            this.tLstripButIndexar,
            this.tLstripButEnv,
            this.tLstripButUpDoc,
            this.tLstripButSeal,
            this.tLstripButGetNumber,
            this.tLstripButSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(776, 27);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tLstripButRefresh
            // 
            this.tLstripButRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tLstripButRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tLstripButRefresh.Image")));
            this.tLstripButRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tLstripButRefresh.Name = "tLstripButRefresh";
            this.tLstripButRefresh.Size = new System.Drawing.Size(24, 24);
            this.tLstripButRefresh.Text = "toolStripButton3";
            this.tLstripButRefresh.ToolTipText = "Refrescar";
            this.tLstripButRefresh.Click += new System.EventHandler(this.tLstripButRefresh_Click);
            // 
            // tLstripButAdd
            // 
            this.tLstripButAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tLstripButAdd.Image = ((System.Drawing.Image)(resources.GetObject("tLstripButAdd.Image")));
            this.tLstripButAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tLstripButAdd.Name = "tLstripButAdd";
            this.tLstripButAdd.Size = new System.Drawing.Size(24, 24);
            this.tLstripButAdd.Text = "tStrAdd";
            this.tLstripButAdd.ToolTipText = "Añadir";
            this.tLstripButAdd.Click += new System.EventHandler(this.tLstripButAdd_Click);
            // 
            // tLstripButVer
            // 
            this.tLstripButVer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tLstripButVer.Image = ((System.Drawing.Image)(resources.GetObject("tLstripButVer.Image")));
            this.tLstripButVer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tLstripButVer.Name = "tLstripButVer";
            this.tLstripButVer.Size = new System.Drawing.Size(24, 24);
            this.tLstripButVer.Text = "toolStripButton1";
            this.tLstripButVer.ToolTipText = "Ver Documento";
            // 
            // tLstripButIndexar
            // 
            this.tLstripButIndexar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tLstripButIndexar.Image = ((System.Drawing.Image)(resources.GetObject("tLstripButIndexar.Image")));
            this.tLstripButIndexar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tLstripButIndexar.Name = "tLstripButIndexar";
            this.tLstripButIndexar.Size = new System.Drawing.Size(24, 24);
            this.tLstripButIndexar.Text = "toolStripButton2";
            this.tLstripButIndexar.ToolTipText = "Indexar";
            // 
            // tLstripButEnv
            // 
            this.tLstripButEnv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tLstripButEnv.Image = ((System.Drawing.Image)(resources.GetObject("tLstripButEnv.Image")));
            this.tLstripButEnv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tLstripButEnv.Name = "tLstripButEnv";
            this.tLstripButEnv.Size = new System.Drawing.Size(24, 24);
            this.tLstripButEnv.Text = "toolStripButton1";
            this.tLstripButEnv.ToolTipText = "Enviar";
            // 
            // tLstripButUpDoc
            // 
            this.tLstripButUpDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tLstripButUpDoc.Image = ((System.Drawing.Image)(resources.GetObject("tLstripButUpDoc.Image")));
            this.tLstripButUpDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tLstripButUpDoc.Name = "tLstripButUpDoc";
            this.tLstripButUpDoc.Size = new System.Drawing.Size(24, 24);
            this.tLstripButUpDoc.Text = "toolStripButton1";
            this.tLstripButUpDoc.ToolTipText = "Actualizar documento";
            // 
            // tLstripButSeal
            // 
            this.tLstripButSeal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tLstripButSeal.Image = ((System.Drawing.Image)(resources.GetObject("tLstripButSeal.Image")));
            this.tLstripButSeal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tLstripButSeal.Name = "tLstripButSeal";
            this.tLstripButSeal.Size = new System.Drawing.Size(24, 24);
            this.tLstripButSeal.Text = "toolStripButton1";
            this.tLstripButSeal.ToolTipText = "Sellar documento";
            // 
            // tLstripButGetNumber
            // 
            this.tLstripButGetNumber.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tLstripButGetNumber.Image = ((System.Drawing.Image)(resources.GetObject("tLstripButGetNumber.Image")));
            this.tLstripButGetNumber.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tLstripButGetNumber.Name = "tLstripButGetNumber";
            this.tLstripButGetNumber.Size = new System.Drawing.Size(24, 24);
            this.tLstripButGetNumber.Text = "toolStripButton1";
            this.tLstripButGetNumber.ToolTipText = "Obtener numero";
            // 
            // tLstripButSalir
            // 
            this.tLstripButSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tLstripButSalir.Image = ((System.Drawing.Image)(resources.GetObject("tLstripButSalir.Image")));
            this.tLstripButSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tLstripButSalir.Name = "tLstripButSalir";
            this.tLstripButSalir.Size = new System.Drawing.Size(24, 24);
            this.tLstripButSalir.Text = "toolStripButton1";
            this.tLstripButSalir.ToolTipText = "Salir";
            this.tLstripButSalir.Click += new System.EventHandler(this.tLstripButSalir_Click);
            // 
            // dgrData
            // 
            this.dgrData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgrData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgrData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrData.Location = new System.Drawing.Point(0, 48);
            this.dgrData.MultiSelect = false;
            this.dgrData.Name = "dgrData";
            this.dgrData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrData.Size = new System.Drawing.Size(776, 396);
            this.dgrData.TabIndex = 16;
            // 
            // tLstripButDel
            // 
            this.tLstripButDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tLstripButDel.Image = ((System.Drawing.Image)(resources.GetObject("tLstripButDel.Image")));
            this.tLstripButDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tLstripButDel.Name = "tLstripButDel";
            this.tLstripButDel.Size = new System.Drawing.Size(24, 24);
            this.tLstripButDel.Text = "toolStripButton1";
            this.tLstripButDel.ToolTipText = "Delete";
            this.tLstripButDel.Click += new System.EventHandler(this.tLstripButDel_Click);
            // 
            // FrmPrincCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 442);
            this.Controls.Add(this.dgrData);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPrincCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tLstripButRefresh;
        private System.Windows.Forms.ToolStripButton tLstripButAdd;
        private System.Windows.Forms.ToolStripButton tLstripButVer;
        private System.Windows.Forms.ToolStripButton tLstripButIndexar;
        private System.Windows.Forms.ToolStripButton tLstripButEnv;
        private System.Windows.Forms.ToolStripButton tLstripButUpDoc;
        private System.Windows.Forms.ToolStripButton tLstripButSeal;
        private System.Windows.Forms.ToolStripButton tLstripButGetNumber;
        private System.Windows.Forms.ToolStripButton tLstripButSalir;
        private System.Windows.Forms.DataGridView dgrData;
        private System.Windows.Forms.ToolStripButton tLstripButDel;
    }
}

