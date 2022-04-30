using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIntro.Services.Logging
{
    public class FileLogger : ILogger
    {
        public void Log(string logMessage)
        {
            Console.WriteLine("File Logger");
        }
    }
}
