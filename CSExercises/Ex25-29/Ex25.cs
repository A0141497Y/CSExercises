using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.Write("Input a number for finding the factorial:");
            int N = Convert.ToInt32(Console.ReadLine());
            int F, F2, i, j;

            //a --> increment
            F = 1;
            if (N == 0)
                F = 1;
            else 
                for (i=1; i<= N; i++)
                {
                    F = F * i;
                }

            Console.WriteLine("The factorial is {0}.",F);

            //b --> decrement
            F2 = 1;
            if (N == 0)
                F2 = 1;
            else
                for (j = N; j >= 1; j--)
                {
                    F2 = F2 * j;
                }

            Console.WriteLine("The factorial is {0}.", F2);
        }
    }
}
