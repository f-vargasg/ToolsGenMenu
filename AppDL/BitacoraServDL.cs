using Oracle.ManagedDataAccess.Client;
using System;
using Utilities;

namespace AppDL
{
    public class BitacoraServDL
    {
        OracleConnection conn;

        public BitacoraServDL()
        {
            try
            {
                this.conn = ConnGl.Instance.Conn;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public OracleDataReader getBitacoraEntries(string pcond)
        {
            OracleDataReader res = null;
            string sql = "select  a.fec_registro, a.nom_servicio, A.DES_MENSAJE, A.DES_TRANSACCION, a.fec_inicio, a.fec_fin, " +
                         " a.des_ipservidor, a.des_ipcliente, A.COD_DOMINIO_V, A.COD_USUARIO_V " +
                         " from GE_AMBBITACORA A " +
                         (pcond.Length > 0 ? " WHERE " : string.Empty) + pcond +
                         " order by fec_inicio desc";

            System.Console.WriteLine(sql);

            res = MyOracleUtils.executeSqlStm(sql, this.conn);

            return res;
        }


    }
}

