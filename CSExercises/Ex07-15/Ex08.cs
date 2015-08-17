using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input temperature in Centigrade scale:");
            Double temp_c = Convert.ToDouble(Console.ReadLine());
            Double temp_f = temp_c * 1.8 + 32;
            Console.WriteLine("The temperature in Fahrenheit is: {0:#.#} ", temp_f); 
        }
    }
}
