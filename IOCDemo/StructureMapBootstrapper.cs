using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap;
using IOCDemo.IOC.StructureMap;
using Microsoft.Practices.ServiceLocation;
using StructureMap.ServiceLocatorAdapter;

namespace IOCDemo
{
    public class StructureMapBootstrapper
    {
        public static void Bootstrap()
        {
            //ObjectFactory.Initialize(x => x.AddRegistry(new RegisterOneByOneRegistry()));
            ObjectFactory.Initialize(x => x.AddRegistry(new ScanAllRegistry()));

            ServiceLocator.SetLocatorProvider(() => new StructureMapServiceLocator(ObjectFactory.Container));
        }
    }
}
