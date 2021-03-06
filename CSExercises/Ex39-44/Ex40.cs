using System.Data.SqlClient;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Number\tSQRT\t");
            for (int i =1; i<=25;i++)
                Console.WriteLine("{0}\t{1:0.##}\t",i,SQT(i));
        }

        public static double SQT(int N)
        {
            double G;
            if (N == 1)
                G = 1;
            else
            {
                Random r = new Random();
                G = (r.NextDouble()) * (N - 1);
                G = G + 1;
                while (Math.Abs(G * G - N) >= 0.00001)
                {
                    G = (G + N / G) / 2;
                }
            }
            return G;
        }

    }
}
