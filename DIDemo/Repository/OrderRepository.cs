using System;
using DIDemo.Models;

namespace DIDemo.Repository
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