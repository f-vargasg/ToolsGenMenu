using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Utilities;

namespace AppDL
{
    public class BitObjetoDL
    {
        OracleConnection conn;

        public BitObjetoDL()
        {
            this.conn = ConnGl.Instance.Conn;
        }

        public decimal ObtenerCodRegistro ()
        {
            List<OracleParameter> lstParams = new List<OracleParameter>();

            decimal wcod_registro = (Decimal)(OracleDecimal)(MyOracleUtils.execOracleSf2("GE_PAMBCOMMON.CONSECUTIVO", lstParams, OracleDbType.Decimal, this.conn));
            return wcod_registro;
        }

        public void Registrar(decimal pCodAccionRegN,
                              string pNomTabla,
                              decimal pCodRegistroN,
                              string pCodUsuarioV)
        {
            OracleParameter param;
            List<OracleParameter> lstParams = new List<OracleParameter>();

            param = MyOracleUtils.makeParam("pcod_accionreg_n", pCodAccionRegN, OracleDbType.Decimal, ParameterDirection.Input);
            lstParams.Add(param);

            param = MyOracleUtils.makeParam("pdes_tabla", pNomTabla, OracleDbType.Varchar2, ParameterDirection.Input);
            lstParams.Add(param);

            param = MyOracleUtils.makeParam("pcod_registro_n", pCodRegistroN, OracleDbType.Decimal, ParameterDirection.Input);
            lstParams.Add(param);

            param = MyOracleUtils.makeParam("pcod_usuario_v", pCodUsuarioV, OracleDbType.Varchar2, ParameterDirection.Input);
            lstParams.Add(param);

            MyOracleUtils.execOracleSp2("GE_PAMBBITOBJETO.registrar", lstParams, this.conn);
        }
    }
}
