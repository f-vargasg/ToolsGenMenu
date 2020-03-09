using AppBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinManteCatalogoServ
{
    public partial class FrmPrincCatalogo : Form
    {
        public FrmPrincCatalogo()
        {
            InitializeComponent();
        }

        private void tLstripButRefresh_Click(object sender, EventArgs e)
        {
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

        private void tLstripButSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tLstripButAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmManteCatalogo frm = new FrmManteCatalogo();

                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tLstripButDel_Click(object sender, EventArgs e)
        {
            int codServicioN;
            try
            {
                if (dgrData.Rows.Count > 0)
                {
                    codServicioN = Convert.ToInt32(dgrData.SelectedCells[0].Value);
                    string msg = string.Format("¿Esta seguro  que desea elminar el registro {0}?", codServicioN);
                    DialogResult dialogResult = MessageBox.Show(msg, "Confirmación de borrado", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        CatalogoServBL catSrvBL = new CatalogoServBL();
                        catSrvBL.Borrar(codServicioN);
                        MessageBox.Show("Registro Eliminado!!!!");
                        tLstripButRefresh_Click(sender, e);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                    
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
