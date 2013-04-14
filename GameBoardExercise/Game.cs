using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameBoardExercise.Characters;
using GameBoardExercise.Worlds;

namespace GameBoardExercise
{
    /// <summary>Game class wrapping command execution.</summary>
    public class Game
    {
        public Game()
        {
            var world = new World();
            this.Character = new Player(world);
        }

        /// <summary>Instance of the character we have controll.</summary>
        public IWalker Character { get; private set; }

        /// <summary>Performs a list of commands on a character.</summary>
        /// <param name="commandParameter">List of commands.</param>
        public void ExecuteCommand(char commandParameter)
        {
            switch (commandParameter)
            {
                case 'm':
                case 'M':
                    this.Character.Move();
                    break;

                case 'l':
                case 'L':
                    this.Character.Rotate(false);
                    break;

                case 'r':
                case 'R':
                    this.Character.Rotate(true);
                    break;

                default:
                    throw new Exception("Unknown command.");
            }
        }
    }
}
