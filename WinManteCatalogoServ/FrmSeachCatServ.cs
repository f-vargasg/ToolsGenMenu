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
            try
            {
                cmbSearchType.Items.Clear();
                List<string> lst = new List<string>();
                foreach (DataGridViewColumn item in DgrData.Columns)
                {
                    lst.Add(item.Name);
                }
                string[] ColNameList = lst.ToArray();
//                DataTable dt = (DataTable)DgrData.DataSource;
//                string[] ColNameList = dt.Columns.OfType<DataColumn>().Select(x => x.ColumnName).ToArray();
                cmbSearchType.Items.AddRange(ColNameList); // Adding Column Names in ComoBox List    
                                                           // show datatable
                                                           //ds.Tables.Add(dt);
                if (cmbSearchType.Items.Count > 0) cmbSearchType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Dispose();
            }

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
        // Esto es una prueba
        private void butSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearchBox.Text;
            int columnIndex;
            int rowIndex = 0;

            if (DgrData.Rows.Count > 0)
            {
                columnIndex = DgrData.Rows[0].Cells[cmbSearchType.Text].ColumnIndex;
                DgrData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    foreach (DataGridViewRow row in DgrData.Rows)
                    {
                        if (row.Cells[columnIndex].Value.ToString().Equals(searchValue))
                        {
                            row.Selected = true;
                            DgrData.CurrentCell = DgrData[columnIndex, rowIndex];
                            break;
                        }
                        ++rowIndex;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }


        }
    }
}
