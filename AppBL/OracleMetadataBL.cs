using AppBE;
using AppDL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AppBL
{
    public class OracleMetadataBL
    {
        OracleMetaDataDL oraMetaDL;

        public OracleMetadataBL()
        {
            this.oraMetaDL = new OracleMetaDataDL();
        }

        public string GetDll (string pSchema, string pObjectType, string pObjectName)
        {
            string res = string.Empty;

            res = this.oraMetaDL.GetDll(pSchema, pObjectType, pObjectName);

            return res;
        }

        public List<DbObjectBE> GetDependencies(DbObjectBE pDbObjectBE)
        {
            List<DbObjectBE> res = null;

            res = new List<DbObjectBE>();
            try
            {
                DataSet ds = this.oraMetaDL.GetDependencies(pDbObjectBE);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DbObjectBE dbObj = new DbObjectBE();
                    dbObj.Owner = Convert.ToString(dr["REFERENCED_OWNER"]);
                    dbObj.Type = Convert.ToString(dr["REFERENCED_TYPE"]);
                    dbObj.Name = Convert.ToString(dr["REFERENCED_NAME"]);
                    res.Add(dbObj);
                }
            }
            catch (Exception)
            {
                
                throw;
            }

            return res;
        }


        public void GetAllDependencies(DbObjectBE pDbObjectBE, 
                                      List<DbObjectBE> pLstObjs)
        {
            try
            {
                if (pDbObjectBE != null)
                {
                    if (!pLstObjs.Contains (pDbObjectBE))
                    {
                        pLstObjs.Add(pDbObjectBE);
                        List<DbObjectBE> lstDependencies = this.GetDependencies(pDbObjectBE);
                        foreach (var item in lstDependencies)
                        {
                            if (item.Owner.CompareTo("SYS") != 0 )
                            {
                                GetAllDependencies(item, pLstObjs);
                            }
                        }
                    }

                }
            }
            catch (Exception)
            {
                
                throw;
            }

        }


        public List<OracleMetadataBE> GetSqlTblMetaData(string pOwner, string pTableName,
                                                      string pVarRow, string pVarEntiName)
        {
            List<OracleMetadataBE> res = new List<OracleMetadataBE>();

            try
            {
                OracleMetadataBE oMetaBE;
                DataSet ds = this.oraMetaDL.GetSqlTblMetaData(pOwner, pTableName, pVarRow, pVarEntiName);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    oMetaBE = new OracleMetadataBE();
                    oMetaBE.ListaColumnas = Convert.ToString(dr["ListaColumnas"]);
                    oMetaBE.PlSqlParams = Convert.ToString(dr["PlSqlParams"]);
                    oMetaBE.CSharpMemberClass = Convert.ToString(dr["CsharpMemberClass"]);
                    oMetaBE.InitConstructor = Convert.ToString(dr["initConstructor"]);
                    oMetaBE.Fill2Entity = Convert.ToString(dr["fill2Entity"]);
                    oMetaBE.FillEntityFromDataRow = Convert.ToString(dr["FillEntityFromDataRow"]);
                    oMetaBE.Fill2Ui = Convert.ToString(dr["fil2lUi"]);
                    oMetaBE.CSharpAttribute = Convert.ToString(dr["CSHARPATRIBUTE"]);
                    res.Add(oMetaBE);
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
            try
            {
                res = this.oraMetaDL.ObtCallCSharp(pSerViceName, pServiceRequest, pEntityName, 
                                                   pIndentityParamN, pDbOwner);
            }
            catch (Exception)
            {
                
                throw;
            }
            return res;
        }
    }
}
