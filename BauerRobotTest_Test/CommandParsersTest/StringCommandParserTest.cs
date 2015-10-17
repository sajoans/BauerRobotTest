using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BauerRobotTest;
using BauerRobotTest.CommandParsers;
using BauerRobotTest.Commands;

namespace BauerRobotTest_Test.CommandParsersTest
{
    [TestClass]
    public class StringCommandParserTest
    {
        [TestMethod]
        public void Parse_ShouldReturnCommandListWithValidCommands()
        {
            // Arrange
            string commands = "PLACE 0,0,NORTH \n MOVE  \n MOVE";

            StringCommandParser parser = new StringCommandParser();

            // Act
            List<ICommand> cmdList = parser.Parse(commands, new CommandFactory()).ToList() ;

            // Assert
            Assert.AreEqual(3, cmdList.Count);
            Assert.AreEqual(typeof(PlaceCommand), cmdList[0].GetType());
            Assert.AreEqual(typeof(MoveCommand), cmdList[1].GetType());
            Assert.AreEqual(typeof(MoveCommand), cmdList[2].GetType());

        }

        [TestMethod]
        public void Parse_ShouldReturnCorrectNumberOfCommands()
        {
            // Arrange
            string commands = "PLACE 0,0,NORTH " + Environment.NewLine + " MOVE  " + Environment.NewLine + " MOVE";

            StringCommandParser parser = new StringCommandParser();

            // Act
            List<ICommand> cmdList = parser.Parse(commands, new CommandFactory()).ToList();

            // Assert
            Assert.AreEqual(3, cmdList.Count);
        }
    }
}
