using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using System.Reflection;
using AutofacModule = Autofac.Module;

namespace IOCDemo.IOC.Autofac
{
    public class RegisterAllModule : AutofacModule
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = Assembly.GetExecutingAssembly();
            builder
                .RegisterAssemblyTypes(assembly)
                .AsImplementedInterfaces();

        }
    }
}
