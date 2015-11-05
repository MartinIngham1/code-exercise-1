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
        public void RegisterOrder_Should_Accept_Order_Parameter()
        {
            // Arrange
            var order = new Order("Test", "3.5 kg");

            // Act
            board.RegisterOrder(order);
            
            // Assert
        }
    }
}
