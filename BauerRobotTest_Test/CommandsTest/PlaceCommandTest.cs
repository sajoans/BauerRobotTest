using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BauerRobotTest.Commands;
using BauerRobotTest;

namespace BauerRobotTest_Test.CommandsTest
{
    [TestClass]
    public class PlaceCommandTest
    {
        [TestMethod]
        public void PlaceCommandRun_ShouldUpdatePosition()
        {
            // Arrange
            Robot testRobot = new Robot();            
            Position expectedPosition = new Position(0, 0, Direction.East);

            // Act
            PlaceCommand placeCommand = new PlaceCommand(expectedPosition);
            bool success = placeCommand.Run(testRobot);

            // Assert
            Assert.IsTrue(expectedPosition.Equals(testRobot.Position));

        }
    }
}
