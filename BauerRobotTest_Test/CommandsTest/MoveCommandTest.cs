using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BauerRobotTest.Commands;
using BauerRobotTest;
namespace BauerRobotTest_Test.CommandsTest
{
    [TestClass]
    public class MoveCommandTest
    {


        [TestMethod]
        public void MoveCommandRun_ShouldIgnoreIfRobotPositionIsNull()
        {
            // Arrange
            Robot testRobot = new Robot();
            MoveCommand moveCommand = new MoveCommand();

            // Act
            bool success = moveCommand.Run(testRobot);

            // Assert
            Assert.IsFalse(success);
            
        }


        [TestMethod]
        public void MoveCommandRun_ShouldMoveIfPositionExisits()
        {
            // Arrange
            Robot testRobot = new Robot();
            testRobot.Position = new Position(0, 0, Direction.North);
            MoveCommand moveCommand = new MoveCommand();

            // Act
            bool success = moveCommand.Run(testRobot);

            // Assert
            Assert.IsTrue(success);

        }

        [TestMethod]
        public void MoveCommandRun_ShouldMoveOneUnitInFacingDirection()
        {
            // Arrange
            Robot testRobot = new Robot();
            testRobot.Position = new Position(0, 0, Direction.North);
            MoveCommand moveCommand = new MoveCommand();
            Position expectedPosition = new Position(0,1,Direction.North);

            // Act
            bool success = moveCommand.Run(testRobot);

            // Assert
            Assert.IsTrue(expectedPosition.Equals(testRobot.Position));

        }

      
   
    }
}
