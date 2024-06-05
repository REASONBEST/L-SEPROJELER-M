using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intelfaceÖrneği
{
    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Sms kaydı yapıldı.");
        }
    }
}
