using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BauerRobotTest;
using BauerRobotTest.Surfaces;

namespace BauerRobotTest_Test.SurfacesTest
{
    [TestClass]
    public class TableTest
    {
        [TestMethod]
        public void IsValidatePosition_ShouldReturnFalseIfYPositionOutsidePerimeter()
        {

            // Arrange
            Position pos = new Position(2, 7, Direction.North);
            Table table = new Table(5, 5);

            // Act
            bool actualResult = table.IsValidPosition(pos);

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void IsValidatePosition_ShouldReturnFalseIfXPositionOutsidePerimeter()
        {

            // Arrange
            Position pos = new Position(6, 2, Direction.North);
            Table table = new Table(5, 5);

            // Act
            bool actualResult = table.IsValidPosition(pos);

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void IsValidatePosition_ShouldReturnTrueIfInsidePerimeter()
        {

            // Arrange
            Position pos = new Position(2, 2, Direction.North);
            Table table = new Table(5, 5);

            // Act
            bool actualResult = table.IsValidPosition(pos);

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsValidatePosition_ShouldReturnTrueIfOnPerimeter()
        {

            // Arrange
            Position pos = new Position(5, 5, Direction.North);
            Table table = new Table(5, 5);

            // Act
            bool actualResult = table.IsValidPosition(pos);

            // Assert
            Assert.IsTrue(actualResult);
        }
    }
}
