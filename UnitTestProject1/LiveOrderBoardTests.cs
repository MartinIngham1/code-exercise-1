using System;
using NUnit.Framework;

namespace CodeExercise.Tests
{
    [TestFixture]
    public class LiveOrderBoardTests
    {
        private LiveOrderBoard board;

        [SetUp]
        public void Init()
        {
            board = new LiveOrderBoard();
        }

        [Test]
        public void RegisterOrder_Should_Add_Order()
        {
            // Arrange
            var order = new Order("Test", "3.5 kg", "£303", OrderType.Buy);

            // Act
            var result = board.RegisterOrder(order);
            
            // Assert
            Assert.IsNotEmpty(board.GetOrders());
        }

        [Test]
        public void CancelRegisteredOrder_Should_Remove_Order_If_It_Matches_Id()
        {
            // Arrange
            var order = new Order("Test", "3.5 kg", "£303", OrderType.Buy);
            var orderId = board.RegisterOrder(order);

            // Act
            board.CancelRegisteredOrder(orderId);

            // Assert
            Assert.IsEmpty(board.GetOrders());
        }

        [Test]
        public void CancelRegisteredOrder_Should_Not_Remove_Order_If_It_Does_Not_Match_Id()
        {
            // Arrange
            var order = new Order("Test", "3.5 kg", "£303", OrderType.Buy);
            var id1 = board.RegisterOrder(order);
            var id2 = Guid.NewGuid();

            // Act
            board.CancelRegisteredOrder(id2);

            // Assert
            Assert.IsNotEmpty(board.GetOrders());
        }
    }
}