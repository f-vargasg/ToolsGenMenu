using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using Utilities;

namespace AppDL
{
    public class BitObjetoDL : DataWorker
    {
        
        public decimal ObtenerCodRegistro ()
        {
            decimal res = 0;
            using (DbConnection connection = database.CreateOpenConnection())
            {
                using (DbCommand command = database.CreateStoredProcCommand("GE_PAMBCOMMON.CONSECUTIVO", connection))

                {
                    try
                    {
                        command.ExecuteNonQuery();
                        res = decimal.Parse(command.Parameters["return_value"].Value.ToString());
                        // string scrap = string.Format("Resultado de la suma {0}", res);
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                }
            }
            return res;
        }
        
        public void Registrar(decimal pCodAccionRegN,
                              string pNomTabla,
                              decimal pCodRegistroN,
                              string pCodUsuarioV)
        {
            int res = 0;
            using (DbConnection connection = database.CreateOpenConnection())
            {
                using (DbCommand command = database.CreateStoredProcCommand("GE_PAMBBITOBJETO.registrar", connection))

                {
                    try
                    {
                        DbParameter param = database.CreateParameter("pcod_accionreg_n", DbType.Decimal, pCodAccionRegN);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("pdes_tabla", DbType.String, pNomTabla);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("pcod_registro_n", DbType.Decimal, pCodRegistroN);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("pcod_usuario_v", DbType.String, pCodUsuarioV);
                        command.Parameters.Add(param);
                        command.ExecuteNonQuery();
                        // string scrap = string.Format("Resultado de la suma {0}", res);
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
            }
        }
    }
}
