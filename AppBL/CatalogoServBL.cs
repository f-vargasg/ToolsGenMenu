using AppBE;
using AppDL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace AppBL
{
    public class CatalogoServBL
    {
        CatalogoServDL catServDL;

        public CatalogoServBL()
        {
            this.catServDL = new CatalogoServDL();
        }

        public decimal NewCodServicio()
        {
            return this.catServDL.NewCodServicio();
        }

        public void Insertar(CatalogoServBE pCatSrvBE)
        {
            this.catServDL.Insertar(pCatSrvBE);
        }

        public void Modificar(CatalogoServBE pCatSrvBE)
        {
            this.catServDL.Modificar(pCatSrvBE);
        }

        public void Borrar(decimal pCodServicioN)
        {
            this.catServDL.Borrar(pCodServicioN);
        }

        public List<CatalogoServBE> GetList()
        {
            List<CatalogoServBE> res = null;
            res = this.catServDL.GetList();
            return res;
        }


        public void GetServiceDataByPk(decimal p,CatalogoServBE catalogoServBE)
        {
            try
            {
                this.catServDL.GetServiceDataByPk(p, catalogoServBE);
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }
    }
}
