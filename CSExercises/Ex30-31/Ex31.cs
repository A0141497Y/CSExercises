using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
                        Console.WriteLine("Perfect number from 1 to 1000");
            int N;
            for (N = 1; N <= 1000; N++)
            {
                int i;
                int ind = 0;
                if (N == 0 || N == 1)
                    ind = N + 1;
                else
                {
                    for (i = 1; i < N; i++)
                    {
                        if (N % i == 0)
                            ind = ind + i;
                    }
                }

                if (N == ind)
                    Console.WriteLine("{0}",N);  
            }
        }
    }
}
