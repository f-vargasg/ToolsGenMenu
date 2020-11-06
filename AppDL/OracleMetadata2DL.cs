using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Text;
using Utilities;

namespace AppDL
{
    public class OracleMetadata2DL : DataWorker
    {
        public string ObtServiceInvoker(string pServiceName)
        {
            //DataSet ds = null;
            string res = string.Empty;
            string wSql = string.Empty;
            wSql = "SELECT A.DES_INVOCADOR  " + Environment.NewLine +
                   " FROM GE_AMBCATALOGO A " + Environment.NewLine +
                   " WHERE A.NOM_SERVICIO = " + MyStringUtils.entreComas(pServiceName);


            using (DbConnection connection = database.CreateOpenConnection())
            {
                using (DbCommand command = database.CreateCommand(wSql, connection))
                {
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            res = Convert.ToString(reader["DES_INVOCADOR"]);
                        }
                    }
                }
            }

            return res;
        }


        public string ObtenerValor(int pcod_cliente_N)
        {
            string res = string.Empty;

            try
            {

                using (DbConnection connection = database.CreateOpenConnection())
                {
                    using (DbCommand command = database.CreateStoredProcCommand("pckTest.OBTVALOR3", connection))
                    {
                        // add parameters


                        //PPACKAGENAME

                        DbParameter param1;
                        param1 = database.CreateParameter("Return_Value", DbType.String, ParameterDirection.ReturnValue);
                        param1.Direction = ParameterDirection.ReturnValue;
                        //param1.DbType = DbType.String;
                        command.Parameters.Add(param1);

                        IDataParameter param;
                        param = database.CreateParameter("pcod_cliente_n", pcod_cliente_N);
                        command.Parameters.Add(param);

                        command.ExecuteNonQuery();
                        // res = Convert.ToString (param1.Value);
                        res = (string)param1.Value;

                         //res = Convert.ToString(Convert.ToString(command.Parameters["Return_value"]));
                    }
                }
            }

            catch (Exception)
            {
                throw;
            }


            return res;
        }

        public void CargarDatos(int pcod_cliente_N)
        {
            string res = string.Empty;

            try
            {

                using (DbConnection connection = database.CreateOpenConnection())
                {
                    using (DbCommand command = database.CreateStoredProcCommand("pckTest.CargarDatos", connection))
                    {
                        // add parameters


                        //PPACKAGENAME 
                        IDataParameter param;


                        param = database.CreateParameter("pcod_cliente_n", pcod_cliente_N);
                        command.Parameters.Add(param);
                        command.ExecuteNonQuery();

                        // res = Convert.ToString(command.ExecuteScalar());
                    }
                }
            }

            catch (Exception)
            {
                throw;
            }
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
            try
            {
                invoker = ObtServiceInvoker(pSerViceName);
                scrap = invoker.Split('.');
                packageName = scrap[0];
                methodName = scrap[1];

                using (DbConnection connection = database.CreateOpenConnection())
                {
                    using (DbCommand command = database.CreateStoredProcCommand("GE_PAMBCSHARPGEN.GETCALLSERVICE", connection))
                    {
                        // add parameters


                                                                       //PPACKAGENAME 
                        IDataParameter param /*= database.CreateParameter("Return_Value", string.Empty);
                        command.Parameters.Add(param) */;

                        param = database.CreateParameter("PPACKAGENAME", packageName);
                        command.Parameters.Add(param);
                                                        //PSPPROCNAME 
                        param = database.CreateParameter("PSPPROCNAME", methodName);
                        command.Parameters.Add(param);
                                                        //PSERVICEREQUESTID 
                        param = database.CreateParameter("PSERVICEREQUESTID", string.Empty);
                        command.Parameters.Add(param);

                                                        //PSERVICENAME 
                        param = database.CreateParameter("PSERVICENAME", pSerViceName);
                        command.Parameters.Add(param);
                                                                //PENTITYNAME 
                        param = param = database.CreateParameter("PENTITYNAME", pEntityName);
                        command.Parameters.Add(param);
                                                                //PINDENTITYPARAM_N 
                        param = param = database.CreateParameter("PINDENTITYPARAM_N", pIndentityParamN);
                        command.Parameters.Add(param);

                                                                //POWNER 
                        param = param = database.CreateParameter("POWNER", pDbOwner);
                        command.Parameters.Add(param);

                        //command.ExecuteNonQuery();

                        res = Convert.ToString(command.ExecuteScalar());
                    }
                }
            }

            catch (Exception)
            {
                throw;
            }


            return res;
        }


        public DataSet sqlTblMetaData(string pOwner, string pTableName,
                                      string pVarRow, string pVarEntiName)
        {
            DataSet ds = null;
            string sql;
            /*
            try
            {
                sql = "select  reg.column_name || ',' as  \"Lista Columnas\",  " + Environment.NewLine +
                        "       'p' || reg.COLUMN_NAME || ' IN ' || REG.DATA_TYPE  || ';' AS \"Pl/Sql Params\", " + Environment.NewLine +
                        "       reg.csharpType || ' ' || reg.csharpMemberVar ||  ';' as \"Csharp Member Class\", " + Environment.NewLine +
                        "       '" + pVarEntiName + ".' || reg.CSHARPATRIBUTE || ' =  ' ||  " + Environment.NewLine +
                        "       (case when reg.csharptype = 'int'  then '0'  " + Environment.NewLine +
                        "           when reg.csharptype = 'DateTime'  then 'DateTime.Now' " + Environment.NewLine +
                        "           when reg.csharptype = 'string' or reg.CSHARPTYPE = 'clob'  then 'string.Empty' " + Environment.NewLine +
                        "           when reg.csharptype = 'object'  then 'null' " + Environment.NewLine +
                        "          else  " + Environment.NewLine +
                        "            'null'  " + Environment.NewLine +
                        "         end) || ';' as \"fill2Entity\", " + Environment.NewLine +
                        "                '" + pVarEntiName + ".' || reg.CSHARPATRIBUTE || ' =  ' || " + Environment.NewLine +
                        "       (case when reg.csharptype = 'int'  then 'Convert.ToInt32(" + pVarRow + "[\"' || reg.COLUMN_NAME || '\"])'   " + Environment.NewLine +
                        "           when reg.csharptype = 'DateTime'  then 'Convert.ToDateTime( + pVarRow + [\"' || reg.COLUMN_NAME || '\"])' " + Environment.NewLine +
                        "           when reg.csharptype = 'string' or reg.CSHARPTYPE = 'clob'  then 'Convert.ToString( + pVarRow + [\"' || reg.COLUMN_NAME || '\"])' " + Environment.NewLine +
                        "           when reg.csharptype = 'object'  then 'null' " + Environment.NewLine +
                        "          else  " + Environment.NewLine +
                        "            'null'  " + Environment.NewLine +
                        "         end) || ';' as \"fillEntityFromDataRow\", " + Environment.NewLine +
                        "         (case when reg.csharptype = 'int'  then 'txt'  " + Environment.NewLine +
                        "           when reg.csharptype = 'DateTime'  then 'dtp' " + Environment.NewLine +
                        "           when reg.csharptype = 'string' or reg.CSHARPTYPE = 'clob'  then 'txt'" + Environment.NewLine +
                        "           when reg.csharptype = 'object'  then 'txt' " + Environment.NewLine +
                        "          else  " + Environment.NewLine +
                        "            'null'  " + Environment.NewLine +
                        "         end) || reg.CSHARPATRIBUTE || '.' || (case when reg.csharptype = 'int'  then 'Text'  " + Environment.NewLine +
                        "                                   when reg.csharptype = 'DateTime'  then 'Value' " + Environment.NewLine +
                        "                                   when reg.csharptype = 'string' or reg.CSHARPTYPE = 'clob'  then 'Text' " + Environment.NewLine +
                        "                                   when reg.csharptype = 'object'  then 'Text' " + Environment.NewLine +
                        "                                  else  " + Environment.NewLine +
                        "                                    'null'  " + Environment.NewLine +
                        "                                 end) || ' =  ' ||  " + Environment.NewLine +
                        "         'Convert.ToString ('/* ||  " + Environment.NewLine +
                        "         (case when reg.csharptype = 'int'  then 'Int32('  " + Environment.NewLine +
                        "                                   when reg.csharptype = 'ToDateTime'  then '' " + Environment.NewLine +
                        "                                   when reg.csharptype = 'string' or reg.CSHARPTYPE = 'clob'  then 'String' " + Environment.NewLine +
                        "                                   --when reg.csharptype = 'object'  then 'Text' " + Environment.NewLine +
                        "                                  else  " + Environment.NewLine +
                        "                                    NULL  " + Environment.NewLine +
                        "                                 end) */  /*" + Environment.NewLine +
                        "         || '" + pVarEntiName + "' || reg.CSHARPATRIBUTE   || ');' as \"fil2lUi\", " + Environment.NewLine +
                        "         reg.CSHARPATRIBUTE   " + Environment.NewLine +
                        "from (select    A.COLUMN_NAME, " + Environment.NewLine +
                        "          a.DATA_TYPE, " + Environment.NewLine +
                        "          a.DATA_LENGTH, " + Environment.NewLine +
                        "          a.data_precision, " + Environment.NewLine +
                        "          a.data_scale,  " + Environment.NewLine +
                        "          lower (substr( A.column_name, 1, 1)) ||  replace( substr(initcap(lower(A.column_name)), 2, length(A.column_name) -1 ), '_') as csharpMemberVar," + Environment.NewLine +
                        "          upper (substr( A.column_name, 1, 1)) ||  replace( substr(initcap(lower(A.column_name)), 2, length(A.column_name) -1 ), '_') as csharpAtribute," + Environment.NewLine +
                        "          (case when a.data_type = 'NUMBER' then 'int' " + Environment.NewLine +
                        "                when a.data_type = 'DATE' then 'DateTime' " + Environment.NewLine +
                        "                when a.data_type = 'VARCHAR2' then 'string' else 'object' end) as csharptype " + Environment.NewLine +
                        "--, A.DATA_TYPE, A.DATA_PRECISION, A.DATA_SCALE,a.DATA_LENGTH " + Environment.NewLine +
                        "from ALL_TAB_COLUMNS a " + Environment.NewLine +
                        "where a.table_name = '" + pTableName + "' " + Environment.NewLine +
                        "AND a.OWNER = '" + pOwner + "' " + Environment.NewLine +
                        "ORDER BY a.COLUMN_ID) reg " + Environment.NewLine;
                ds = MyOracleUtils.executeSqlStmDs(sql, this.conn);
            }
            catch (Exception)
            {

                throw;
            }*/
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


            using (DbConnection connection = database.CreateOpenConnection())
            {
                using (DbCommand command = database.CreateCommand(sql, connection))
                {
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           Console.WriteLine(reader["diaSemana"]);
                           res = Convert.ToString(reader["diaSemana"]);
                        }
                    }
                }
            }
            return res;

            /*
            DataSet ds = MyOracleUtils.executeSqlStmDs(sql, this.conn);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                res = Convert.ToString(dr["diaSemana"]);
            }


            return res;*/
        }
    }
}
