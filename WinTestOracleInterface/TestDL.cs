using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using Utilities;

namespace WinTestOracleInterface
{
    public class TestDL
    {
        OracleConnection conn;

        public TestDL()
        {
            this.conn = ConnGl.Instance.Conn;
        }




        public string ObtenerValor(int pcod_cliente_N)
        {
            List<OracleParameter> lst = new List<OracleParameter>();
            string res = string.Empty;

            try
            {
                // add parameters
                OracleParameter param;
                param = new OracleParameter("pcod_cliente_n", OracleDbType.Int32);
                param.Value = 10;
                lst.Add(param);
                OracleClob data = (OracleClob)MyOracleUtils.execOracleSf2("pckTest.ObtValor3", lst, OracleDbType.Clob, this.conn);

                res = (string)data.Value;
            }

            catch (Exception)
            {
                throw;
            }


            return res;
        }

        public void CargarDatos(int pcod_cliente_N)
        {
            List<OracleParameter> lst = new List<OracleParameter>();
            string res = string.Empty;

            try
            {
                OracleParameter param = new OracleParameter("pcod_cliente_n", pcod_cliente_N);
                param.Value = 10;
                lst.Add(param);
                MyOracleUtils.execOracleSp2("pcktest.CargarDatos", lst, this.conn);
                
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
                /*
                invoker = ObtServiceInvoker(pSerViceName);
                scrap = invoker.Split('.');
                packageName = scrap[0];
                methodName = scrap[1];

                using (IDbConnection connection = database.CreateOpenConnection())
                {
                    using (IDbCommand command = database.CreateStoredProcCommand("GE_PAMBCSHARPGEN.GETCALLSERVICE", connection))
                    {
                        // add parameters


                        //PPACKAGENAME 
                        IDataParameter param /*= database.CreateParameter("Return_Value", string.Empty);
                        command.Parameters.Add(param) */
                ;
                /*
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
                */
                res = null;
            }
            catch (Exception)
            {
                throw;
            }


            return res;
        }
    }
}
