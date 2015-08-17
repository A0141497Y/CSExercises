using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("No\t Inverse\t SQUAR ROOT\t SQUAR\n-------------------------------------------------");
            int i;
            double orig,inv,sqrt,sqr;
            for (i = 1; i <= 10; i++)
            {
                orig = i;
                inv = 1.0 / i;
                sqrt = Math.Sqrt(orig);
                sqr = orig * orig;
                Console.WriteLine("{0:0.0##}\t {1:0.0##}\t\t {2:0.0##}\t\t {3:0.0##}\t", orig, inv, sqrt, sqr);
               
            }
        }
    }
}
