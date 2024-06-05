using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceLoglamaOrneği
{
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya kayıt edildi.");
        }
    }
}
