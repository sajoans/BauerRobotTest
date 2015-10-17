using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BauerRobotTest.Commands;
using BauerRobotTest;

namespace BauerRobotTest_Test.CommandsTest
{
    [TestClass]
    public class RightCommandTest
    {
        [TestMethod]
        public void RightCommandRun_ShouldChangeDirectionToRight()
        {
            // Arrange
            Robot testRobot = new Robot();
            testRobot.Position = new Position(0, 0, Direction.North);
            Position expectedPosition = new Position(0, 0, Direction.East);

            // Act
            RightCommand rightCommand = new RightCommand();
            bool success = rightCommand.Run(testRobot);

            // Assert
            Assert.IsTrue(expectedPosition.Equals(testRobot.Position));

        }
    }
}
