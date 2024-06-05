using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacehayvanuygulaması
{
    class Kopek : IHayvan, IBeslen
    {
        public void Beslen()
        {
            Console.WriteLine("Köpek Et yedi");
        }

        public void SesCıkar()
        {
            Console.WriteLine("Köpek : haw haww");
        }
    }
}
