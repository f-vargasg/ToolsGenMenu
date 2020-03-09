using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppBE
{
    public class ObjetoPropBE
    {
        int codObjpropN;

        
        public int CodObjpropN
        {
            get { return codObjpropN; }
            set { codObjpropN = value; }
        }

        string desAbrobj;

        public string DesAbrobj
        {
            get { return desAbrobj; }
            set { desAbrobj = value; }
        }
        string desObjdb;

        public string DesObjdb
        {
            get { return desObjdb; }
            set { desObjdb = value; }
        }
        
        int codRegistroN;

        public int CodRegistroN
        {
            get { return codRegistroN; }
            set { codRegistroN = value; }
        }
        
        int codEstadoN;

        public int CodEstadoN
        {
            get { return codEstadoN; }
            set { codEstadoN = value; }
        }
    }
}
