using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Prime number from 1 to 1000");
            int N;
            for (N = 1; N <= 1000; N++)
            {
                int i = 2;
                int ind = 0;
                if (N == 1)
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

                if (ind == 0)
                    Console.WriteLine("{0}",N);
            }
        }
    }
}
