namespace WinUtiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.tlStripOptions = new System.Windows.Forms.ToolStrip();
            this.tlStrpSalir = new System.Windows.Forms.ToolStripButton();
            this.tlStrpRefresh = new System.Windows.Forms.ToolStripButton();
            this.tlsButExecute = new System.Windows.Forms.ToolStripButton();
            this.tlsButAskWeekDay = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.txtVarRow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEntityName1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tblPrinc = new System.Windows.Forms.TabControl();
            this.tblOraMetadata = new System.Windows.Forms.TabPage();
            this.dgrCode = new System.Windows.Forms.DataGridView();
            this.stdCallCSharp = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCSharpInvok = new System.Windows.Forms.TextBox();
            this.txtDbOwner = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtServName = new System.Windows.Forms.TextBox();
            this.txtEntityName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEntityOption = new System.Windows.Forms.TextBox();
            this.tbPgPadresHijas = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtTablePH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOwnerPH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tlStripOptions.SuspendLayout();
            this.tblPrinc.SuspendLayout();
            this.tblOraMetadata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrCode)).BeginInit();
            this.stdCallCSharp.SuspendLayout();
            this.tbPgPadresHijas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlStripOptions
            // 
            this.tlStripOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tlStripOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlStrpSalir,
            this.tlStrpRefresh,
            this.tlsButExecute,
            this.tlsButAskWeekDay});
            this.tlStripOptions.Location = new System.Drawing.Point(0, 0);
            this.tlStripOptions.Name = "tlStripOptions";
            this.tlStripOptions.Size = new System.Drawing.Size(1190, 27);
            this.tlStripOptions.TabIndex = 4;
            this.tlStripOptions.Text = "toolStrip1";
            // 
            // tlStrpSalir
            // 
            this.tlStrpSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStrpSalir.Image = ((System.Drawing.Image)(resources.GetObject("tlStrpSalir.Image")));
            this.tlStrpSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStrpSalir.Name = "tlStrpSalir";
            this.tlStrpSalir.Size = new System.Drawing.Size(24, 24);
            this.tlStrpSalir.Text = "Exit";
            this.tlStrpSalir.Click += new System.EventHandler(this.tlStrpSalir_Click);
            // 
            // tlStrpRefresh
            // 
            this.tlStrpRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStrpRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tlStrpRefresh.Image")));
            this.tlStrpRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStrpRefresh.Name = "tlStrpRefresh";
            this.tlStrpRefresh.Size = new System.Drawing.Size(24, 24);
            this.tlStrpRefresh.Text = "Refresh";
            // 
            // tlsButExecute
            // 
            this.tlsButExecute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsButExecute.Image = ((System.Drawing.Image)(resources.GetObject("tlsButExecute.Image")));
            this.tlsButExecute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsButExecute.Name = "tlsButExecute";
            this.tlsButExecute.Size = new System.Drawing.Size(24, 24);
            this.tlsButExecute.Text = "tlsButExecute";
            this.tlsButExecute.Click += new System.EventHandler(this.tlsButExecute_Click);
            // 
            // tlsButAskWeekDay
            // 
            this.tlsButAskWeekDay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsButAskWeekDay.Image = ((System.Drawing.Image)(resources.GetObject("tlsButAskWeekDay.Image")));
            this.tlsButAskWeekDay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsButAskWeekDay.Name = "tlsButAskWeekDay";
            this.tlsButAskWeekDay.Size = new System.Drawing.Size(24, 24);
            this.tlsButAskWeekDay.Text = "toolStripButton1";
            this.tlsButAskWeekDay.ToolTipText = "Preguntar dia semana";
            this.tlsButAskWeekDay.Click += new System.EventHandler(this.tlsButAskWeekDay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Owner:";
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(107, 18);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(220, 26);
            this.txtOwner.TabIndex = 6;
            // 
            // txtVarRow
            // 
            this.txtVarRow.Location = new System.Drawing.Point(107, 62);
            this.txtVarRow.Name = "txtVarRow";
            this.txtVarRow.Size = new System.Drawing.Size(220, 26);
            this.txtVarRow.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Var.Row:";
            // 
            // txtEntityName1
            // 
            this.txtEntityName1.Location = new System.Drawing.Point(443, 62);
            this.txtEntityName1.Name = "txtEntityName1";
            this.txtEntityName1.Size = new System.Drawing.Size(220, 26);
            this.txtEntityName1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Entity Name:";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(443, 18);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(220, 26);
            this.txtTableName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Table Name:";
            // 
            // tblPrinc
            // 
            this.tblPrinc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblPrinc.Controls.Add(this.tblOraMetadata);
            this.tblPrinc.Controls.Add(this.stdCallCSharp);
            this.tblPrinc.Controls.Add(this.tbPgPadresHijas);
            this.tblPrinc.Location = new System.Drawing.Point(0, 28);
            this.tblPrinc.Name = "tblPrinc";
            this.tblPrinc.SelectedIndex = 0;
            this.tblPrinc.Size = new System.Drawing.Size(1194, 634);
            this.tblPrinc.TabIndex = 13;
            // 
            // tblOraMetadata
            // 
            this.tblOraMetadata.Controls.Add(this.dgrCode);
            this.tblOraMetadata.Controls.Add(this.txtEntityName1);
            this.tblOraMetadata.Controls.Add(this.label1);
            this.tblOraMetadata.Controls.Add(this.label3);
            this.tblOraMetadata.Controls.Add(this.txtOwner);
            this.tblOraMetadata.Controls.Add(this.txtTableName);
            this.tblOraMetadata.Controls.Add(this.label2);
            this.tblOraMetadata.Controls.Add(this.label4);
            this.tblOraMetadata.Controls.Add(this.txtVarRow);
            this.tblOraMetadata.Location = new System.Drawing.Point(4, 29);
            this.tblOraMetadata.Name = "tblOraMetadata";
            this.tblOraMetadata.Padding = new System.Windows.Forms.Padding(3);
            this.tblOraMetadata.Size = new System.Drawing.Size(1186, 601);
            this.tblOraMetadata.TabIndex = 0;
            this.tblOraMetadata.Text = "Oracle Metadata";
            this.tblOraMetadata.UseVisualStyleBackColor = true;
            // 
            // dgrCode
            // 
            this.dgrCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrCode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgrCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrCode.Location = new System.Drawing.Point(8, 112);
            this.dgrCode.Name = "dgrCode";
            this.dgrCode.Size = new System.Drawing.Size(1178, 489);
            this.dgrCode.TabIndex = 13;
            // 
            // stdCallCSharp
            // 
            this.stdCallCSharp.Controls.Add(this.label9);
            this.stdCallCSharp.Controls.Add(this.txtCSharpInvok);
            this.stdCallCSharp.Controls.Add(this.txtDbOwner);
            this.stdCallCSharp.Controls.Add(this.label5);
            this.stdCallCSharp.Controls.Add(this.label6);
            this.stdCallCSharp.Controls.Add(this.txtServName);
            this.stdCallCSharp.Controls.Add(this.txtEntityName);
            this.stdCallCSharp.Controls.Add(this.label7);
            this.stdCallCSharp.Controls.Add(this.label8);
            this.stdCallCSharp.Controls.Add(this.txtEntityOption);
            this.stdCallCSharp.Location = new System.Drawing.Point(4, 29);
            this.stdCallCSharp.Name = "stdCallCSharp";
            this.stdCallCSharp.Padding = new System.Windows.Forms.Padding(3);
            this.stdCallCSharp.Size = new System.Drawing.Size(1186, 631);
            this.stdCallCSharp.TabIndex = 1;
            this.stdCallCSharp.Text = "C# Standard Calls";
            this.stdCallCSharp.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "C# Call";
            // 
            // txtCSharpInvok
            // 
            this.txtCSharpInvok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCSharpInvok.Location = new System.Drawing.Point(0, 121);
            this.txtCSharpInvok.Multiline = true;
            this.txtCSharpInvok.Name = "txtCSharpInvok";
            this.txtCSharpInvok.Size = new System.Drawing.Size(1183, 480);
            this.txtCSharpInvok.TabIndex = 21;
            // 
            // txtDbOwner
            // 
            this.txtDbOwner.Location = new System.Drawing.Point(488, 21);
            this.txtDbOwner.Name = "txtDbOwner";
            this.txtDbOwner.Size = new System.Drawing.Size(231, 26);
            this.txtDbOwner.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Service name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Owner:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtServName
            // 
            this.txtServName.Location = new System.Drawing.Point(131, 21);
            this.txtServName.Name = "txtServName";
            this.txtServName.Size = new System.Drawing.Size(220, 26);
            this.txtServName.TabIndex = 14;
            // 
            // txtEntityName
            // 
            this.txtEntityName.Location = new System.Drawing.Point(131, 59);
            this.txtEntityName.Name = "txtEntityName";
            this.txtEntityName.Size = new System.Drawing.Size(220, 26);
            this.txtEntityName.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Entity Option:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Entity Name:";
            // 
            // txtEntityOption
            // 
            this.txtEntityOption.Location = new System.Drawing.Point(488, 59);
            this.txtEntityOption.Name = "txtEntityOption";
            this.txtEntityOption.Size = new System.Drawing.Size(231, 26);
            this.txtEntityOption.TabIndex = 16;
            // 
            // tbPgPadresHijas
            // 
            this.tbPgPadresHijas.Controls.Add(this.label13);
            this.tbPgPadresHijas.Controls.Add(this.label12);
            this.tbPgPadresHijas.Controls.Add(this.dataGridView2);
            this.tbPgPadresHijas.Controls.Add(this.txtTablePH);
            this.tbPgPadresHijas.Controls.Add(this.label11);
            this.tbPgPadresHijas.Controls.Add(this.txtOwnerPH);
            this.tbPgPadresHijas.Controls.Add(this.label10);
            this.tbPgPadresHijas.Controls.Add(this.dataGridView1);
            this.tbPgPadresHijas.Location = new System.Drawing.Point(4, 29);
            this.tbPgPadresHijas.Name = "tbPgPadresHijas";
            this.tbPgPadresHijas.Size = new System.Drawing.Size(1186, 601);
            this.tbPgPadresHijas.TabIndex = 2;
            this.tbPgPadresHijas.Text = "Tablas Padres e Hijas";
            this.tbPgPadresHijas.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(548, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "Hijas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Padres";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(552, 63);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(577, 535);
            this.dataGridView2.TabIndex = 5;
            // 
            // txtTablePH
            // 
            this.txtTablePH.Location = new System.Drawing.Point(498, 16);
            this.txtTablePH.Name = "txtTablePH";
            this.txtTablePH.Size = new System.Drawing.Size(301, 26);
            this.txtTablePH.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(388, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Table Name:";
            // 
            // txtOwnerPH
            // 
            this.txtOwnerPH.Location = new System.Drawing.Point(126, 16);
            this.txtOwnerPH.Name = "txtOwnerPH";
            this.txtOwnerPH.Size = new System.Drawing.Size(184, 26);
            this.txtOwnerPH.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Owner";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 535);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 658);
            this.Controls.Add(this.tblPrinc);
            this.Controls.Add(this.tlStripOptions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tlStripOptions.ResumeLayout(false);
            this.tlStripOptions.PerformLayout();
            this.tblPrinc.ResumeLayout(false);
            this.tblOraMetadata.ResumeLayout(false);
            this.tblOraMetadata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrCode)).EndInit();
            this.stdCallCSharp.ResumeLayout(false);
            this.stdCallCSharp.PerformLayout();
            this.tbPgPadresHijas.ResumeLayout(false);
            this.tbPgPadresHijas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlStripOptions;
        private System.Windows.Forms.ToolStripButton tlStrpRefresh;
        private System.Windows.Forms.ToolStripButton tlStrpSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.TextBox txtVarRow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEntityName1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tblPrinc;
        private System.Windows.Forms.TabPage tblOraMetadata;
        private System.Windows.Forms.TabPage stdCallCSharp;
        private System.Windows.Forms.TextBox txtDbOwner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtServName;
        private System.Windows.Forms.TextBox txtEntityName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEntityOption;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCSharpInvok;
        private System.Windows.Forms.DataGridView dgrCode;
        private System.Windows.Forms.ToolStripButton tlsButExecute;
        private System.Windows.Forms.ToolStripButton tlsButAskWeekDay;
        private System.Windows.Forms.TabPage tbPgPadresHijas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtTablePH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOwnerPH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

