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
        const string PricePerKg = "£303";

        [SetUp]
        public void Init()
        {
            order = new Order(UserId, OrderQuantity, PricePerKg);
        }

        [Test]
        public void Order_Should_Contain_User_Id_Field()
        {
            // Arrange

            // Act

            // Assert
            Assert.AreEqual(UserId, order.UserId);
        }

        [Test]
        public void Order_Should_Contain_Order_Quantity_Field()
        {
            // Arrange

            // Act

            // Assert
            Assert.AreEqual(OrderQuantity, order.OrderQuantity);
        }

        [Test]
        public void Order_Should_Contain_Price_Per_Kg_Field()
        {
            // Arrange

            // Act

            // Assert
            Assert.AreEqual(PricePerKg, order.PricePerKg);
        }
    }
}
