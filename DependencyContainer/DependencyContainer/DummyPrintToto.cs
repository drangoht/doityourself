using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyContainer
{
    public class DummyPrintToto : IDummyPrint
    {
        public void Print()
        {
            Console.WriteLine("TOTO");
        }
    }
}
