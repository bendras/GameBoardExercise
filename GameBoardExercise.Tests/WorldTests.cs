using GameBoardExercise.Types;
using GameBoardExercise.Worlds;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameBoardExercise.Tests
{
    [TestClass]
    public class WorldTests
    {
        private void PerformTest(PositionVector initialPosition, PositionVector expectedResult)
        {
            IWorld world = new World();

            var result = world.Move(initialPosition);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Move00North()
        {
            this.PerformTest(new PositionVector(0, 0, Direction.Notrh), new PositionVector(0, 1, Direction.Notrh));
        }

        [TestMethod]
        public void Move00East()
        {
            this.PerformTest(new PositionVector(0, 0, Direction.East), new PositionVector(1, 0, Direction.East));
        }

        [TestMethod]
        public void Move00West()
        {
            this.PerformTest(new PositionVector(0, 0, Direction.West), new PositionVector(0, 0, Direction.West));
        }

        [TestMethod]
        public void Move00South()
        {
            this.PerformTest(new PositionVector(0, 0, Direction.South), new PositionVector(0, 0, Direction.South));
        }
    }
}
