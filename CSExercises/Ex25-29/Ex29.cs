using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        { 
            Console.Write("Please enter an integer:");
            int N = Convert.ToInt32(Console.ReadLine());
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
                Console.WriteLine("Perfect Number");
            else
                Console.WriteLine("Not Perfect Number");     
        }
    }
}
