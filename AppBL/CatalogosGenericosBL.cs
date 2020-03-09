using AppDL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AppBL
{
    public class CatalogosGenericosBL
    {
        CatalogosGenericosDL catGenDL;

        public CatalogosGenericosBL()
        {
            this.catGenDL = new CatalogosGenericosDL();
        }

        public DataSet GetTiposRetorno()
        {
            DataSet res = null;

            res = this.catGenDL.GetTiposSpsRetorno();

            return res;
        }

        public DataSet GetTiposServicios()
        {
            DataSet res = null;
            try
            {
                res = this.catGenDL.GetTiposServicios();
            }
            catch (Exception)
            {

                throw;
            }

            return res;
        }

        public DataSet GetObjetoProp()
        {
            DataSet res = null;
            try
            {
                res = this.catGenDL.GetObjetoProp();
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
                res = this.catGenDL.GetCodModulo();
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
                res = this.catGenDL.GetAccionServicio();
            }
            catch (Exception)
            {

                throw;
            }
            return res;
        }
    }
}
