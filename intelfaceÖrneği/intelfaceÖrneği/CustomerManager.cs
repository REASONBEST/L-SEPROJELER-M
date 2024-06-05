using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intelfaceÖrneği
{
    class CustomerManager
    {
        public ILogger Logger { get; set; }

        public void Ekle()
        {
            Logger.Log();
            Console.WriteLine("Eklendi.");
        }
    }
}
