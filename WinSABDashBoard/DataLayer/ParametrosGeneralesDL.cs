using Oracle.ManagedDataAccess.Client;
using System;
using Utilities;

namespace WinSABDashBoard.DataLayer
{
    class ParametrosGeneralesDL
    {
         OracleConnection conn;

        public ParametrosGeneralesDL()
        {
            this.conn = ConnGl.Instance.Conn;
        }

        public ParametrosGeneralesDL(OracleConnection pconn)
        {
            this.conn = pconn;
        }

        public OracleDataReader getParametros ()
        {
            string sql = "Select  DES_PARAMETRO as \"Proceso\", VAL_PARAMETRO as \"Fec.Referencia\" " + Environment.NewLine +
                       " from GE_AMBPARAMETRO@PRDPBBN04.CONSULTA a " + Environment.NewLine +
                       " where A.COD_PARAMETRO_V in ('APLOPERT', 'CIERRECONT','UFCARPRE')";
            OracleDataReader dr = MyOracleUtils.executeSqlStm(sql, ConnGl.Instance.Conn);

            return dr;
        }


    }
}
