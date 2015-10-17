using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BauerRobotTest.Commands;
using BauerRobotTest;


namespace BauerRobotTest_Test.CommandsTest
{
    [TestClass]
    public class LeftCommandTest
    {
        [TestMethod]
        public void LeftCommandRun_ShouldChangeDirectionToLeft()
        {
            // Arrange
            Robot testRobot = new Robot();
            testRobot.Position = new Position(0, 0, Direction.North);
            Position expectedPosition = new Position(0, 0, Direction.West);

            // Act
            LeftCommand leftCommand = new LeftCommand();
            bool success = leftCommand.Run(testRobot);

            // Assert
            Assert.IsTrue(expectedPosition.Equals(testRobot.Position));

        }

    }
}
