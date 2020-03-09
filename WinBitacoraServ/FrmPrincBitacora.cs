using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;
using WinBitacoraServ.DataLayer;
using WinConsCatalogoSabNet;

namespace WinBitacoraServ
{
    public partial class FrmPrincBitacora : Form
    {
        public FrmPrincBitacora()
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
                "[BD => " +    ambiente.ToUpper() + "]";
           
            txtCodUsuario.Text = "FVARGAS";
            chkPorCodUsuario.Checked = true;
            dtpFecFin.Format = dtpFecInic.Format = DateTimePickerFormat.Custom;
            dtpFecInic.CustomFormat = dtpFecFin.CustomFormat = "dd/MM/yyyy";

        }

        private void tstButFind_Click(object sender, EventArgs e)
        {
            BitacoraServDL bitServDL = new BitacoraServDL();

            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                string scrap = string.Empty;
                string cond = string.Empty;

                scrap = (chkPorCodServ.Checked ? " A.nom_servicio = " + MyStringUtils.entreComas(txtNom_Servicio.Text ) : string.Empty);
                cond = scrap;
                
                scrap = (chkPorCodUsuario.Checked ? " A.cod_usuario_v = " + MyStringUtils.entreComas(txtCodUsuario.Text) : string.Empty);
                cond += (cond.Length > 0 && scrap.Length > 0 ? " AND " : string.Empty) + scrap;
                
                
                scrap =  " TRUNC(A.FEC_INICIO) between " + MyDateUtils.toDate (dtpFecInic.Value) + " AND " + 
                           MyDateUtils.toDate (dtpFecFin.Value); 
                cond += (cond.Length > 0 && scrap.Length > 0 ? " AND " : string.Empty) + scrap;

                OracleDataReader dr = bitServDL.getBitacoraEntries(cond);
                bool drVacio = (!dr.HasRows);
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgrData.DataSource = dt;

                if (drVacio)
                {
                    dgrData_RowEnter(null, null);
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

        private void dgrData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgrData.SelectedCells.Count > 0)
            {
                try
                {
                    int selectedrowindex = dgrData.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = dgrData.Rows[selectedrowindex];

                    txtDes_invocador.Text = Convert.ToString(selectedRow.Cells["DES_TRANSACCION"].Value);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }



            }

        }

        private void tstButExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
