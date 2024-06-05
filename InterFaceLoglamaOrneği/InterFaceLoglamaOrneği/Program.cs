using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceLoglamaOrneği
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new DatabaseLogger();
            //customerManager.Logger = new SmsLogger();
            //customerManager.Ekle();
            customerManager.Ekle();
            Console.ReadLine();
        }
    }
}
