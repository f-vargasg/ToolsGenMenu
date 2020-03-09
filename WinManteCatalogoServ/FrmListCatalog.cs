using AppBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UiUtilities;
using Utilities;

namespace WinManteCatalogoServ
{
    public partial class FrmListCatalog : UiUtilities.FrmListBase
    {
        public FrmListCatalog()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            dgrData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgrData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        protected override void RefreshTlStrpBut_Click(object sender, EventArgs e)
        {
            base.RefreshTlStrpBut_Click(sender, e);

            try
            {
                CatalogoServBL catSrvBL = new CatalogoServBL();
                DataSet ds = catSrvBL.GetList();
                dgrData.AutoGenerateColumns = true;
                dgrData.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        protected override void InsTlStrpBut_Click(object sender, EventArgs e)
        {
            base.InsTlStrpBut_Click(sender, e);
            try
            {
                FrmManteCatalogo frm = new FrmManteCatalogo();
                frm.EstadoForm = FormEstados.ModInsertar;
                frm.ShowDialog();
                RefreshTlStrpBut_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void ModTlStrpBut_Click(object sender, EventArgs e)
        {
            base.ModTlStrpBut_Click(sender, e);
            try
            {
                FrmManteCatalogo frm = new FrmManteCatalogo();
                frm.EstadoForm = FormEstados.ModModif;
                //frm.CatSrvBE.CodServicioN = Convert.ToInt32(dgrData.SelectedCells[0].Value);
                frm.CatSrvBE.CodServicioN = Convert.ToInt32(dgrData.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
                RefreshTlStrpBut_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void BorTlStrpBut_Click(object sender, EventArgs e)
        {
            base.BorTlStrpBut_Click(sender, e);
            
            try
            {
                if (dgrData.Rows.Count > 0)
                {
                    FrmManteCatalogo frm = new FrmManteCatalogo(FormEstados.ModBorrar);
                    frm.EstadoForm = FormEstados.ModBorrar;
                    //frm.CatSrvBE.CodServicioN = Convert.ToInt32(dgrData.SelectedCells[0].Value);
                    frm.CatSrvBE.CodServicioN = Convert.ToInt32(dgrData.CurrentRow.Cells[0].Value);
                    frm.ShowDialog();
                    RefreshTlStrpBut_Click(sender, e);
   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
