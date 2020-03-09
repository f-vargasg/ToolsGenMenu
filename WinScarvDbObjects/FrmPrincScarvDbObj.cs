using AppBE;
using AppBL;
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

namespace WinScarvDbObjects
{
    public partial class FrmPrincScarvDbObj : Form
    {
        public FrmPrincScarvDbObj()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            txtPathToSave.Text = ConfigurationManager.AppSettings["pathGuarda"];
            txtOwner.Text = ConfigurationManager.AppSettings["defOwner"];
            txtType.Text = ConfigurationManager.AppSettings["defType"];
            txtDbObjName.Text = ConfigurationManager.AppSettings["defObjName"];
            this.Text = ConfigurationManager.AppSettings["CaptionForm"] + " (" + this.Name + ")";
        }

        private void GuardarArchivo(string pathGuarda, string fname, string codigo)
        {
            try
            {
                string ffname = Path.Combine(pathGuarda, fname);
                File.WriteAllText(ffname, codigo);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SaveListDbsToFile(List<DbObjectBE> pLstDbObjs)
        {
            string codigo = string.Empty;
            OracleMetadataBL oraMetaBL = new OracleMetadataBL();
            string pathGuarda = ConfigurationManager.AppSettings["pathGuarda"];
            string owner = string.Empty;
            string type = string.Empty;
            string objectName = string.Empty;
            string fname = string.Empty;
            string ffname = string.Empty;
            int numLinea = 0;

            foreach (var objDb in pLstDbObjs)
            {
                try
                {
                    if (objDb.Type.CompareTo("PACKAGE BODY") != 0)
                    {
                        fname = objDb.Name + "_" + (objDb.Type.CompareTo("PACKAGE") == 0 ? "PCK" : objDb.Type) + ".sql";
                        // codigo = pckBL.PackageSpecCode(owner, packaName);
                        codigo = oraMetaBL.GetDll(objDb.Owner, objDb.Type, objDb.Name);
                        GuardarArchivo(pathGuarda, fname, codigo);
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(string.Format("Excepcion en linea {0} => ", numLinea + 1) + ex.Message + Environment.NewLine);
                }
                ++numLinea;
            }
        }

        private void tlsStrProcess_Click(object sender, EventArgs e)
        {
            OracleMetadataBL oraMetaBL = new OracleMetadataBL();
            DbObjectBE dbObjBE = new DbObjectBE();
            List<DbObjectBE> lst = new List<DbObjectBE>();
            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                txtResult.Text = string.Empty;
                dbObjBE.Owner = txtOwner.Text;
                dbObjBE.Type = txtType.Text;
                dbObjBE.Name = txtDbObjName.Text;

                oraMetaBL.GetAllDependencies(dbObjBE, lst);

                if (lst != null)
                {
                    foreach (var item in lst)
                    {
                        txtResult.Text += (item.ToString() + Environment.NewLine);
                    }
                    SaveListDbsToFile(lst);
                }
                MessageBox.Show("Proceso finalizado!!!");
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

        private void tlsStrExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
