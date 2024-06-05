using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaceUygulaması
{
    class Worker : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            Console.WriteLine("İşci yemek Yer");

        }

        public void GetSalary()
        {
            Console.WriteLine("İşçi Maaş Alır.");
        }

        public void Work()
        {
            Console.WriteLine("İşçi Çalışır.");
        }
    }
}
