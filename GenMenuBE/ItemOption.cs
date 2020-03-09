using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinTraverseXml
{
    public class ItemOption
    {
        string idItemOption;

        public string IdItemOption
        {
            get { return idItemOption; }
            set { idItemOption = value; }
        }

        int idNumeric;

        public int IdNumeric
        {
            get { return idNumeric; }
            set { idNumeric = value; }
        }



        string label;

        public string Label
        {
            get { return label; }
            set { label = value; }
        }

        string assemblyFile;

        public string AssemblyFile
        {
            get { return assemblyFile; }
            set { assemblyFile = value; }
        }


        string classNameStr;

        public string ClassNameStr
        {
            get { return classNameStr; }
            set { classNameStr = value; }
        }

        string invoker;

        public string Invoker
        {
            get { return invoker; }
            set { invoker = value; }
        }

        object frmWork;

        public object FrmWork
        {
            get { return frmWork; }
            set { frmWork = value; }
        }


        public ItemOption(string pIdItemOption, int pIdNumeric, string pLabel, string pAssemblyFile,
                          string pClassNameStr, string pInvoker)
        {
            this.idItemOption = pIdItemOption;
            this.idNumeric = pIdNumeric;
            this.label = pLabel;
            this.assemblyFile = pAssemblyFile;
            this.classNameStr = pClassNameStr;
            this.invoker = pInvoker;
            this.frmWork = null;
        }

        

        public override string ToString()
        {
            return this.idItemOption + "-" + this.idNumeric.ToString()  +"-" + this.label + " - " + 
                   this.invoker + " - " + this.assemblyFile  + "-" + this.classNameStr;
        }
    }
}
