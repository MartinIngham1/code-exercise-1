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
        const string orderQuantity = "3.5 kg";
        const string pricePerKg = "£303";
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
    }
}
