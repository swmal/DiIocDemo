using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IOCDemo.Models;

namespace IOCDemo.ApplicationServices
{
    public interface IOrderService
    {
        Order GetOrder(int id);
    }
}
