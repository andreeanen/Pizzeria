using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizzeria_API.Controllers;
using Pizzeria_API.Data;
using Pizzeria_API.Models;
using System.Collections.Generic;

namespace PizzeriaTests
{
    [TestClass]
    public class OrdersControllerTests
    {
        [TestMethod]
        public void Get_OrdersIsNull_ReturnsNotFoundResult()
        {            
            var controller = new OrdersController();
            Orders orders = null;
            controller.Orders = orders;

            var actual = controller.Get();

            Assert.IsInstanceOfType(actual, typeof(NotFoundResult));
        }

        [TestMethod]
        public void Get_OrdersIsInstantiated_ReturnsOk()
        {
            var controller = new OrdersController();

            var actual = controller.Get();

            Assert.IsInstanceOfType(actual, typeof(OkObjectResult));
        }

        [TestMethod]
        public void Get_WhenCalled_ReturnsAllOrdersFromTheQueue()
        {
            var controller = new OrdersController();
            var orders = Orders.GetOrders();

            var expectedOrders = orders.Queue;
            var okResult = controller.Get() as OkObjectResult;
            var actualOrders = okResult.Value as Queue<Order>;

            CollectionAssert.AreEquivalent(expectedOrders, actualOrders);
        }
    }
}
