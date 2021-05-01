using Oracle.ManagedDataAccess.Client;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using Utilities;
using WinSABDashBoard.DataLayer;

namespace WinSABDashBoard
{
    public partial class FrmPrincDashBoard : Form
    {
        int refreshInterval;
        public FrmPrincDashBoard()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            timerRefresh.Enabled = false;
            this.Text = "SAB DashBoard (" + this.Name + ")";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.refreshInterval = Convert.ToInt32( ConfigurationManager.AppSettings["refreshInterval"]) * 1000;
            RefreshDashBoard();
            this.timerRefresh.Enabled = true;
            lblTrackTimer.Text = string.Empty;
        }

        private void tlStrpRefresh_Click(object sender, EventArgs e)
        {
            RefreshDashBoard();
        }

        private void RefreshDashBoard()
        {
            RefreshCierres();
            RefreshHorarios();
            RefreshCtlHorariosSabNet();
        }

        private void RefreshCtlHorariosSabNet()
        {

            CtlrHoraSabNetDL ctrlHor = new CtlrHoraSabNetDL();

            SendDataReaderToDataView(ctrlHor.getCtlHorariosSabNet(), dgrViewCtrlHorarios);


        }

        private void RefreshHorarios()
        {
            ParametrosGeneralesDL paramGlDL = new ParametrosGeneralesDL();

            SendDataReaderToDataView(paramGlDL.getParametros(), dgrOperT);
        }

        private void RefreshCierres()
        {
            CtrlCierresDL ctrlCieDL = new CtrlCierresDL();
            SendDataReaderToDataView(ctrlCieDL.getCierres(), dgrViewCierres);
        }

        private void SendSqlToDataView(string sql, DataGridView dgrView)
        {
            OracleDataReader dr = MyOracleUtils.executeSqlStm(sql, ConnGl.Instance.Conn);
            SendDataReaderToDataView(dr, dgrView);
        }

        private void SendDataReaderToDataView (OracleDataReader dr, DataGridView dgrView  )
        {
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgrView.DataSource = dt;
        }


        private void tlStrpSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            RefreshDashBoard();
            lblTrackTimer.Text = string.Format("Ultimo Refescamiento => {0}", DateTime.Now);
        }
    }
}
