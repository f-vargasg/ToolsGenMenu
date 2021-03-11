using AppBE;
using AppBL;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Windows.Forms;

namespace WinUtiles
{
    public partial class FrmPrincipal : Form
    {
        private bool hideExitButton;

        public FrmPrincipal()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            txtServName.Text = ConfigurationManager.AppSettings["defServiceName"];
            txtDbOwner.Text = ConfigurationManager.AppSettings["dbOwner"];
            txtEntityName.Text = "entTest";
            txtEntityOption.Text = "0";


            txtOwner.Text = ConfigurationManager.AppSettings["dbOwner"];
            txtTableName.Text = "GE_BITACENVIO";
            txtVarRow.Text = "dr";
            txtEntityName1.Text = "wBitacEnvio";

            this.hideExitButton = Convert.ToBoolean(ConfigurationManager.AppSettings["hideExitButton"]);
            var btnRead = tlStripOptions.Items.Find("tlStrpSalir", true);  // get BtnRead on toolstrip Item.Find
            btnRead[0].Visible = !this.hideExitButton; // disable/Enable btn

        }

        private void tlStrpSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tlsButExecute_Click(object sender, EventArgs e)
        {
            // OracleMetadataDL meta = new OracleMetadataDL();
            OracleMetadataBL ometaBL = new OracleMetadataBL();
            // string scrap;
            try
            {
                if (tblPrinc.SelectedTab == tblPrinc.TabPages["tblOraMetadata"])
                {
                    List<OracleMetadataBE> lst = ometaBL.GetSqlTblMetaData(txtOwner.Text.ToUpper(), txtTableName.Text.ToUpper(),
                                                      txtVarRow.Text, txtEntityName1.Text);
                    dgrCode.DataSource = lst;
                    /*  DataSet ds = meta.sqlTblMetaData(txtOwner.Text.ToUpper(), txtTableName.Text.ToUpper(), 
                                                        txtVarRow.Text, txtEntityName1.Text);
                      dgrCode.DataSource = ds.Tables[0]; */

                }
                else
                {
                    
                    string scrap = ometaBL.ObtCallCSharp(txtServName.Text, txtServName.Text, txtEntityName.Text,
                                               Convert.ToInt32(txtEntityOption.Text), txtDbOwner.Text); 
                    txtCSharpInvok.Text = scrap; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tlsButAskWeekDay_Click(object sender, EventArgs e)
        {
            try
            {
                //  OracleMetadataDL oraMeta = new OracleMetadataDL();
                string scrap = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                string fecStr = Interaction.InputBox("Fecha", "Obtener Dia de la Semana", scrap, -1, -1);
                if (fecStr.CompareTo(string.Empty) != 0)
                {
                    DateTime tmpDate = DateTime.ParseExact(fecStr, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    //string dateWeek = oraMeta.ObtDiaSemana(tmpDate);

                    // MessageBox.Show(dateWeek);                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
