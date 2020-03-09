using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using WinXmlToSqlInvoker;

namespace WinXmlToSqlInvoker
{
    class TransactionFile
    {
        private const string zCRLF = "\r\n";
        private const string zTABSPC = "\t\t\t\t";

        private string fileName;
        private string callSp;
        public string CallSp
        {
            get { return callSp; }

        }

        private List<ParameterBE> lst = new List<ParameterBE>();
        private TransactionBE trxDef = new TransactionBE();


        public TransactionFile(string pfileName)
        {
            this.fileName = pfileName;
            processTransactionFile();
        }

        public void processTransactionFile()
        {

            XmlDocument doc = new XmlDocument();
            doc.Load(this.fileName);
            string spSentence = string.Empty;
            string spParams = string.Empty;
            string spParam = string.Empty;

            processTransaction(doc);

            processParameters(doc);

            this.generateSqlStm();
        }

        private void processParameters(XmlDocument doc)
        {
            XmlNodeList xmlLst1 = doc.SelectNodes("/TransactionDetail/Parameters");

            this.lst.Clear();
            foreach (XmlNode xn in xmlLst1)
            {
                ParameterBE paramBe = new ParameterBE();
                paramBe.Name = xn["Name"].InnerText;
                if (xn["Value"] != null)
                {
                    paramBe.Value = xn["Value"].InnerText;
                }
                paramBe.Type = xn["Type"].InnerText;
                paramBe.Direction = xn["Direction"].InnerText;
                this.lst.Add(paramBe);
            }
        }

        private void processTransaction(XmlDocument doc)
        {
            XmlNodeList xmlLst = doc.SelectNodes("/TransactionDetail/Transaction");

            foreach (XmlNode xn in xmlLst)
            {
                this.trxDef.LayerName = xn["LayerName"].InnerText;
                this.trxDef.MethodName = xn["MethodName"].InnerText;
                this.trxDef.ServiceName = xn["ServiceName"].InnerText;
                this.trxDef.ServiceDescription = xn["ServiceDescription"].InnerText;
                this.trxDef.InvokedService = xn["InvokedService"].InnerText;
            }
        }

        private void generateSqlStm()
        {
            string spParams = string.Empty;
            string spParam = string.Empty;
            string value = string.Empty;
            bool ft = true;

            foreach (ParameterBE paramBe in this.lst)
            {
                value = getSQLValueTyped(paramBe);
                spParam = paramBe.Name + " => " + (paramBe.Value.Length == 0 ? "NULL" : value);
                spParams += (!ft ? ", " + zCRLF + zTABSPC : string.Empty) + spParam;
                ft = false;
            }



            this.callSp = "BEGIN " + zCRLF +
                                                (this.trxDef.InvokedService + (spParams.Length > 0 ? "(" : string.Empty) +
                                                          spParams + (spParams.Length > 0 ? ");" : string.Empty)) + zCRLF +
                                          "END;";
        }

        private string getSQLValueTyped(ParameterBE param)
        {
            string res = string.Empty;

            res = param.Value.Trim();
            if (res.Length != 0)
            {
                if (param.Type.CompareTo("Alphanumeric") == 0)
                {

                    res = "'" + res + "'";
                }
                if (param.Type.CompareTo("DateTime") == 0)
                {

                    res = "TO_DATE ('" + res.Substring(0, 10).Trim() + "',DD/MM/RRRR)";
                }
            }
            else
            {
                res = "NULL";
            }
            return res;
        }
    }
}
