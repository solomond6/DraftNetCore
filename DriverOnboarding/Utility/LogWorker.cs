using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DriverOnboarding.Utility
{
    public class LogWorker
    {
        IConfiguration _iconfiguration;
        public LogWorker(IConfiguration iconfiguration)
        {
            _iconfiguration = iconfiguration;
        }

        string module; string function; string message;

        public LogWorker(string module, string function, string message)
        {

            this.module = module;
            this.function = function;
            this.message = message;

            try
            {

                string filpath = _iconfiguration["Logging:ErrorLog"];
                //string filpath = HttpContext.Current.Server.MapPath("/ErrorLog");

                if (!Directory.Exists(filpath))
                {
                    Directory.CreateDirectory(filpath);
                }

                //filpath += "\\WesternLotto-Log\\";

                if (!Directory.Exists(filpath))
                {
                    Directory.CreateDirectory(filpath);
                }

                filpath += @"\" + DateTime.Now.ToString("ddMMMyyy") + ".txt";

                File.AppendAllLines(filpath,
                    new string[] {
                        "Event Time: " + DateTime.Now.ToString() + "\t" +
                        "Module Name: " +module + "\t" +
                        "Function Name: " +function + "\t" +
                        "Message: " +message
                    });

                //backup

                FileInfo i = new FileInfo(filpath);

                if (i.Length > 10000000)
                {
                    i.MoveTo(DateTime.Now.ToString("ddMMMyyyyhhmmsstt") + ".txt");
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }

        }

    }
}
