using AppDL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinTestDbConFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butDo_Click(object sender, EventArgs e)
        {
            OracleMetadata2DL dl = new OracleMetadata2DL();
            string res = string.Empty;
            res = dl.ObtServiceInvoker("E-CU-INVENT-CONSEC");

            txtOutput.Text = res;
        }

        private void butObtCallCSharp_Click(object sender, EventArgs e)
        {
            try
            {
                OracleMetadata2DL dl = new OracleMetadata2DL();
                string res = string.Empty;
                // CU_PINVENTARIO.CONSECUTIVO
                res = dl.ObtCallCSharp("E-CU-INVENT-CONSEC", "servReq", "entName", 1, "MYTEST");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }

        private void butOnlyFunction_Click(object sender, EventArgs e)
        {
            try
            {
                OracleMetadata2DL dl = new OracleMetadata2DL();
                string res = string.Empty;
                res = dl.ObtenerValor(1);
                txtOutput.Text = res;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butExecSp_Click(object sender, EventArgs e)
        {
            try
            {
                OracleMetadata2DL dl = new OracleMetadata2DL();
                string res = string.Empty;
                dl.CargarDatos(1);
                MessageBox.Show("Proc. ejecutado con Exito !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
