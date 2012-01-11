using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using IOCDemo.IOC.Unity;
using Microsoft.Practices.ServiceLocation;

namespace IOCDemo
{
    public static class UnityBootstrapper
    {
        public static void Bootstrap()
        {
            var container = new UnityContainer();
            //var module = new RegisterOneByOneModule();
            var module = new RegisterAllModule();
            module.Register(container);

            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(container));
        }
    }
}
