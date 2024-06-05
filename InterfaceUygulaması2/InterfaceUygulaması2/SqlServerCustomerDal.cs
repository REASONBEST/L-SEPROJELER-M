using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulaması2
{
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }

        public void Delete()
        {
            Console.WriteLine("Delete");
        }

        public void Update()
        {
            Console.WriteLine("Deleted");
        }
    }
}
