using System;
using System.Collections.Generic;
using System.Text;

namespace SnackAndLadderProblem
{
    class SnakeLadder
    {
        static int position =1;
        static int die;
        
        public static void SnakeLadderGame()
        {
            
            Random random = new Random();
            Console.WriteLine("Position:- " + SnakeLadder.position);
            
            while (true)
                {               
                die = random.Next(1, 6);
                if ((position + die) == 11)
                {
                    position = position + die + 10;
                    Console.WriteLine("Take a 11 to 21 Ladder \n21");
                   
                }                
                if ((position + die) == 49)
                {
                    position = position + die + 32;
                    Console.WriteLine("Take a 49 to 81 Ladder \n81");
                    
                }
                if ((position + die) == 26)
                {
                    position = (position + die) - 20;
                    Console.WriteLine("Take a 26 to 6 snack \n6");
                    
                }
                if ((position + die) == 45)
                {
                    position = (position + die) - 25;
                    Console.WriteLine("Take a 45 to 20 snack \n20");
                   
                }
                if ((position+die)<100&& (position + die) != 94&& (position + die) != 95 && (position + die) != 96 && (position + die) != 97 && (position + die) != 98 && (position + die) != 99&& (position + die) != 100)
                {
                    position += die;
                    Console.WriteLine(position);
                    
                }
                if ((position + die) == 100 || (position + die) == 94 || (position + die) == 95 || (position + die) == 96 || (position + die) == 97 || (position + die) == 98 || (position + die) == 99)
                {
                    position += die;
                    Console.WriteLine(position);
                   
                }
                else if (position == 100)
                    break;
                
                
            }
        }

   }
                
}
            
        
    

