using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using IOCDemo.IOC.Autofac;
using Microsoft.Practices.ServiceLocation;
using AutofacContrib.CommonServiceLocator;

namespace IOCDemo
{
    public static class AutofacBootstrapper
    {
        public static void Bootstrap()
        {
            var builder = new ContainerBuilder();
            //builder.RegisterModule(new RegisterOneByOneModule());
            builder.RegisterModule(new RegisterAllModule());

            ServiceLocator.SetLocatorProvider(() => new AutofacServiceLocator(builder.Build()));
        }
    }
}
