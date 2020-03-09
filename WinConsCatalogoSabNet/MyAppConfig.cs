using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace WinConsCatalogoSabNet
{
    class MyAppConfig
    {
        
        private string connStr;

        public string ConnStr
        {
            get { return connStr; }
        }




        private MyAppConfig()
        {

            this.connStr = ConfigurationManager.AppSettings["connStr"];
        }

        // implementing singleton class
        private static MyAppConfig instance;

        public static MyAppConfig Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MyAppConfig();
                }
                return instance;
            }
        }
    }
}
