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
        const string UserId = "Test";
        const string OrderQuantity = "3.5 kg";

        [Test]
        public void Order_Should_Contain_User_Id_Field()
        {
            // Arrange

            // Act
            order = new Order(UserId, OrderQuantity);

            // Assert
            Assert.AreEqual(UserId, order.UserId);
        }

        [Test]
        public void Order_Should_Contain_Order_Quantity_Field()
        {
            // Arrange

            // Act
            order = new Order(UserId, OrderQuantity);

            // Assert
            Assert.AreEqual(OrderQuantity, order.OrderQuantity);
        }
    }
}
