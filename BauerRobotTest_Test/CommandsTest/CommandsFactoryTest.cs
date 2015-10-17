using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BauerRobotTest.Commands;

namespace BauerRobotTest_Test.CommandsTest
{
    [TestClass]
    public class CommandsFactoryTest
    {
        [TestMethod]
        public void Factory_ShouldReturnPlaceCommandWithParams()
        {

            // Arrange
            CommandFactory factory = new CommandFactory();

            // Act
            ICommand command = factory.create("PLACE 2,3,NORTH");

            // Assert
            Assert.AreEqual(typeof(PlaceCommand), command.GetType());
        }


        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void Factory_withBadParamsShouldThrowException()
        {
            // Arrange
            CommandFactory factory = new CommandFactory();

            // Act
            ICommand command = factory.create("PLACE 2,3,NOdRTH");

            // Assert
            // Should throw exeption
        }

        [TestMethod]
        public void Factory_ShouldReturnMoveCommand()
        {

            // Arrange
            CommandFactory factory = new CommandFactory();

            // Act
            ICommand command = factory.create("MOVE");

            // Assert
            Assert.AreEqual(typeof(MoveCommand), command.GetType());
        }

        [TestMethod]
        public void Factory_ShouldReturnLeftCommand()
        {

            // Arrange
            CommandFactory factory = new CommandFactory();

            // Act
            ICommand command = factory.create("LEFT");

            // Assert
            Assert.AreEqual(typeof(LeftCommand), command.GetType());
        }

        [TestMethod]
        public void Factory_ShouldReturnRightCommand()
        {

            // Arrange
            CommandFactory factory = new CommandFactory();

            // Act
            ICommand command = factory.create("RIGHT");

            // Assert
            Assert.AreEqual(typeof(RightCommand), command.GetType());
        }

        [TestMethod]
        public void Factory_ShouldReturnReportCommand()
        {

            // Arrange
            CommandFactory factory = new CommandFactory();

            // Act
            ICommand command = factory.create("REPORT");

            // Assert
            Assert.AreEqual(typeof(ReportCommand), command.GetType());
        }

    }
}
