using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinGenCallSps.DataLayer;

namespace WinXmlToSqlInvoker
{
    public partial class FrnPrincGenCall : Form
    {
        public FrnPrincGenCall()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            this.Text = this.Text + " (" + this.Name + ") ";
            cmbEsquema.SelectedIndex = 1;
            cmbTargetLang.SelectedIndex = 0;
            txtPackageName.Text = "GE_PAMBMONEDA";
            txtMethodName.Text = "DESCRIPCION";
        }

        private void tlStrExecSql_Click(object sender, EventArgs e)
        {
            try
            {
                OraMetaDataDL orMetDl = new OraMetaDataDL();
                // Set cursor as hourglass
                Cursor.Current = Cursors.WaitCursor;
                // Execute your time-intensive hashing code here...
                txtCodeRes.Text = orMetDl.getCallPlSqlStm(txtPackageName.Text, txtMethodName.Text, (string)(cmbEsquema.SelectedItem));

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Set cursor as default arrow
                Cursor.Current = Cursors.Default;
            }







        }

        private void tlStrSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
