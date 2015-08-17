using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input the distance:");
            Double distance = Convert.ToDouble(Console.ReadLine());
            Double dis_round = Math.Ceiling(distance * 10) / 10.0;
            double fare;

            if (dis_round < 0)
            {
                fare = 0;
                Console.WriteLine("The distance is not correct.");  
            }
            else if (dis_round <= 0.5)
                fare = 2.4;
            else if (dis_round <= 9)
                fare = 2.4 + 0.04 * (dis_round - 0.5) / 0.1;
            else
                fare = 2.4 + 8.5 * 0.04 / 0.1 + 0.05 * (dis_round - 9) / 0.1;

            Console.WriteLine("The total fare is: {0:c} ", fare);  
        }
    }
}