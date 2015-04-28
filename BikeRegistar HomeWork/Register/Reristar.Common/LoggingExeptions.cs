using Reristar.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reristar.Common
{
    public class LoggingExeptions : ILogger
    {
        /// <summary>
        /// Implementiranje na ILogger interfejs, pri sto se koristi promenliva od tip ILogger za poapstahirano manipuliranje so greshkite 
        /// </summary>
        private ILogger logger;
        public void LogError(string message, Exception e)
        {
            string temp = string.Format(message);
            logger.LogError(temp, e);
        }

        public void LogWarning(string message, Exception e)
        {
            string temp = string.Format(message);
            logger.LogWarning(temp, e);
        }
    }
}
