using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input a double precision number:");
            Double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The square of the input is: {0}", a * a);
        }
    }
}
