using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinXmlToSqlInvoker
{
    public partial class FrmPrincXmlInvoker : Form
    {
        private const string FNAME = "C:\\Users\\fvgVirt\\Documents\\params.xml";
        public FrmPrincXmlInvoker()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            this.Text += " (" + this.Name + ")";
        }

        private void butGenerate_Click(object sender, EventArgs e)
        {
            // processTransactionFile();
            TransactionFile trxFile = new TransactionFile(fileToProcess.Text);
            txtSalida.Text = trxFile.CallSp;

        }

        private void butSelFile_Click(object sender, EventArgs e)
        {
           // string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
           string userFolder = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
           if (Environment.OSVersion.Version.Major >= 6)
           {
               userFolder = Directory.GetParent(userFolder).ToString();
           }

            OpenFileDialog opnFDlg = new OpenFileDialog();


            opnFDlg.InitialDirectory = userFolder;
            opnFDlg.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            opnFDlg.FilterIndex = 2;
            opnFDlg.RestoreDirectory = true;
            if (opnFDlg.ShowDialog() == DialogResult.OK)
            {
                string filename = opnFDlg.FileName;
                // MessageBox.Show(filename);
                fileToProcess.Text = filename;
            }
        }


    }
}
