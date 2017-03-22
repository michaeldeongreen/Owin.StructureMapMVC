using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owin.StructureMapMVC.Services
{
    public class SomeService : ISomeService
    {
        public string Foo()
        {
            return "Foo";
        }
    }
}
