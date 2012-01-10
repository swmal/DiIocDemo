using System;
using DIDemo.Models;
using DIDemo.Repository;

namespace DIDemo.ApplicationServices
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public OrderService()
            : this(new OrderRepository())
        {
            
        }
        public Order GetOrder(int id)
        {
            return _orderRepository.GetOrder(id);
        }
    }
}