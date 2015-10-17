using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BauerRobotTest.Commands;
using BauerRobotTest.Surfaces;
using BauerRobotTest.CommandParsers;
using BauerRobotTest;
using System.Linq;

namespace BauerRobotTest_Test
{
    [TestClass]
    public class CommandCenterTest
    {

        private CommandFactory CommandFactory = new CommandFactory();
        private StringCommandParser StringCommandParser = new StringCommandParser();
        private Table Table = new Table(5, 5);


        [TestMethod]
        public void CommandCenterExecute_ShouldRunGivenCommandsOnRobot()
        {
            // Arrange
            Robot testRobot = new Robot();

            CommandCenter cmc = new CommandCenter(StringCommandParser, testRobot, Table, CommandFactory);
            string commands = "PLACE 0,0,NORTH \n MOVE  \n MOVE \n REPORT";
            Position expectedPosition = new Position(0,2,Direction.North);

            // Act
            cmc.Execute(commands);


            // Assert
            Assert.AreEqual(4, cmc.ExecutedCommands.Count);
            Assert.IsTrue(expectedPosition.Equals(testRobot.Position));


        }

        [TestMethod]
        public void CommandCenterExecute_ShouldIgnoreCommandsUntilRobotPlacedOnValidTablePoint()
        {
            // Arrange
            Robot testRobot = new Robot();

            CommandCenter cmc = new CommandCenter(StringCommandParser, testRobot, Table, CommandFactory);
            string commands = "PLACE 10,0,NORTH \n MOVE  \n MOVE \n PLACE 2,2,SOUTH \n MOVE \n MOVE";
            Position expectedPosition = new Position(2, 0, Direction.South);

            // Act
            cmc.Execute(commands);


            // Assert
            Assert.AreEqual(3, cmc.ExecutedCommands.Count);
            Assert.IsTrue(expectedPosition.Equals(testRobot.Position));


        }

        [TestMethod]
        public void CommandCenterExecute_ShouldIgnoreCommandsThatTakeRobotOusidePerimeterOfSurface()
        {
            // Arrange
            Robot testRobot = new Robot();

            CommandCenter cmc = new CommandCenter(StringCommandParser, testRobot, Table, CommandFactory);
            string commands = "PLACE 5,5,NORTH \n MOVE  \n MOVE \n RIGHT \n RIGHT \n REPORT";
            Position expectedPosition = new Position(5, 5, Direction.South);

            // Act
            cmc.Execute(commands);


            // Assert
            Assert.AreEqual(4, cmc.ExecutedCommands.Count);
            Assert.IsTrue(expectedPosition.Equals(testRobot.Position));
            Assert.IsTrue(expectedPosition.Equals(cmc.Robot.ReportedPositions.FirstOrDefault()));


        }

        [TestMethod]
        public void CommandCenterExecute_ShouldIgnoreCommandsThatTakeRobotOusidePerimeterOfSurface2()
        {
            // Arrange
            Robot testRobot = new Robot();

            CommandCenter cmc = new CommandCenter(StringCommandParser, testRobot, Table, CommandFactory);
            string commands = "PLACE 5,4,NORTH \n MOVE  \n MOVE \n RIGHT \n RIGHT \n REPORT";
            Position expectedPosition = new Position(5, 5, Direction.South);

            // Act
            cmc.Execute(commands);


            // Assert
            Assert.AreEqual(5, cmc.ExecutedCommands.Count);
            Assert.IsTrue(expectedPosition.Equals(testRobot.Position));
            Assert.IsTrue(expectedPosition.Equals(cmc.Robot.ReportedPositions.FirstOrDefault()));


        }


        [TestMethod]
        public void CommandCenterExecute_ShouldIgnoreCommandsThatTakeRobotOusidePerimeterOfSurface3()
        {
            // Arrange
            Robot testRobot = new Robot();

            CommandCenter cmc = new CommandCenter(StringCommandParser, testRobot, Table, CommandFactory);
            string commands = "PLACE 5,4,NORTH \n MOVE  \n MOVE \n RIGHT \n RIGHT \n REPORT \n MOVE \n MOVE \n REPORT";
            Position expectedPosition = new Position(5, 3, Direction.South);

            // Act
            cmc.Execute(commands);


            // Assert
            Assert.AreEqual(8, cmc.ExecutedCommands.Count);
            Assert.IsTrue(expectedPosition.Equals(testRobot.Position));
            Assert.IsTrue(expectedPosition.Equals(cmc.Robot.ReportedPositions[1]));


        }
    }
}
