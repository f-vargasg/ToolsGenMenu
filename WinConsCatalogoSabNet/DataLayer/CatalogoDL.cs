using Oracle.ManagedDataAccess.Client;
using Utilities;

namespace WinConsCatalogoSabNet.DataLayer
{
    class CatalogoDL
    {
        OracleConnection conn;
        
        public CatalogoDL ()
        {
            this.conn = ConnGl.Instance.Conn;
        }

        public OracleDataReader getCatalogoEntries(string pcond)
        {
            OracleDataReader res = null;
            string sql = "SELECT * FROM GE_AMBCATALOGO ";

            sql = sql + (pcond.Length > 0 ? " WHERE " : string.Empty) + pcond;

            res = MyOracleUtils.executeSqlStm(sql, this.conn);

            return res;
        }
        
    }
}
