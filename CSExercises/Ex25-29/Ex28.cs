using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter an integer:");
            int N = Convert.ToInt32(Console.ReadLine());
            int i=2;
            int ind = 0;
            if (N == 0 || N == 1)
                ind = 1;
            else if (N == 2)
                ind = 0;
            else
            {
                for (i = 2; i < N && ind != 1; i++)
                {
                    if (N % i == 0)
                        ind = 1;
                }
            }


            if (ind == 1)
                Console.WriteLine("Not Prime");
            else
                Console.WriteLine("Prime");
        }
    }
}
