using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoardExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();

            string commandParameter = string.Empty;
            while (commandParameter != "x")
            {
                foreach (var commandStep in commandParameter)
                {
                    game.ExecuteCommand(commandStep);
                }
                var position = game.Character.Position;
                Console.WriteLine("Current position is: {0}.", position);

                commandParameter = Console.ReadLine();
            }
        }
    }
}
