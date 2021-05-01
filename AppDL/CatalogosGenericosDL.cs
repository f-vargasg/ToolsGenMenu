using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using Utilities;

namespace AppDL
{
    public class CatalogosGenericosDL
    {
        OracleConnection conn;

        public CatalogosGenericosDL()
        {
            this.conn = ConnGl.Instance.Conn;
        }

        public DataSet GetTiposSpsRetorno()
        {
            DataSet res = null;
            string sql = "SELECT " + Environment.NewLine + 
                          "cod_tipretorno_n as codigo, " + Environment.NewLine + 
                          "des_tipretorno as descripcion  " + Environment.NewLine + 
                          "FROM ge_ambtipretorno";
            res = MyOracleUtils.executeSqlStmDs(sql, this.conn);
            return res;
        }

        public DataSet GetTiposServicios()
        {

            DataSet res = null;

            try
            {
                string sql = "SELECT cod_tipservicio_n as codigo, " + Environment.NewLine +
                             "des_tipservicio as descripcion " + Environment.NewLine  + 
                             "FROM ge_ambtipservicio";
                res = MyOracleUtils.executeSqlStmDs(sql, this.conn);

            }
            catch (Exception)
            {

                throw;
            }
            return res;
        }

        public DataSet GetObjetoProp ()
        {
            DataSet res = null;
            try
            {
                string sql = "SELECT cod_objprop_n as codigo, " + Environment.NewLine + 
                             "des_objprop || ' - ' || des_objdb as descripcion " + Environment.NewLine + 
                             "FROM    ge_ambobjprop " + Environment.NewLine + 
                             "ORDER BY DES_OBJPROP";
                res = MyOracleUtils.executeSqlStmDs(sql, this.conn);
            }
            catch (Exception)
            {
                
                throw;
            }
            return res;
        }


        public DataSet GetCodModulo()
        {
            DataSet res = null;
            try
            {
                string sql = "select reg.cod_modulo_n as Codigo, 'Modulo ' || to_char (cod_modulo_n) as descripcion "+ Environment.NewLine  +
                              " from (select distinct cod_modulo_n from ge_ambcatalogo) reg";
                res = MyOracleUtils.executeSqlStmDs(sql, this.conn);
            }
            catch (Exception)
            {

                throw;
            }
            return res;
        }

        public DataSet GetAccionServicio()
        {
            DataSet res = null;
            try
            {
                string sql = "SELECT cod_accserv_n as codigo, " + Environment.NewLine +
                             " des_accserv  as descripcion " + Environment.NewLine +
                             " FROM ge_ambaccserv " + Environment.NewLine +
                             " ORDER BY DES_ACCSERV";
                res = MyOracleUtils.executeSqlStmDs(sql, this.conn);
            }
            catch (Exception)
            {

                throw;
            }
            return res;
        }
    }
}
