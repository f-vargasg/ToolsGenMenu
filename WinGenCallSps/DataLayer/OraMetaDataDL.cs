using Oracle.ManagedDataAccess.Client;
using System;
using Utilities;

namespace WinGenCallSps.DataLayer
{
    public class OraMetaDataDL
    {
        OracleConnection conn;

        public OraMetaDataDL()
        {
            this.conn = ConnGl.Instance.Conn;
        }

        public string getCallPlSqlStm (string packageName, string methodName, string schemaDb)
        {
            OracleDataReader dr;
            string res = string.Empty ;
            bool wft = true;
            dr = getOraMetaParamsSp(packageName, methodName, schemaDb);
            while (dr.Read())
            {
                if (dr["argument_name"].ToString().Length > 0 ) // the functions has the 
                {
                    res += (wft ? dr["package_name"] + "." + dr["object_name"] + "(" :
                        string.Empty) + (wft ? string.Empty : ",") + Environment.NewLine +
                                         dr["argument_name"] + " => " + dr["argument_name"].ToString().Trim();
                    wft = false;                    
                }

            }

            res += ( res.Length > 0 ?  ");" : string.Empty);
            return res;
        }

        private OracleDataReader getOraMetaParamsSp(string packageName, string methodName, string schemaDb)
        {
            OracleDataReader res = null;
            string sql = "SELECT  A.package_name , A.object_name ,A.argument_name, A.data_type, A.in_out " + Environment.NewLine +
                            "FROM all_arguments A " + Environment.NewLine +
                            "WHERE package_name  = " + MyStringUtils.entreComas(packageName.ToUpper()) + Environment.NewLine +
                            "AND   object_name = " + MyStringUtils.entreComas(methodName.ToUpper()) + Environment.NewLine +
                            "AND  OWNER = " + MyStringUtils.entreComas(schemaDb).Trim() + Environment.NewLine +
                           " ORDER BY POSITION";

            res= MyOracleUtils.executeSqlStm(sql, this.conn);
            return res;
        }
    }
}
