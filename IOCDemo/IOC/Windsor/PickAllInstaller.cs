using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace IOCDemo.IOC.Windsor
{
    public class PickAllInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                AllTypes.FromThisAssembly()
                .Pick()
                .WithService.DefaultInterfaces()
                .LifestyleTransient());
        }
    }
}