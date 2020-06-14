namespace WinBitacoraServ
{
    partial class FrmPrincBitacora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincBitacora));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecInic = new System.Windows.Forms.DateTimePicker();
            this.chkPorCodUsuario = new System.Windows.Forms.CheckBox();
            this.chkPorCodServ = new System.Windows.Forms.CheckBox();
            this.txtCodUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom_Servicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tstButExit = new System.Windows.Forms.ToolStripButton();
            this.tstButFind = new System.Windows.Forms.ToolStripButton();
            this.txtDes_invocador = new System.Windows.Forms.TextBox();
            this.dgrData = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpFecFin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpFecInic);
            this.panel1.Controls.Add(this.chkPorCodUsuario);
            this.panel1.Controls.Add(this.chkPorCodServ);
            this.panel1.Controls.Add(this.txtCodUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNom_Servicio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 114);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fec.Fin:";
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecFin.Location = new System.Drawing.Point(378, 76);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(165, 26);
            this.dtpFecFin.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fec. Inic:";
            // 
            // dtpFecInic
            // 
            this.dtpFecInic.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecInic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecInic.Location = new System.Drawing.Point(135, 76);
            this.dtpFecInic.Name = "dtpFecInic";
            this.dtpFecInic.Size = new System.Drawing.Size(165, 26);
            this.dtpFecInic.TabIndex = 6;
            // 
            // chkPorCodUsuario
            // 
            this.chkPorCodUsuario.AutoSize = true;
            this.chkPorCodUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPorCodUsuario.Location = new System.Drawing.Point(499, 43);
            this.chkPorCodUsuario.Name = "chkPorCodUsuario";
            this.chkPorCodUsuario.Size = new System.Drawing.Size(225, 24);
            this.chkPorCodUsuario.TabIndex = 5;
            this.chkPorCodUsuario.Text = "Cons. por codigo de usuario";
            this.chkPorCodUsuario.UseVisualStyleBackColor = true;
            // 
            // chkPorCodServ
            // 
            this.chkPorCodServ.AutoSize = true;
            this.chkPorCodServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPorCodServ.Location = new System.Drawing.Point(499, 15);
            this.chkPorCodServ.Name = "chkPorCodServ";
            this.chkPorCodServ.Size = new System.Drawing.Size(225, 24);
            this.chkPorCodServ.TabIndex = 4;
            this.chkPorCodServ.Text = "Cons. por codigo de servicio";
            this.chkPorCodServ.UseVisualStyleBackColor = true;
            // 
            // txtCodUsuario
            // 
            this.txtCodUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodUsuario.Location = new System.Drawing.Point(135, 44);
            this.txtCodUsuario.Name = "txtCodUsuario";
            this.txtCodUsuario.Size = new System.Drawing.Size(342, 26);
            this.txtCodUsuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cod.Usuario";
            // 
            // txtNom_Servicio
            // 
            this.txtNom_Servicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom_Servicio.Location = new System.Drawing.Point(135, 12);
            this.txtNom_Servicio.Name = "txtNom_Servicio";
            this.txtNom_Servicio.Size = new System.Drawing.Size(342, 26);
            this.txtNom_Servicio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod.Servicio:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstButExit,
            this.tstButFind});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1245, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tstButExit
            // 
            this.tstButExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstButExit.Image = ((System.Drawing.Image)(resources.GetObject("tstButExit.Image")));
            this.tstButExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstButExit.Name = "tstButExit";
            this.tstButExit.Size = new System.Drawing.Size(23, 22);
            this.tstButExit.Text = "toolStripButton1";
            this.tstButExit.ToolTipText = "Salir";
            this.tstButExit.Click += new System.EventHandler(this.tstButExit_Click);
            // 
            // tstButFind
            // 
            this.tstButFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstButFind.Image = ((System.Drawing.Image)(resources.GetObject("tstButFind.Image")));
            this.tstButFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstButFind.Name = "tstButFind";
            this.tstButFind.Size = new System.Drawing.Size(23, 22);
            this.tstButFind.Text = "Buscar";
            this.tstButFind.Click += new System.EventHandler(this.tstButFind_Click);
            // 
            // txtDes_invocador
            // 
            this.txtDes_invocador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDes_invocador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes_invocador.Location = new System.Drawing.Point(0, 0);
            this.txtDes_invocador.Multiline = true;
            this.txtDes_invocador.Name = "txtDes_invocador";
            this.txtDes_invocador.Size = new System.Drawing.Size(1245, 264);
            this.txtDes_invocador.TabIndex = 2;
            // 
            // dgrData
            // 
            this.dgrData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrData.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgrData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrData.Location = new System.Drawing.Point(0, 0);
            this.dgrData.Name = "dgrData";
            this.dgrData.Size = new System.Drawing.Size(1245, 204);
            this.dgrData.TabIndex = 0;
            this.dgrData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrData_RowEnter);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 148);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgrData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtDes_invocador);
            this.splitContainer1.Size = new System.Drawing.Size(1245, 472);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.TabIndex = 7;
            // 
            // FrmPrincBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 616);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincBitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrData)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNom_Servicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tstButExit;
        private System.Windows.Forms.ToolStripButton tstButFind;
        private System.Windows.Forms.TextBox txtDes_invocador;
        private System.Windows.Forms.DataGridView dgrData;
        private System.Windows.Forms.CheckBox chkPorCodServ;
        private System.Windows.Forms.TextBox txtCodUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkPorCodUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecInic;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

