using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using DIDemo.ApplicationServices;
using DIDemo.Repository;
using Rhino.Mocks;
using DIDemo.Models;

namespace DIDemo.Test
{
    [TestFixture]
    public class OrderServiceTest
    {
        private OrderService _orderService;
        private IOrderRepository _orderRepository;

        [SetUp]
        public void Setup()
        {
            _orderRepository = MockRepository.GenerateStub<IOrderRepository>();

            _orderService = new OrderService(_orderRepository);
        }

        [Test]
        public void ShouldReturnAnOrderWhenCalledWithValidParameter()
        {
            var expectedOrder = new Order {Id = 3};
            _orderRepository
                .Stub(x => x.GetOrder(3))
                .Return(expectedOrder);

            var order = _orderService.GetOrder(3);

            Assert.AreEqual(expectedOrder, order);
        }

        [Test]
        public void ShouldThrowExceptionWhenCalledWithNegativeId()
        {
            Assert.Throws<ArgumentException>(() => _orderService.GetOrder(-1));
        }
    }
}
