using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacehayvanuygulaması
{
    class kady : IHayvan, IBeslen
    {
        public void Beslen()
        {
            Console.WriteLine("Kedy Süt İçti");
        }

        public void SesCıkar()
        {
            Console.WriteLine("Kedy : miyaww miyaww");
        }
    }
}
