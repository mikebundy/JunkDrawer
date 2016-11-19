using JunkDrawer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkDrawerDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            JDRandom r = new JDRandom();
            Console.WriteLine(r.GetInteger());
            Console.WriteLine(r.GetInteger(32, 89));
            Console.Read();
        }
    }
}
