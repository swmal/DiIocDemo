using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using IOCDemo.ApplicationServices;
using IOCDemo.Repository;

namespace IOCDemo.IOC.Unity
{
    /// <summary>
    /// Unity does not have modules, registrys, etc as the other containers...
    /// </summary>
    public class RegisterOneByOneModule
    {
        public void Register(UnityContainer container)
        {
            container.RegisterType<IOrderService, OrderService>();
            container.RegisterType<IOrderRepository, OrderRepository>();
        }
    }
}
