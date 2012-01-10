using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DIDemo.Models;

namespace DIDemo.ApplicationServices
{
    interface IOrderService
    {
        Order GetOrder(int id);
    }
}
