using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinManteCatalogoServ
{
    public partial class FrmSeachCatServ : Form
    {


        public DataGridView DgrData { get; set; }

        public FrmSeachCatServ()
        {
            InitializeComponent();
        }

        private void InitMyComponents()
        {
            this.Text = this.Name;

            cmbSearchType.Items.Clear();
            DataTable dt = (DataTable)DgrData.DataSource;
            string[] ColNameList = dt.Columns.OfType<DataColumn>().Select(x => x.ColumnName).ToArray();
            cmbSearchType.Items.AddRange(ColNameList); // Adding Column Names in ComoBox List    
                                                       // show datatable
                                                       //ds.Tables.Add(dt);
            if (cmbSearchType.Items.Count > 0) cmbSearchType.SelectedIndex = 0;
        }

        private void FrmSeachCatServ_Load(object sender, EventArgs e)
        {
            InitMyComponents();

        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)this.DgrData.DataSource).DefaultView.RowFilter =
                    string.Format("" + cmbSearchType.Text + " like '%{0}%'", txtSearchBox.Text.Trim().Replace("'", "''"));
                // lblRowCount.Text = (dgrData.Rows.Count - 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
