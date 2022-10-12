using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTPBubbleTea
{
    public class GlobalVariables
    {

        public static string APP_NAME = ConfigurationManager.AppSettings["AppName"];
        public static string VERSION = ConfigurationManager.AppSettings["Version"];
        public static string USER = string.Empty;
        public static string DEV_BY = ConfigurationManager.AppSettings["DevBy"];
    }
}
