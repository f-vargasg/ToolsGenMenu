using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;
using Utilities;

namespace WinDataWorkBench
{
    public partial class FrmPrincDataWB : Form
    {
        public FrmPrincDataWB()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            this.Text = "Execute Query (" + this.Name + ") => [" + ConnGl.Instance.Conn.DataSource + "]" ;
        }

        private void ExittlsStrp_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ExecQrytlsStrp_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                sql = txtQry.Text;
                OracleDataReader dr = MyOracleUtils.executeSqlStm(sql, ConnGl.Instance.Conn);
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgrData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            
        }

        private void testtlsStrp_Click(object sender, EventArgs e)
        {
            txtQry.Text = "SELECT SYSDATE FROM DUAL";
        }

        private void CleartlsStrp_Click(object sender, EventArgs e)
        {
            txtQry.Text = string.Empty;
        }
    }
}
