using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex39
    {
        public static long Factorial(long n)
        {
            long F = 1;
            if (n == 0)
                F = 1;
            else
            {
                for (int i = 1; i <= n; i++)
                    F = F * i;
            }
            return F;
        }

        static void Main()
        {
            Console.Write("Please enter an interger:");
            long N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Factorial is:{0}", Factorial(N));
        }
    }
}
