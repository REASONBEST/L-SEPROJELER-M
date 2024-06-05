using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaceUygulaması
{
    class Manager : IWorker ,ISalary, IEat
    {
        public void Eat()
        {
            Console.WriteLine("Manager Yemek Yer");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager Maaş Alır.");
        }

        public void Work()
        {
            Console.WriteLine("Manager Çalışır.");
        }
    }
}
