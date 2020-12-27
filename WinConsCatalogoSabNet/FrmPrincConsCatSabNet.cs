using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;
using Utilities;
using WinConsCatalogoSabNet.DataLayer;

namespace WinConsCatalogoSabNet
{
    public partial class FrmPrincConsCatSabNet : Form
    {
        public FrmPrincConsCatSabNet()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            string connStr = MyAppConfig.Instance.ConnStr;
            string tagKey = "Source";
            string ambiente = connStr.Substring(connStr.IndexOf(tagKey) + tagKey.Length + 1);

            this.Text = this.Text + " (" + this.Name + ") " +
                "[BD => " + ambiente.ToUpper() + "]";


            txtNom_Servicio.Text = "E-VO-FIELDDET-CARGA_CALIF-SN";
        }

        private void tstButExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tstButFind_Click(object sender, EventArgs e)
        {

            CatalogoDL catDl = new CatalogoDL();

            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                string cond = (chkBoxLike.Checked ? "LIKE " + MyStringUtils.entreComas("%" + txtNom_Servicio.Text+ "%") :
                                                   " = " + MyStringUtils.entreComas(txtNom_Servicio.Text));
                OracleDataReader dr = catDl.getCatalogoEntries("NOM_SERVICIO " + cond);
                bool drVacio = (!dr.HasRows);
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgrData.DataSource = dt;
                
                if (drVacio  )
                {
                    dataGridView1_RowEnter(null, null);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (dgrData.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgrData.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgrData.Rows[selectedrowindex];

                txtDes_invocador.Text = Convert.ToString(selectedRow.Cells["DES_INVOCADOR"].Value);


            }
        }
    }
}
