using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DIDemo.Models;

namespace DIDemo.Repository
{
    public interface IOrderRepository
    {
        Order GetOrder(int id);
    }
}
