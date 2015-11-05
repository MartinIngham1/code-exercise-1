using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercise.Tests
{
    [TestFixture]
    class OrderTests
    {
        private Order order;
        const string userId = "Test";
        const double orderQuantity = 3.5;
        decimal pricePerKg = 303;
        const OrderType orderType = OrderType.Buy;

        [SetUp]
        public void Init()
        {
            order = new Order(userId, orderQuantity, pricePerKg, orderType);
        }

        [Test]
        public void Order_Should_Contain_User_Id_Field()
        {
            // Arrange

            // Act

            // Assert
            Assert.AreEqual(userId, order.UserId);
        }

        [Test]
        public void Order_Should_Contain_Order_Quantity_Field()
        {
            // Arrange

            // Act

            // Assert
            Assert.AreEqual(orderQuantity, order.OrderQuantity);
        }

        [Test]
        public void Order_Should_Contain_Price_Per_Kg_Field()
        {
            // Arrange

            // Act

            // Assert
            Assert.AreEqual(pricePerKg, order.PricePerKg);
        }

        [Test]
        public void Order_Should_Contain_Order_Type_Field()
        {
            // Arrange

            // Act

            // Assert
            Assert.AreEqual(orderType, order.OrderType);
        }

        [Test]
        public void Constructor_Should_Throw_Exception_If_Order_Type_Is_Not_Initialized()
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => 
                order = new Order(userId, orderQuantity, pricePerKg, OrderType.None)
            );
        }
    }
}
