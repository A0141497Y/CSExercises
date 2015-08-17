using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input side a:");
            Double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input side b:");
            Double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input side c:");
            Double c = Convert.ToDouble(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Double s = (a + b + c) / 2;
                Double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine("The area of the triangle is: {0:#.##} ", area);
            }
            else
            {
                Console.WriteLine("Error input for a triangle.");
            }



        }
    }
}