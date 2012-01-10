using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Windsor;
using CommonServiceLocator.WindsorAdapter;
using IOCDemo.IOC.Windsor;
using Microsoft.Practices.ServiceLocation;

namespace IOCDemo
{
    public class WindsorBootstrapper
    {
        public static void Bootstrap()
        {
            // Dessa två rader kan t ex ligga i Global.asax/Application_Start
            var container = new WindsorContainer();
            //container.Install(new PickAllIocInstaller());
            container.Install(new RegisterOneByOneInstaller());

            // Initialisera CommonServiceLocator
            ServiceLocator.SetLocatorProvider(() => new WindsorServiceLocator(container));
        }
    }
}
