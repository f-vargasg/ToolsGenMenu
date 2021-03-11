using AppBE;
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
        private CatalogoServBL catSrvBL;
        public FrmPrincCatalogo()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            catSrvBL = new CatalogoServBL();
        }

        private void TlstripButRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                List<CatalogoServBE> lstCatSrv = catSrvBL.GetList();
                var source = new BindingSource
                {
                    DataSource = lstCatSrv
                };
                dgrData.AutoGenerateColumns = true;
                dgrData.DataSource = source;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void TlstripButSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TlstripButAdd_Click(object sender, EventArgs e)
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

        private void TlstripButDel_Click(object sender, EventArgs e)
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
                        catSrvBL.Borrar(codServicioN);
                        MessageBox.Show("Registro Eliminado!!!!");
                        TlstripButRefresh_Click(sender, e);
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
