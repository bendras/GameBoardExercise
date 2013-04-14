using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameBoardExercise.Types;
using GameBoardExercise.Worlds;

namespace GameBoardExercise.Characters
{
    /// <summary>Main player that runs on land.</summary>
    public class Player : IWalker
    {
        private readonly IWorld world;

        /// <summary>Initializes a new instance of the <see cref="Player" /> class.</summary>
        /// <param name="world">World dependency. This should represent the world player is in.</param>
        public Player(IWorld world)
        {
            this.world = world;
        }

        /// <summary>Gets Current position on the map.</summary>
        public PositionVector Position { get; private set; }

        /// <summary>Rotates right</summary>
        /// <param name="right">rotate right.</param>
        /// <returns>true if successful.</returns>
        public bool Rotate(bool right)
        {
            this.Position = this.Position.Transform(right);
            return true;
        }

        /// <summary>Moves forward.</summary>
        /// <param name="forward">move forward.</param>
        /// <returns>true if successful.</returns>
        public bool Move()
        {
            var initialPosition = this.Position;
            this.Position = this.world.Move(this.Position);
            return !initialPosition.Equals(this.Position);
        }
    }
}
