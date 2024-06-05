using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulaması2
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServerCustomerDal sqlsercerCustomerDal = new SqlServerCustomerDal();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(sqlsercerCustomerDal);
            Console.ReadLine();
        }
    }
}
