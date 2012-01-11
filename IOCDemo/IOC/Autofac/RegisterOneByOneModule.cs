using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using IOCDemo.Repository;
using IOCDemo.ApplicationServices;

namespace IOCDemo.IOC.Autofac
{
    public class RegisterOneByOneModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<OrderRepository>()
                .As<IOrderRepository>()
                .InstancePerDependency();
            builder
                .RegisterType<OrderService>()
                .As<IOrderService>()
                .SingleInstance();
        }
    }
}
