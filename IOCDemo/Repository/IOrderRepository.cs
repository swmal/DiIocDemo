using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IOCDemo.Models;

namespace IOCDemo.Repository
{
    public interface IOrderRepository
    {
        Order GetOrder(int id);
    }
}
