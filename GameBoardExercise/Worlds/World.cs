using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameBoardExercise.Types;

namespace GameBoardExercise.Worlds
{
    /// <summary>Implementation of a smaller world.</summary>
    public class World : IWorld
    {
        private readonly int min = 0;
        private readonly int max = 4;

        /// <summary>Calculates next coordinate moving forward from selected position.</summary>
        /// <param name="currentPosition">The selected position.</param>
        /// <returns>New position.</returns>
        public PositionVector Move(PositionVector currentPosition)
        {
            int x = 0;
            int y = 0;

            switch (currentPosition.Direction)
            {
                case Direction.Notrh:
                    y = 1;
                    break;
                case Direction.East:
                    x = 1;
                    break;
                case Direction.South:
                    y = -1;
                    break;
                case Direction.West:
                    x = -1;
                    break;
                default:
                    throw new Exception("This direction is not recognised.");
            }

            var newPosition = new PositionVector(currentPosition.X + x, currentPosition.Y + y, currentPosition.Direction);

            if (this.CanMove(newPosition))
            {
                return newPosition;
            }

            return currentPosition;
        }

        /// <summary>Indicated whether it is possible to go forward from location.</summary>
        /// <param name="newPosition">Location to check.</param>
        /// <returns><c>true</c> if going forward is allowed.</returns>
        private bool CanMove(PositionVector newPosition)
        {
            return newPosition.X >= this.min && newPosition.X <= this.max && newPosition.Y >= this.min && newPosition.Y <= this.max;
        }
    }
}
