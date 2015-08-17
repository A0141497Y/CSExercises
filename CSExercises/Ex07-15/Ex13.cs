using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input the distance:");
            Double distance = Convert.ToDouble(Console.ReadLine());
            Double fare = 2.4 + 0.4 * distance;
            Double fare_round = Math.Ceiling(fare * 10)/10.0;
            Console.WriteLine("The total fare is: {0:0.00} ", fare_round);    
        }
    }
}
