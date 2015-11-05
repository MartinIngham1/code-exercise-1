using System;
using NUnit.Framework;
using System.Linq;

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
            var order = new Order("Test", 3.5, 303, OrderType.Buy);

            // Act
            var result = board.RegisterOrder(order);
            
            // Assert
            Assert.IsNotEmpty(board.GetOrders());
        }

        [Test]
        public void CancelRegisteredOrder_Should_Remove_Order_If_It_Matches_Id()
        {
            // Arrange
            var order = new Order("Test", 3.5, 303, OrderType.Buy);
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
            var order = new Order("Test", 3.5, 303, OrderType.Buy);
            var id1 = board.RegisterOrder(order);
            var id2 = Guid.NewGuid();

            // Act
            board.CancelRegisteredOrder(id2);

            // Assert
            Assert.IsNotEmpty(board.GetOrders());
        }

        [Test]
        public void GetSummaryInfoLiveOrders_Should_Return_Summary_String()
        {
            // Arrange
            var order = new Order("user3", 1.5, 307, OrderType.Sell);
            board.RegisterOrder(order);

            // Act
            var result = board.GetSummaryInfoLiveOrders();

            // Assert
            Assert.AreEqual("1.5 kg for £307", result.FirstOrDefault());
        }

        [Test]
        public void GetSummaryInfoLiveOrders_Should_Group_Orders_By_Price()
        {
            // Arrange
            var orderA = new Order("user1", 3.5, 306, OrderType.Sell);
            board.RegisterOrder(orderA);
            var orderB = new Order("user2", 1.2, 310, OrderType.Sell);
            board.RegisterOrder(orderB);
            var orderC = new Order("user3", 1.5, 307, OrderType.Sell);
            board.RegisterOrder(orderC);
            var orderD = new Order("user4", 2.0, 306, OrderType.Sell);
            board.RegisterOrder(orderD);

            // Act
            var result = board.GetSummaryInfoLiveOrders();

            // Assert
            Assert.AreEqual("5.5 kg for £306", result.FirstOrDefault());
        }
    }
}