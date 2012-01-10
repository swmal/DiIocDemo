using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DIDemo.ApplicationServices;

namespace DIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IOrderService orderService = new OrderService();

            var order = orderService.GetOrder(2);
            Console.WriteLine("Order retrieved, ordernumber: " + order.Id);
            Console.ReadKey();
        }
    }
}
