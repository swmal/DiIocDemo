using System;

using IOCDemo.ApplicationServices;
using Microsoft.Practices.ServiceLocation;

namespace IOCDemo
{
    class Program
    {
        private enum IocContainer{ CastleWindsor, StructureMap, Autofac, Unity }

        private static void Bootstrap(IocContainer iocContainer)
        {
            switch(iocContainer)
            {
                case IocContainer.CastleWindsor:
                    WindsorBootstrapper.Bootstrap();
                    break;
                case IocContainer.StructureMap:
                    StructureMapBootstrapper.Bootstrap();
                    break;
                case IocContainer.Autofac:
                    AutofacBootstrapper.Bootstrap();
                    break;
                case IocContainer.Unity:
                    UnityBootstrapper.Bootstrap();
                    break;
                default:
                    WindsorBootstrapper.Bootstrap();
                    break;
            }
            Console.WriteLine("Bootstrapped using " + iocContainer);
        }


        static void Main(string[] args)
        {
            Bootstrap(IocContainer.Unity);

            // resolve and call IOrderService
            var orderService = ServiceLocator.Current.GetInstance<IOrderService>();
            var order = orderService.GetOrder(2);
            Console.WriteLine("order fetched, ordernumber: " + order.Id);
            Console.ReadKey();
        }
    }
}
