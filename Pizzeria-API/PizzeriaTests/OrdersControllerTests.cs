using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizzeria_API.Controllers;
using Pizzeria_API.Data;
using Pizzeria_API.Data.Factory;
using Pizzeria_API.Models;
using System.Collections.Generic;

namespace PizzeriaTests
{
    [TestClass]
    public class OrdersControllerTests
    {
        public Orders Orders { get; set; }
        [TestMethod]
        public void GetOrders_OrdersIsNull_ReturnsNotFoundResult()
        {
            var controller = new OrdersController();
            Orders orders = null;
            controller.Orders = orders;

            var actual = controller.GetOrders();

            Assert.IsInstanceOfType(actual, typeof(NotFoundResult));
        }

        [TestMethod]
        public void GetOrders_OrdersIsInstantiated_ReturnsOk()
        {
            var controller = new OrdersController();

            var actual = controller.GetOrders();

            Assert.IsInstanceOfType(actual, typeof(OkObjectResult));
        }

        [TestMethod]
        public void GetOrders_WhenCalled_ReturnsAllOrdersFromTheQueue()
        {
            var controller = new OrdersController();
            var orders = Orders.GetOrders();

            var expectedOrders = orders.Queue;
            var okResult = controller.GetOrders() as OkObjectResult;
            var actualOrders = okResult.Value as List<Order>;

            CollectionAssert.AreEquivalent(expectedOrders, actualOrders);
        }

        [TestMethod]
        public void GetOrder_IdExists_Returns200()
        {
            var controller = new OrdersController();

            var objectResult = controller.GetOrder(1) as OkObjectResult;
            var actualStatusCode = objectResult.StatusCode;

            Assert.AreEqual(200, actualStatusCode);
        }

        [TestMethod]
        public void GetOrder_IdDoesntExist_Returns404()
        {
            var controller = new OrdersController();

            var objectResult = controller.GetOrder(0) as NotFoundResult;
            var actualStatusCode = objectResult.StatusCode;

            Assert.AreEqual(404, actualStatusCode);
        }

        [TestMethod]
        public void GetOrder_WhenCalled_ReturnsOrderWithSameId()
        {
            var controller = new OrdersController();

            var expectedOrder = new Order() { Id = 1 };
            var okResult = controller.GetOrder(1) as OkObjectResult;
            var actualOrder = okResult.Value as Order;

            Assert.AreEqual(expectedOrder.Id, actualOrder.Id);
        }

        [DataTestMethod]
        [DynamicData(nameof(GetProductNames), DynamicDataSourceType.Method)]
        public void CreateOrder_ProductNames_ReturnsObjectResult(string productName, ObjectResult expectedObjectResult)
        {
            var controller = new OrdersController();

            var actual = controller.CreateOrder(productName);
            var expectedResult = expectedObjectResult.GetType();

            Assert.IsInstanceOfType(actual, expectedResult);
        }

        public static IEnumerable<object[]> GetProductNames()
        {
            yield return new object[]
            {
                "Shrimps",
                new BadRequestObjectResult("You can not add the ingredient because you do not have a pizza on your order")
            };
            yield return new object[]
            {
                "Fanta",
                new OkObjectResult(new Order() { Pizzas = new List<Product>() { new Margherita() }})
            };
            yield return new object[] 
            { 
                "Margherita", 
                new OkObjectResult(new Order() { Pizzas = new List<Product>() { new Margherita() }}) 
            };
            yield return new object[] 
            { 
                "Non Existing Product", 
                new BadRequestObjectResult("The product you are trying to order is not on the menu") 
            };
        }

        //[DataTestMethod]
        //[DynamicData(nameof(GetProductNames), DynamicDataSourceType.Method)]
        //public void AddProductToOrder_ProductNames_ReturnsObjectResult(string productName, ObjectResult expectedObjectResult)
        //{
        //    var controller = new OrdersController();

        //    var actual = controller.AddProductToOrder(1, productName);
        //    var expectedResult = expectedObjectResult.GetType();

        //    Assert.IsInstanceOfType(actual, expectedResult);
        //}

        //[TestMethod]
        //public void AddProductToOrder_IdDoesNotExist_ReturnsNotFound()
        //{
        //    var controller = new OrdersController();

        //    var actualActionResult = controller.AddProductToOrder(0, "Margherita");

        //    Assert.IsInstanceOfType(actualActionResult, typeof(NotFoundResult));
        //}


        public static IEnumerable<object[]> GetProductNamesAndOrderId()
        {
            yield return new object[]
            {
                "Shrimps",
                new OkObjectResult(new Order() 
                {
                    Pizzas= new List<Product>() { new Margherita()},
                    Sodas = new List<Soda>() { new Fanta() }
                })
            };
            yield return new object[]
            {
                "Fanta",
                new OkObjectResult(new Order() 
                {
                    Pizzas= new List<Product>() {new Margherita()},
                    Ingredients = new List<Ingredient>() {new Shrimps()}
                })
            };
            yield return new object[]
            {
                "Margherita",
                 new OkObjectResult(new Order() 
                 {
                    Sodas = new List<Soda>() { new Fanta() }
                 })
            };
            yield return new object[]
            {
                "Non Existing Product",
                new BadRequestObjectResult("The product cannot be found on your order")
            };
        }

        
        [DataTestMethod]
        [DynamicData(nameof(GetProductNamesAndOrderId), DynamicDataSourceType.Method)]
        public void DeleteProductFromOrder_StatusInProgress_ReturnObjectResult(string productName, ObjectResult expectedObjectResult)
        {
            var mockOrder = new Order()
            {
                Pizzas = new List<Product>() { new Margherita() },
                Sodas = new List<Soda>() { new Fanta() },
                Ingredients = new List<Ingredient>() { new Shrimps() },
                Status = Status.InProgress
            };
            Orders = Orders.GetOrders();
            Orders.Queue.Add(mockOrder);

            var controller = new OrdersController();
            var actual = controller.DeleteProductFromOrder(productName, mockOrder.Id);

            Assert.IsInstanceOfType(actual, expectedObjectResult.GetType());
        }

        public static IEnumerable<object[]> GetOrdersDifferentStatus()
        {
            yield return new object[]
            {
                "Margherita",
                new Order()
                {
                    Pizzas= new List<Product>() { new Margherita()},
                    Sodas = new List<Soda>() { new Fanta() },
                    Status= Status.InProgress
                },

                new OkObjectResult(new Order()
                {
                    Sodas = new List<Soda>() { new Fanta() }
                })
            };
            yield return new object[]
            {
                "Margherita",
                new Order()
                {
                    Pizzas= new List<Product>() { new Margherita()},
                    Sodas = new List<Soda>() { new Fanta() },
                    Status= Status.Submitted
                },
                new BadRequestObjectResult("Your order is not in progress so you can not delete products from it.")
            };
            yield return new object[]
            {
                "Margherita",
                 new Order()
                 {
                    Pizzas= new List<Product>() { new Margherita()},
                    Sodas = new List<Soda>() { new Fanta() },
                    Status= Status.Delivered
                 },
                 new BadRequestObjectResult("Your order is not in progress so you can not delete products from it.")
            };
            yield return new object[]
            {
                "Margherita",
                new Order()
                {
                    Pizzas= new List<Product>() { new Margherita()},
                    Sodas = new List<Soda>() { new Fanta() },
                    Status= Status.Cancelled
                },
                new BadRequestObjectResult("Your order is not in progress so you can not delete products from it.")
            };
                    }

        [DataTestMethod]
        [DynamicData(nameof(GetOrdersDifferentStatus), DynamicDataSourceType.Method)]
        public void DeleteProductFromOrder_DifferentStatus_ReturnObjectResult(string productName, Order order,ObjectResult expectedObjectResult)
        {
            Orders = Orders.GetOrders();
            Orders.Queue.Add(order);

            var controller = new OrdersController();
            var actual = controller.DeleteProductFromOrder(productName, order.Id);

            Assert.IsInstanceOfType(actual, expectedObjectResult.GetType());
        }
    }
}
