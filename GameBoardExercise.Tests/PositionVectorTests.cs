using GameBoardExercise.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameBoardExercise.Tests
{
    [TestClass]
    public class PositionVectorTests
    {
        [TestMethod]
        public void TransformClockwiseFromNorth()
        {
            PositionVector vector = new PositionVector(0, 0, Direction.Notrh);
            var result = vector.Transform(true);
            Assert.AreEqual(Direction.East, result.Direction);
        }

        [TestMethod]
        public void TransformAntiClockwiseFromNorth()
        {
            PositionVector vector = new PositionVector(0, 0, Direction.Notrh);
            var result = vector.Transform(false);
            Assert.AreEqual(Direction.West, result.Direction);
        }

        [TestMethod]
        public void TransformClockwiseFromWest()
        {
            PositionVector vector = new PositionVector(0, 0, Direction.West);
            var result = vector.Transform(true);
            Assert.AreEqual(Direction.Notrh, result.Direction);
        }

        [TestMethod]
        public void TransformAntiClockwiseFromWest()
        {
            PositionVector vector = new PositionVector(0, 0, Direction.West);
            var result = vector.Transform(false);
            Assert.AreEqual(Direction.South, result.Direction);
        }
    }
}

