using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.Write("Input a number for finding the square root:");
            double N = Convert.ToDouble(Console.ReadLine());  
            Random r = new Random();
            double G = (r.NextDouble()) * (N-1);
            G = G + 1;
            while (Math.Abs(G * G - N) >= 0.00001)
            {
                G = (G + N / G) / 2;
            }
            Console.WriteLine("{0},{1}", N, G);
        }
    }
}
