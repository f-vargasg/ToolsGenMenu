using AppBE;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using Utilities;

namespace AppDL
{
    public class CatalogoServDL : DataWorker
    {
        OracleConnection conn;
        BitObjetoDL bitObjDL;

        public CatalogoServDL()
        {
            this.conn = ConnGl.Instance.Conn;
            this.bitObjDL = new BitObjetoDL();
        }

        public void Insertar(CatalogoServBE pCatSrvBE)
        {
           

            pCatSrvBE.CodRegistroN = bitObjDL.ObtenerCodRegistro();

            string wsql = "Insert into GE_AMBCATALOGO (" + Environment.NewLine +
                             "COD_SERVICIO_N, COD_TIPRETORNO_N,COD_OBJPROP_N,COD_TIPSERVICIO_N, " + Environment.NewLine +
                             "COD_ACCSERV_N,NOM_SERVICIO,IND_ATOMSERV_V,COD_MODULO_N, " + Environment.NewLine +
                             "DES_SERVICIO, NUM_CACHE,DES_INVOCADOR,COD_REGISTRO_N, " + Environment.NewLine +
                             "COD_ESTADO_N,IND_LOGUEO,IND_PUBLICO,DES_ESQUEMA) " + Environment.NewLine +
                          "values (" + Environment.NewLine +
                             pCatSrvBE.CodServicioN.ToString() + ", " + pCatSrvBE.CodTipretornoN.ToString() + ", " +
                            pCatSrvBE.CodObjpropN.ToString() + ", " + pCatSrvBE.CodTipservicioN.ToString() + ", " +
                            pCatSrvBE.CodAccservN.ToString() + ", " + MyStringUtils.entreComas(pCatSrvBE.NomServicio) + ", " +
                            MyStringUtils.entreComas(pCatSrvBE.IndAtomservV) + ", " + pCatSrvBE.CodModuloN.ToString() + ", " +
                            MyStringUtils.entreComas(pCatSrvBE.DesServicio) + ", " + pCatSrvBE.NumCache.ToString() + ", " +
                            MyStringUtils.entreComas(pCatSrvBE.DesInvocador) + ", " + pCatSrvBE.CodRegistroN.ToString() +
                            ", " + pCatSrvBE.CodEstadoN.ToString() + ", " + pCatSrvBE.IndLogueo.ToString() + ", " +
                            pCatSrvBE.IndPublico.ToString() + ", " + "'" + pCatSrvBE.DesEsquema + "')";
            MyOracleUtils.execOracleStm(wsql, this.conn);

            /*
             * GE_PAMBBITOBJETO.registrar(pcod_accionreg_n     => 1,
                               pdes_tabla           => 'GE_AMBDOCUMENTO',
                               pcod_registro_n      => wcod_registro,
                               pcod_usuario_v       => pCOD_USUARIOREG_V);
             * */
            string usuario = Environment.UserName;
            bitObjDL.Registrar(1, "GE_AMBCATALOGO", pCatSrvBE.CodRegistroN, usuario);

        }


        public void Modificar(CatalogoServBE pCatSrvBE)
        {
            string sql = string.Empty;

            decimal codRegistroN = ObtenerCodRegistro(pCatSrvBE.CodServicioN);   
                
             sql =  "update GE_AMBCATALOGO SET " + Environment.NewLine +
              "COD_TIPRETORNO_N     = " + Convert.ToString(pCatSrvBE.CodTipretornoN) + "," + Environment.NewLine +
              "COD_OBJPROP_N        = " + Convert.ToString(pCatSrvBE.CodObjpropN) + "," + Environment.NewLine +
              "COD_TIPSERVICIO_N    = " + Convert.ToString(pCatSrvBE.CodTipservicioN) + "," + Environment.NewLine +
              "COD_ACCSERV_N        = " + Convert.ToString(pCatSrvBE.CodAccservN) + "," + Environment.NewLine +
              "NOM_SERVICIO         = " + MyStringUtils.entreComas(pCatSrvBE.NomServicio) + "," + Environment.NewLine +
              "IND_ATOMSERV_V       = " + MyStringUtils.entreComas(pCatSrvBE.IndAtomservV) + "," + Environment.NewLine +
              "COD_MODULO_N         = " + Convert.ToString(pCatSrvBE.CodModuloN) + "," + Environment.NewLine +
              "DES_SERVICIO         = " + MyStringUtils.entreComas(pCatSrvBE.DesServicio) + "," + Environment.NewLine +
              "NUM_CACHE            = " + Convert.ToString(pCatSrvBE.NumCache) + "," + Environment.NewLine +
              "DES_INVOCADOR        = " + MyStringUtils.entreComas(pCatSrvBE.DesInvocador) + "," + Environment.NewLine +
              "COD_REGISTRO_N       = " + Convert.ToString(pCatSrvBE.CodRegistroN) + "," + Environment.NewLine +
              "COD_ESTADO_N         = " + Convert.ToString(pCatSrvBE.CodEstadoN) + "," + Environment.NewLine +
              "IND_LOGUEO           = " + Convert.ToString(pCatSrvBE.IndLogueo) + "," + Environment.NewLine +
              "IND_PUBLICO          = " + Convert.ToString(pCatSrvBE.IndPublico) + "," + Environment.NewLine +
              "DES_ESQUEMA          = " + MyStringUtils.entreComas(pCatSrvBE.DesEsquema)  + Environment.NewLine +
              "WHERE COD_SERVICIO_N  = " + Convert.ToString(pCatSrvBE.CodServicioN);
            MyOracleUtils.execOracleStm(sql, this.conn);
            string usuario = Environment.UserName;
            bitObjDL.Registrar(2, "GE_AMBCATALOGO", codRegistroN, usuario);
        }

        public decimal ObtenerCodRegistro(decimal pCodServicioN)
        {
            decimal res = 0;
            string sql = "Select a.cod_registro_n " + Environment.NewLine +
                          "FROM GE_AMBCATALOGO a " + Environment.NewLine +
                          "WHERE A.COD_SERVICIO_N = " + Convert.ToString(pCodServicioN);
            DataSet ds = null;
            ds = MyOracleUtils.executeSqlStmDs(sql, this.conn);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                res = Convert.ToDecimal(dr["COD_REGISTRO_N"]);
            }
            return res;

        }

        public void Borrar(decimal pCodServicioN)
        {
            decimal codRegistroN = ObtenerCodRegistro(pCodServicioN);

            string wsql = "delete from ge_ambcatalogo " + Environment.NewLine +
                           "where cod_servicio_n = " + Convert.ToString(pCodServicioN);
            MyOracleUtils.execOracleStm(wsql, this.conn);
            string usuario = Environment.UserName;
            bitObjDL.Registrar(3, "GE_AMBCATALOGO", codRegistroN, usuario);
        }

        public List<CatalogoServBE> GetList()
        {
            /*
            DataSet res = null;
            string sql = "Select a.* " + Environment.NewLine +
                         "from  Ge_ambcatalogo a " + Environment.NewLine +
                         "Order by a.cod_servicio_n desc";
            res = MyOracleUtils.executeSqlStmDs(sql, this.conn);
            return res;
            */
            string sql = "Select a.* " + Environment.NewLine +
                         "from  Ge_ambcatalogo a " + Environment.NewLine +
                         "Order by a.cod_servicio_n desc";
            List<CatalogoServBE> res = new List<CatalogoServBE>();

            using (DbConnection connection = database.CreateOpenConnection())
            {
                using (DbCommand command = database.CreateCommand(sql, connection))
                {
                    using (IDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            CatalogoServBE catSrvBe = new CatalogoServBE();
                            catSrvBe.CodServicioN = Convert.ToInt32(dr["COD_SERVICIO_N"]);
                            catSrvBe.CodTipretornoN = Convert.ToInt32(dr["COD_TIPRETORNO_N"]);
                            catSrvBe.CodObjpropN = Convert.ToInt32(dr["COD_OBJPROP_N"]);
                            catSrvBe.CodTipservicioN = Convert.ToInt32(dr["COD_TIPSERVICIO_N"]);
                            catSrvBe.CodAccservN = Convert.ToInt32(dr["COD_ACCSERV_N"]);
                            catSrvBe.NomServicio = Convert.ToString(dr ["NOM_SERVICIO"]);
                            catSrvBe.IndAtomservV = Convert.ToString(dr["IND_ATOMSERV_V"]);
                            catSrvBe.CodModuloN = Convert.ToInt32(dr["COD_MODULO_N"]);
                            catSrvBe.DesServicio = Convert.ToString(dr ["DES_SERVICIO"]);
                            catSrvBe.NumCache = Convert.ToInt32(dr["NUM_CACHE"]);
                            catSrvBe.DesInvocador = null;
                            catSrvBe.CodRegistroN = Convert.ToDecimal(dr["COD_REGISTRO_N"]);
                            catSrvBe.CodEstadoN = Convert.ToInt32(dr["COD_ESTADO_N"]);
                            catSrvBe.IndLogueo = Convert.ToInt32(dr["IND_LOGUEO"]);
                            catSrvBe.IndPublico = Convert.ToInt32(dr["IND_PUBLICO"]);
                            catSrvBe.DesEsquema = null;
                            res.Add(catSrvBe);
                        }
                    }
                }
            }
            return res;
        }

        public decimal NewCodServicio()
        {
            decimal res = 0;
            string sql = "select nvl (max (a.cod_servicio_n), 0) + 1 as res " + Environment.NewLine +
                          "from ge_ambcatalogo a";

            DataSet ds = null;
            ds = MyOracleUtils.executeSqlStmDs(sql, this.conn);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                res = Convert.ToDecimal(dr["res"]);
            }

            return res;

        }

        public void GetServiceDataByPk(decimal p, CatalogoServBE catalogoServBE)
        {
            string sql = "select a.* " + Environment.NewLine +
               "from ge_ambcatalogo a " + Environment.NewLine +
               " where a.cod_servicio_n = " + Convert.ToString(p);
            try
            {
                DataSet ds = null;
                ds = MyOracleUtils.executeSqlStmDs(sql, this.conn);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    catalogoServBE.CodServicioN = Convert.ToInt32(row["COD_SERVICIO_N"]);
                    catalogoServBE.CodTipretornoN = Convert.ToInt32(row["COD_TIPRETORNO_N"]);
                    catalogoServBE.CodObjpropN = Convert.ToInt32(row["COD_OBJPROP_N"]);
                    catalogoServBE.CodTipservicioN = Convert.ToInt32(row["COD_TIPSERVICIO_N"]);
                    catalogoServBE.CodAccservN = Convert.ToInt32(row["COD_ACCSERV_N"]);
                    catalogoServBE.NomServicio = Convert.ToString(row["NOM_SERVICIO"]);
                    catalogoServBE.IndAtomservV = Convert.ToString(row["IND_ATOMSERV_V"]);
                    catalogoServBE.CodModuloN = Convert.ToInt32(row["COD_MODULO_N"]);
                    catalogoServBE.DesServicio = Convert.ToString(row["DES_SERVICIO"]);
                    catalogoServBE.NumCache = Convert.ToInt32(row["NUM_CACHE"]);
                    catalogoServBE.DesInvocador = Convert.ToString(row["DES_INVOCADOR"]);
                    catalogoServBE.CodRegistroN = Convert.ToDecimal(row["COD_REGISTRO_N"]);
                    catalogoServBE.CodEstadoN = Convert.ToInt32(row["COD_ESTADO_N"]);
                    catalogoServBE.IndLogueo = Convert.ToInt32(row["IND_LOGUEO"]);
                    catalogoServBE.IndPublico = Convert.ToInt32(row["IND_PUBLICO"]);
                    catalogoServBE.DesEsquema = Convert.ToString(row["DES_ESQUEMA"]);
                }
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }
    }
}
