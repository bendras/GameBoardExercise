using GameBoardExercise.Types;
using GameBoardExercise.Worlds;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameBoardExercise.Tests
{
    [TestClass]
    public class GameTests
    {
        private Game game;

        private PositionVector ExecuteCommands(string commands)
        {
            foreach (var command in commands)
            {
                this.game.ExecuteCommand(command);
            }
            return this.game.Character.Position;
        }

        [TestInitialize]
        public void Setup()
        {
            this.game = new Game();
        }

        [TestMethod]
        public void Move1()
        {
            var result = this.ExecuteCommands("mrmlmrm");
            Assert.AreEqual(new PositionVector(2, 2, Direction.East), result);
        }

        [TestMethod]
        public void Move2()
        {
            var result = this.ExecuteCommands("rmmmlmm");
            Assert.AreEqual(new PositionVector(3, 2, Direction.Notrh), result);
        }

        [TestMethod]
        public void Move3()
        {
            var result = this.ExecuteCommands("mmmmm");
            Assert.AreEqual(new PositionVector(0, 4, Direction.Notrh), result);
        }
    }
}
