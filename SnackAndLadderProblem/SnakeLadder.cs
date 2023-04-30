using System;
using System.Collections.Generic;
using System.Text;

namespace SnackAndLadderProblem
{
    class SnakeLadder
    {
        static int position =0;
        public static void SnakeLadderGame()
        {
            Console.WriteLine("Position:- "+SnakeLadder.position);
            Random random = new Random();
            int dice = random.Next(1,6);

            Console.WriteLine("Position:- "+(SnakeLadder.position+dice));
        }
    }
}
