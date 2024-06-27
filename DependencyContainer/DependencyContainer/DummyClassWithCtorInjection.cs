using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyContainer
{
    public class DummyClassWithCtorInjection
    {
        IDummyPrint _dumPrint;
        public DummyClassWithCtorInjection(IDummyPrint dumPrint)
        {
            _dumPrint = dumPrint;
        }
        public void PrintIt()
        {
            _dumPrint.Print();
        }
    }
}
