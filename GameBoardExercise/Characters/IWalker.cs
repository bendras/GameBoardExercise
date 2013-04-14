using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameBoardExercise.Types;

namespace GameBoardExercise.Characters
{
    /// <summary>Describes someone on a land.</summary>
    public interface IWalker
    {
        /// <summary>Gets the position.</summary>
        PositionVector Position { get; }

        /// <summary>Rotates right</summary>
        /// <param name="right">rotate right.</param>
        /// <returns>true if successful.</returns>
        bool Rotate(bool right);

        /// <summary>Moves forward.</summary>
        /// <returns>true if successful.</returns>
        bool Move();
    }
}
