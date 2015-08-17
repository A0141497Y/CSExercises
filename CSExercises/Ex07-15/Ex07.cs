using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input salary:");
            Double salary = Convert.ToDouble(Console.ReadLine());
            Double allow_hsing = salary * 0.1;
            Double allow_trsp = salary * 0.03;
            Double tot_inc = salary * 1.13;
            Console.WriteLine("The housing allowance is: {0:c} \nThe transport allowance is: {1:c} \nThe total income is: {2:c} ", allow_hsing, allow_trsp, tot_inc);
        }
    }
}
