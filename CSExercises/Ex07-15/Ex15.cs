using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input a 3-digit integer:");
            Int32 a = Convert.ToInt32(Console.ReadLine());


            if (a > 99 && a < 1000)
            {
                Int32 a1 = a / 100;
                Int32 a2 = (a - a1 * 100) / 10;
                Int32 a3 = (a - a1 * 100 - a2 * 10);
                    if (a == Math.Pow(a1,3) + Math.Pow(a2,3) + Math.Pow(a3,3))
                    {
                        Console.WriteLine("{0} is an Armstrong number.", a);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not an Armstrong number.", a);
                    } 
            } 
            else
            {
                Console.WriteLine("Error input for a 3-digit integer.");
            }
        }
    }
}