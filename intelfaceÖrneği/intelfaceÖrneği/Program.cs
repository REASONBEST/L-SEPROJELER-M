using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intelfaceÖrneği
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.Logger = new DatabaseLogger(); istediğini seç
            //customerManager.Logger = new FileLogger(); istediğini seç
            customerManager.Logger = new SmsLogger();
            customerManager.Ekle();
            Console.ReadLine();
        }
    }
}
