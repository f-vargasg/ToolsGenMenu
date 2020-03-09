using AppBE;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using Utilities;

namespace AppDL
{
    public class OracleMetaDataDL
    {
        OracleConnection conn;

        public OracleMetaDataDL()
        {
            this.conn = ConnGl.Instance.Conn;
        }


        /// <summary>
        /// 
        //FUNCTION get_ddl (
        //         object_type     IN  VARCHAR2,
        //         name            IN  VARCHAR2,
        //         schema          IN  VARCHAR2 DEFAULT NULL,
        //         version         IN  VARCHAR2 DEFAULT 'COMPATIBLE',
        //         model           IN  VARCHAR2 DEFAULT 'ORACLE',
        //         transform       IN  VARCHAR2 DEFAULT 'DDL')
        // RETURN CLOB;
        /// </summary>
        /// <param name="pOwner"></param>
        /// <param name="pType"></param>
        /// <param name="pObjectName"></param>
        /// <returns></returns>

        public string GetDll(string pSchema, string pObjectType, string pObjectName)
        {
            string res = string.Empty;
            string wObjType = pObjectType.Replace(' ', '_');
            string wsql = "select dbms_metadata.get_ddl( OBJECT_TYPE => " + MyStringUtils.entreComas(wObjType) +
                          ", NAME =>" + MyStringUtils.entreComas(pObjectName) +
                          ", SCHEMA => " + MyStringUtils.entreComas(pSchema) +
                          " ) as res  from dual";
            OracleDataReader dr = MyOracleUtils.executeSqlStm(wsql, ConnGl.Instance.Conn);
            while (dr.Read())
            {
                res = (Convert.ToString(dr["RES"]));
            }

            return res;
        }


        public DataSet GetDependencies(DbObjectBE pDbObjectBE)
        {
            DataSet res = null;
            string wsql = "select a.referenced_owner, a.referenced_type, a.referenced_name " + Environment.NewLine +
                           "from all_dependencies a " + Environment.NewLine +
                           " where a.owner = " + MyStringUtils.entreComas(pDbObjectBE.Owner) + Environment.NewLine +
                           " and a.type =  " + MyStringUtils.entreComas(pDbObjectBE.Type) + Environment.NewLine +
                           " and a.name = " + MyStringUtils.entreComas(pDbObjectBE.Name) + Environment.NewLine;
            try
            {
                res = MyOracleUtils.executeSqlStmDs(wsql, this.conn);
            }
            catch (Exception)
            {

                throw;
            }


            return res;

        }

        string ObtServiceInvoker(string pServiceName)
        {
            DataSet ds = null;
            string res = string.Empty;
            string wSql = string.Empty;

            try
            {
                wSql = "SELECT A.DES_INVOCADOR  " + Environment.NewLine +
                       " FROM GE_AMBCATALOGO A " + Environment.NewLine +
                       " WHERE A.NOM_SERVICIO = " + MyStringUtils.entreComas(pServiceName);
                ds = MyOracleUtils.executeSqlStmDs(wSql, this.conn);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    res = Convert.ToString(dr["DES_INVOCADOR"]);
                }

            }
            catch (Exception)
            {

                throw;
            }

            return res;
        }

        public string ObtCallCSharp(string pSerViceName,
                              string pServiceRequest,
                              string pEntityName,
                              int pIndentityParamN,
                              string pDbOwner)
        {
            string res = string.Empty;
            string invoker = string.Empty;
            string packageName = string.Empty;
            string methodName = string.Empty;
            string[] scrap;
            object objRes;
            try
            {
                invoker = ObtServiceInvoker(pSerViceName);
                if (invoker.Length > 0)
                {
                    scrap = invoker.Split('.');
                    packageName = scrap[0];
                    methodName = scrap[1];
                    List<OracleParameter> lst = new List<OracleParameter>();
                    OracleParameter param = new OracleParameter("PPACKAGENAME", OracleDbType.Varchar2, 100);
                    param.Value = packageName;
                    lst.Add(param);

                    param = new OracleParameter("PSPPROCNAME", OracleDbType.Varchar2, 100);
                    param.Value = methodName;
                    lst.Add(param);

                    param = new OracleParameter("PSERVICEREQUESTID", OracleDbType.Varchar2, 100);
                    param.Value = string.Empty;
                    lst.Add(param);

                    param = new OracleParameter("PSERVICENAME", OracleDbType.Varchar2, 500);
                    param.Value = pSerViceName;
                    lst.Add(param);

                    param = new OracleParameter("PENTITYNAME", OracleDbType.Varchar2, 100);
                    param.Value = pEntityName;
                    lst.Add(param);

                    param = new OracleParameter("PINDENTITYPARAM_N", OracleDbType.Int32, 100);
                    param.Value = pIndentityParamN;
                    lst.Add(param);

                    param = new OracleParameter("POWNER", OracleDbType.Varchar2, 100);
                    param.Value = pDbOwner;
                    lst.Add(param);
                    objRes = MyOracleUtils.execOracleSf2("GE_PAMBCSHARPGEN.getCallService", lst, OracleDbType.Clob, this.conn);

                    res = ((OracleClob)objRes).Value;    
                }
                
            }
            catch (Exception)
            {

                throw;
            }


            return res;
        }


        public DataSet GetSqlTblMetaData(string pOwner, string pTableName,
                                      string pVarRow, string pVarEntiName)
        {
            DataSet ds = null;
            string sql;
            
            try
            {

                List<OracleParameter> lst = new List<OracleParameter>();
                OracleParameter param = new OracleParameter("POWNER", OracleDbType.Varchar2, 100);
                param.Value = pOwner;
                lst.Add(param);

                param = new OracleParameter("pTableName", OracleDbType.Varchar2, 100);
                param.Value = pTableName;
                lst.Add(param);

                param = new OracleParameter("pVarRow", OracleDbType.Varchar2, 100);
                param.Value = pVarRow;
                lst.Add(param);

                param = new OracleParameter("pVarEntityName", OracleDbType.Varchar2, 500);
                param.Value = pVarEntiName;
                lst.Add(param);

                param = new OracleParameter("pcur", OracleDbType.RefCursor, 100);
                param.Direction = ParameterDirection.Output;
                lst.Add(param);

                OracleCommand oraCmd = MyOracleUtils.execOracleSp2(" ME_pORAMETADATA.ObtieneOracleMeta", lst, this.conn);
                //((OracleRefCursor)p1.Value).GetDataReader()
                OracleDataReader dr = ((OracleRefCursor )( oraCmd.Parameters["pcur"].Value)).GetDataReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                ds = new DataSet();
                ds.Tables.Add(dt);
                
            }
            catch (Exception)
            {

                throw;
            }
            return ds;
        }


        public string ObtDiaSemana(DateTime pdate)
        {
            const string LexFmtDate = "<%fecFormyyyy-MM-dd>";
            string res = string.Empty;
            string sql = "SELECT '" + LexFmtDate + "' as fec,  TO_CHAR(date '"
                        + LexFmtDate + "', 'DAY') diaSemana" + Environment.NewLine +
                         "FROM dual";
            string scrap = pdate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            sql = sql.Replace(LexFmtDate, scrap);

            DataSet ds = MyOracleUtils.executeSqlStmDs(sql, this.conn);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                res = Convert.ToString(dr["diaSemana"]);
            }


            return res;
        }

    }
}
