using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter A:");
            int A = Convert.ToInt32(Console.ReadLine());
            int a = A;
            Console.Write("Enter B:");
            int B = Convert.ToInt32(Console.ReadLine());
            int b = B;

            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }

            int HCF = a;
            int LCM = (A * B / HCF);
            Console.WriteLine("HCF {0}:",HCF);
            Console.WriteLine("LCM {0}:",LCM);

        }
    }
}
