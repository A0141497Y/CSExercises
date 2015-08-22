using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises.Case
{
    class Extra2
    {
        static void Main()
        {
            //for(int i = 0; i <= 100;i++)
            //{
            //    int j = Move(i);
            //    Console.WriteLine("{0}\t{1}", i, j);
            //}

            Console.WriteLine("Please enter the number of player:");
            int Player = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            bool GameOver = false;
            int[,] Position = new int[Player,2];
            for (int i = 0; i < Player; i++)
                Position[i,1] = 0;
           do{
                for (int i = 0; i < Player; i++)
                {
                    int D = 0;
                    bool Press0 = false;
                    do
                    {
                        Console.WriteLine("*************************************************************************");
                        Console.WriteLine("Player No.{0}, it is your turn. Please press 0 to throw the dice", i + 1);
                        if (Console.ReadLine() == "0")
                        {
                            D = r.Next(1, 7); // exclude 7
                            Press0 = true;
                        }

                    } while (!Press0);

                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine("Current throw is: {0}", D);
                    Position[i, 1] = Move(Position[i, 1] + D);
                    if (Position[i,1] < 100)
                    PrintPosition(Position);
                    else 
                    {
                        Console.WriteLine("Congratulations!Player No.{0} wins the game!",i+1);
                        GameOver = true;
                        break;
                    }
                } 
            }while (! GameOver);
         
        }

        static int Move(int M)
        {
            int N = M;
            int[,] Pair = new int[,]
            {
                {1,38},{4,14},{7,17},{9,31},{19,62},{21,42},{24,87},{28,84},{34,54},{51,67},{60,64},{71,91},{73,93},{75,95},{79,98},{80,100}
            };
            for (int i = 0; i < Pair.GetLength(0); i++)
            {
                if (M == Pair[i, 0])
                {
                    N = Pair[i, 1];
                    break;
                }
            }
            return N;
        }

        static void PrintPosition(int [,] Pos)
        {
            Console.WriteLine("Current position of each player:\nNo.\tPosition");
            for (int i = 0; i < Pos.GetLength(0); i++)
            {
                if (Pos[i, 1] > 100)
                    Pos[i, 1] = 100;
                Console.WriteLine("{0}\t{1}",i+1,Pos[i,1]);
            }

        }




    }

}
