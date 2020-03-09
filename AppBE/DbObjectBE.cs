using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppBE
{
    public class DbObjectBE : IEquatable<DbObjectBE>
    {
        string owner;

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        

        public override string ToString()
        {
            string res = string.Empty;

            res = "(" + this.owner + ", " + this.type + ", " + this.name + ")";
            return res;
        }

        public bool Equals(DbObjectBE other)
        {
            bool res = false;
            if (other != null)
            {
                res = (this.name.CompareTo(other.name) == 0 &&
                       this.owner.CompareTo(other.owner) == 0 &&
                       this.type.CompareTo(other.type) == 0);    
            }
            return res;
                
        }
    }
}
