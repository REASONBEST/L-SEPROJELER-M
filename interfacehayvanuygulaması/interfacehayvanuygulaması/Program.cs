using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacehayvanuygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            kady kady = new kady();
            kady.Beslen();
            kady.SesCıkar();

            Kopek kopek = new Kopek();
            kopek.Beslen();
            kopek.SesCıkar();
            Console.ReadLine();
        }
    }
}
