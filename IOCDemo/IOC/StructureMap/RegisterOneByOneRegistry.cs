using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap.Configuration.DSL;
using IOCDemo.Repository;
using IOCDemo.ApplicationServices;
using StructureMap;
using StructureMap.Pipeline;

namespace IOCDemo.IOC.StructureMap
{
    public class RegisterOneByOneRegistry : Registry
    {
        public RegisterOneByOneRegistry()
        {
            For<IOrderRepository>()
                .LifecycleIs(new SingletonLifecycle())
                .Use<OrderRepository>();
            
            For<IOrderService>()
                .LifecycleIs(new UniquePerRequestLifecycle())
                .Use<OrderService>();
        }
    }
}
