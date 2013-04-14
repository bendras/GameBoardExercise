using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameBoardExercise.Types;

namespace GameBoardExercise.Worlds
{
    /// <summary>Describes world.</summary>
    public interface IWorld
    {
        /// <summary>Calculates next coordinate moving forward from selected position.</summary>
        /// <param name="currentPosition">The selected position.</param>
        /// <returns>New position.</returns>
        PositionVector Move(PositionVector currentPosition);
    }
}
