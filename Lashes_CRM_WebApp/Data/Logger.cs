using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace Lashes_CRM_WebApp
{
    class Logger
    {
        public static void Log(string Logline)
        {
            File.AppendAllText(@"c:\logfile.txt", DateTime.Now + Logline + Environment.NewLine);
            //write timestamp + logmessage to file
        }
    }
}
