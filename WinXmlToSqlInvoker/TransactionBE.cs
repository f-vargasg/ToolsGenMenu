using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinXmlToSqlInvoker
{
    class TransactionBE
    {
                string layerName;

        public string LayerName
        {
            get { return layerName; }
            set { layerName = value; }
        }

        string methodName;

        public string MethodName
        {
            get { return methodName; }
            set { methodName = value; }
        }

        string serviceName;

        public string ServiceName
        {
            get { return serviceName; }
            set { serviceName = value; }
        }

        string serviceDescription;

        public string ServiceDescription
        {
            get { return serviceDescription; }
            set { serviceDescription = value; }
        }

        string invokedService;

        public string InvokedService
        {
            get { return invokedService; }
            set { invokedService = value; }
        }

        public TransactionBE()
        {
            this.layerName = string.Empty;
            this.methodName = string.Empty;
            this.serviceName = string.Empty;
            this.serviceDescription = string.Empty;
            this.invokedService = string.Empty;
        }

        public TransactionBE(string pLayerName, string pMethodName, string pServiceName, 
                             string pServiceDescription, string pInvokedService)
        {
            this.layerName = pLayerName;
            this.methodName = pMethodName;
            this.serviceName = pServiceName;
            this.serviceDescription = pServiceDescription;
            this.invokedService = pInvokedService;
        }
    }
}
