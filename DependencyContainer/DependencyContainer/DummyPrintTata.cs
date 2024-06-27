using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyContainer
{
    public class DummyPrintTata : IDummyPrint
    {
        public void Print()
        {
            Console.WriteLine("TATA");
        }
    }
}
