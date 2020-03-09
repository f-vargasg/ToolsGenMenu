using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppBE
{
    public class OracleMetadataBE
    {
        string listaColumnas;

        public string ListaColumnas
        {
            get { return listaColumnas; }
            set { listaColumnas = value; }
        }
        string plSqlParams;

        public string PlSqlParams
        {
            get { return plSqlParams; }
            set { plSqlParams = value; }
        }
        string cSharpMemberClass;

        public string CSharpMemberClass
        {
            get { return cSharpMemberClass; }
            set { cSharpMemberClass = value; }
        }
        string initConstructor;

        public string InitConstructor
        {
            get { return initConstructor; }
            set { initConstructor = value; }
        }
        string fill2Entity;

        public string Fill2Entity
        {
            get { return fill2Entity; }
            set { fill2Entity = value; }
        }
        string fillEntityFromDataRow;

        public string FillEntityFromDataRow
        {
            get { return fillEntityFromDataRow; }
            set { fillEntityFromDataRow = value; }
        }
        string fill2Ui;

        public string Fill2Ui
        {
            get { return fill2Ui; }
            set { fill2Ui = value; }
        }
        string cSharpAttribute;

        public string CSharpAttribute
        {
            get { return cSharpAttribute; }
            set { cSharpAttribute = value; }
        }

        
    }
}
