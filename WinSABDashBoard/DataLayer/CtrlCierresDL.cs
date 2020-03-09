using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace WinSABDashBoard.DataLayer
{
    class CtrlCierresDL
    {
        OracleConnection conn;

        public CtrlCierresDL()
        {
            this.conn = ConnGl.Instance.Conn;
        }

        public CtrlCierresDL(OracleConnection pconn)
        {
            this.conn = pconn;
        }

        public OracleDataReader getCierres()
        {
            string sql = "SELECT -- sis.DES_SISTEMA as \"Sistema\", " + Environment.NewLine +
                           "sis.des_subsist as \"Sub Sistema\", " + Environment.NewLine +
                           "cie.FEC_ULTCIER as \"Fec.Ult.Cierre\", " + Environment.NewLine +
                           "cie.FEC_PROXHAB as \"Fec.Sistema\", " + Environment.NewLine +
                           "cie.FEC_MODESTA as \"Fec.Realiza Cierre\", " + Environment.NewLine +
                           "cie.USU_MODESTA as \"Usu.Realiza\" " + Environment.NewLine +
                           "FROM ge_concierre@PRDPBBN04.CONSULTA cie, " + Environment.NewLine +
                           "     SE_SISTEMAS @PRDPBBN04.CONSULTA sis " + Environment.NewLine +
                           "where cie.COD_SISTEMA_V = sis.COD_SISTEMA_V AND " + Environment.NewLine +
                           "cie.COD_SUBSIST_V = sis.COD_SUBSIST_V";
            OracleDataReader dr = MyOracleUtils.executeSqlStm(sql, ConnGl.Instance.Conn);
            return dr;
        }
    }
}
