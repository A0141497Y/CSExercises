using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            //a
            Console.WriteLine("x\t y\t \n----------------");
            double x, y;
            for (x = -5; x <= 5;  x++)
            {
                y = 2 * x * x - 4 * x + 3;
                Console.WriteLine("{0:0.0}\t {1:0.0}",x,y); 
            }

            //b
            int j;
            for (x = -5; x <= 5; x++)
            {
                y = 2 * x * x - 4 * x + 3;
                for (j = 1; j <= y; j++)
                {
                    Console.Write("*");
                }
                    Console.Write("\n");
            }   
        }
    }
}
