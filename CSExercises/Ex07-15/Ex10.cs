using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input x1:");
            Double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input y1:");
            Double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input x2:");
            Double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input y2:");
            Double y2 = Convert.ToDouble(Console.ReadLine());

            Double distance = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
            Console.WriteLine("The distant of two points is: {0:#.##} ", distance); 
        }
    }
}
