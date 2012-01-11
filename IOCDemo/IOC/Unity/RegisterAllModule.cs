using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Unity.AutoRegistration;
using System.Reflection;

namespace IOCDemo.IOC.Unity
{
    /// <summary>
    /// Autoregistration is not feature by unity itself.
    /// The Unity.AutoRegistration library is needed to do this.
    /// </summary>
    public class RegisterAllModule
    {
        public void Register(UnityContainer container)
        {
            container
                .ConfigureAutoRegistration()
                .Include(x => x.Assembly == Assembly.GetExecutingAssembly(), Then.Register().AsAllInterfacesOfType().UsingPerCallMode())
                .ApplyAutoRegistration();
        }
    }
}
