using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IOCDemo.Models;

namespace IOCDemo.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public Order GetOrder(int id)
        {
            // Connect to database here...
            return new Order() { Id = id };
        }
    }
}
