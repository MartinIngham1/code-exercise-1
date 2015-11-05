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

        [Test]
        public void Order_Should_Contain_User_Id_Field()
        {
            // Arrange
            const string UserId = "Test";

            // Act
            order = new Order(UserId);

            // Assert
            Assert.AreEqual(UserId, order.UserId);
        }
    }
}
