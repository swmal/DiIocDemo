using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using IOCDemo.ApplicationServices;
using IOCDemo.Repository;

namespace IOCDemo.IOC.Windsor
{
    public class RegisterOneByOneInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IOrderService>()
                .ImplementedBy<OrderService>()
                );

            container.Register(
                Component.For<IOrderRepository>()
                .ImplementedBy<OrderRepository>()
                );
        }
    }
}
