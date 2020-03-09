using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace WinSABDashBoard.DataLayer
{
    class CtlrHoraSabNetDL
    {
        OracleConnection conn;

        public CtlrHoraSabNetDL()
        {
            this.conn = ConnGl.Instance.Conn;
        }

        public CtlrHoraSabNetDL(OracleConnection pconn)
        {
            this.conn = pconn;
        }

        public OracleDataReader getCtlHorariosSabNet ()
        {
            string sql = "SELECT A.COD_PROCESOCTL_V as \"Nom.Proceso\",  " + Environment.NewLine +
                         " A.FEC_ULTEJEC as \"Fec.Ult.Ejecución\", " + Environment.NewLine +
                         " A.USU_CORPROC as \"Usu.Ejecutó\" " + Environment.NewLine +
                         " FROM GE_AMBCTLHORARIO@PRDPBBN04.CONSULTA A " + Environment.NewLine +
                        " WHERE A.COD_PROCESOCTL_V IN ('VENOPER', 'REPVENOPE', 'VENCUST', 'REPVENC') " + Environment.NewLine + 
                        " UNION ALL  " + Environment.NewLine +
                        " SELECT 'Cierre Divsas' as \"Nom.Proceso\",  " + Environment.NewLine  +
                        "   a.FEC_ULTEJEC, a.USU_CORPROC  " + Environment.NewLine +
                        " FROM  GE_CTLHORARIOS@PRDPBBN04.CONSULTA a  " + Environment.NewLine  +
                        "WHERE(a.cod_sistema_v, a.cod_subsist_v, a.cod_proceso)   " + Environment.NewLine  +
                        "    in (('OR', 'OR', 'CIERREDIV'))";
            OracleDataReader dr = MyOracleUtils.executeSqlStm(sql, ConnGl.Instance.Conn);
            return dr;
        }
    }
}
