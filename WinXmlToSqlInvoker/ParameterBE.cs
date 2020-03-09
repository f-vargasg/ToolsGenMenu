using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinXmlToSqlInvoker
{
    class ParameterBE
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string value;

        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string direction;

        public string Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public ParameterBE()
        {
            this.name = string.Empty;
            this.value = string.Empty;
            this.type = string.Empty;
            this.direction = string.Empty;
        }

        public ParameterBE(string pname, string pValue, string pType, string pDirection)
        {
            this.name = pname;
            this.value = pValue;
            this.type = pType;
            this.direction = pDirection;
        }
    }
}
