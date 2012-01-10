using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IOCDemo.Models;
using IOCDemo.Repository;

namespace IOCDemo.ApplicationServices
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepostitory;

        public OrderService(IOrderRepository orderRepostitory)
        {
            _orderRepostitory = orderRepostitory;
        }

        public Order GetOrder(int id)
        {
            return _orderRepostitory.GetOrder(id);
        }
    }

}
