using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap.Configuration.DSL;

namespace IOCDemo.IOC.StructureMap
{
    public class ScanAllRegistry : Registry
    {
        public ScanAllRegistry()
        {
            Scan(x =>
                     {
                         x.TheCallingAssembly();
                         x.WithDefaultConventions();
                     });
        }
    }
}
