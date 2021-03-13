using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace sistem
{
    public class Logger
    {
        public static log4net.ILog GetLogger([CallerFilePath] string naziv_fajla = "")
        {
            return log4net.LogManager.GetLogger(naziv_fajla);
        }
    }
}
