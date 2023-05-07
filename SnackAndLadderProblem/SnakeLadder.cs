using System;
using System.Collections.Generic;
using System.Text;

namespace SnackAndLadderProblem
{
    class SnakeLadder
    {
        static int position = 1;
        static int position2 = 0;
        static int die;        

        public static void SnakeLadderGame()
        {
            int play1 = 1;
            int play2 = 2;
            
            Random random = new Random();
            Console.Write("Position1:- " + SnakeLadder.position);
            Console.Write(" Position2:- " + SnakeLadder.position2);

            
                while (position!=100 || position2 != 100)
                {
                for (int i = 1; i <= 2; i++)
                {
                    if (play1 == i)
                        die = random.Next(1, 6);
                    else if (play2 == i)
                        die = random.Next(1, 6);

                    if ((position + die) == 11|| (position2 + die) == 11)
                    {
                        if (play1 == i)
                        {
                            position = position + die + 10;
                            Console.Write("Take a 11 to 21 Ladder" + "  ");
                        }
                        else if (play2 == i)
                        {
                            position = position + die + 10;
                            Console.WriteLine("Take a 11 to 21 Ladder ");
                        }
                       
                        //countTimes++;
                       // break;
                    }
                    if ((position + die) == 49|| (position2 + die) == 49)
                    {
                        if (play1 == i)
                        {
                            position = position + die + 32;
                            Console.Write("Take a 49 to 81 Ladder "+"  ");
                        }
                        else if (play2 == i)
                        {
                            position2 = position2 + die + 32;
                            Console.WriteLine("Take a 49 to 81 Ladder ");
                        }
                        //countTimes++;
                        //break;
                    }
                    if ((position + die) == 26|| (position2 + die) == 26)
                    {
                        if (play1 == i)
                        {
                            position = (position + die) - 20;
                            Console.Write("Take a 26 to 6 snack "+"  ");                            
                        }
                        else if (play2 == i)
                        {
                            position2 = (position2 + die) - 20;
                            Console.WriteLine("Take a 26 to 6 snack ");
                        }
                       
                        //countTimes++;
                        //break;
                    }
                    if ((position + die) == 45|| (position2 + die) == 45)
                    {
                        if (play1 == i)
                        {
                            position = (position + die) - 25;
                            Console.Write("Take a 45 to 20 snack "+"  ");                           
                        }
                        else if (play2 == i)
                        {
                            position2 = (position2 + die) - 25;
                            Console.WriteLine("Take a 45 to 20 snack ");
                        }
                       
                        //countTimes++;
                        //break;
                    }
                    var conditionPosition1 = (position + die) < 100 && (position + die) != 94 && (position + die) != 95 && (position + die) != 96 && (position + die) != 97 && (position + die) != 98 && (position + die) != 99 && (position + die) != 100;
                    var conditionPosition2 = (position2 + die) < 100 && (position2 + die) != 94 && (position2 + die) != 95 && (position2 + die) != 96 && (position2 + die) != 97 && (position2 + die) != 98 && (position2 + die) != 99 && (position2 + die) != 100;
                    if (conditionPosition1)
                    {
                       
                        if (play1 == i)
                        {
                            position += die;
                            Console.Write(position+"  ");
                        }                      
                       
                        //countTimes++;
                        //break;
                    }
                    if (conditionPosition2)
                    {
                        if (play2 == i)
                        {
                            position2 += die;
                            Console.WriteLine(position2);
                        }
                    }
                    var condition11 = (position + die) == 100 || (position + die) == 94 || (position + die) == 95 || (position + die) == 96 || (position + die) == 97 || (position + die) == 98 || (position + die) == 99;
                    var condition12 = (position2 + die) == 100 || (position2 + die) == 94 || (position2 + die) == 95 || (position2 + die) == 96 || (position2 + die) == 97 || (position2 + die) == 98 || (position2 + die) == 99;
                    if (condition11)
                    {
                        if (play1 == i)
                        {
                            position += die;
                            Console.Write(position + "  ");
                        }
                       
                        //countTimes++;
                        //break;
                    }
                    if (condition12)
                    {
                         if (play2 == i)
                        {
                            position2 += die;
                            Console.WriteLine(position2);
                        }
                    }
                    
                    //countTimes++;
                    //Console.WriteLine("Times of Play " + countTimes);
                }
                if (position == 100 || position2 == 100)
                {
                    if (position == 100)                    
                        Console.WriteLine("Player1 Win");                    
                    else
                        Console.WriteLine("Player2 Win");
                    break;
                }
                    
            }


            
        }

    }

}
            
        
    

