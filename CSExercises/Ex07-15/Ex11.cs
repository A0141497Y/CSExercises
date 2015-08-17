using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input the distance:");
            Double distance = Convert.ToDouble(Console.ReadLine());
            Double fare = 2.4 + 0.4 * distance;
            Console.WriteLine("The total fare is: {0} ", fare);  
        }
    }
}
