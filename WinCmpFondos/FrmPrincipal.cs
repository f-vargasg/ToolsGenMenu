using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinCmpFondos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            InitMyComponets();
        }

        private void InitMyComponets()
        {
            txtPath1.Text = ConfigurationManager.AppSettings["path1"];
            txtPath2.Text = ConfigurationManager.AppSettings["path2"];
        }

        private void tlStrpExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tlStrpCmp_Click(object sender, EventArgs e)
        {
            string scrap, scrap1;
            string[] filePaths1 = Directory.GetFiles(txtPath1.Text);
            string[] filePaths2 = Directory.GetFiles(txtPath2.Text);

            foreach (var item in filePaths1)
            {
                // Console.WriteLine(item);
                scrap = Path.GetFileName (item);
                txtPath1NoPath2.Text += ( scrap + Environment.NewLine) ;

                var results = Array.FindAll(filePaths2, s => s.Equals(item));
                if (results.Length > 0)
                {
                    scrap1 = Path.GetFileName(results[0]) + "[Encontrado!!!]";
                    txtPath2NoPath1.Text += (scrap1 + Environment.NewLine);
                }
            }         
        }

        private void butSearchRut1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                //if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                if (result == DialogResult.OK && !(fbd.SelectedPath.Length <= 0 || 
                                                   fbd.SelectedPath.CompareTo (" ") == 0))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
        }

        private void butSearchRut2_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                //if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                if (result == DialogResult.OK && !(fbd.SelectedPath.Length <= 0 ||
                                                   fbd.SelectedPath.CompareTo(" ") == 0))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
        }
    }
}
