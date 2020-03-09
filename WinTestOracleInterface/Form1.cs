using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinTestOracleInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butExecSp_Click(object sender, EventArgs e)
        {
            try
            {
                TestDL ts = new TestDL();
                ts.CargarDatos(2);
                MessageBox.Show("Proced. Ejecutado");
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
                TestDL ts = new TestDL();
                 string res =  ts.ObtenerValor(2);
                MessageBox.Show("funcion Ejecutada. resultado " + res); // dafasfafasfa
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
