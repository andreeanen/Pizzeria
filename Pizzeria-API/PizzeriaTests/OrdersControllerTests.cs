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
            var actualOrders = okResult.Value as List<Order>;

            CollectionAssert.AreEquivalent(expectedOrders, actualOrders);
        }

        [TestMethod]
        public void GetById_IdDoesntExist_Returns200()
        {
            var controller = new OrdersController();

            var objectResult = controller.Get(1) as OkObjectResult;
            var actualStatusCode = objectResult.StatusCode;

            Assert.AreEqual(200, actualStatusCode);
        }

        [TestMethod]
        public void GetById_IdDoesntExist_Returns404()
        {
            var controller = new OrdersController();

            var objectResult = controller.Get(0) as NotFoundResult;
            var actualStatusCode = objectResult.StatusCode;

            Assert.AreEqual(404, actualStatusCode);
        }

        [TestMethod]
        public void GetById_WhenCalled_ReturnsOrderWithSameId()
        {
            var controller = new OrdersController();

            var expectedOrder = new Order() { Id = 1 };
            var okResult = controller.Get(1) as OkObjectResult;
            var actualOrder = okResult.Value as Order;

            Assert.AreEqual(expectedOrder.Id, actualOrder.Id);
        }

        // test if expectedorder is correct class
    }
}
