using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            double[] Sales = new double[12];
            int i;
            double sum=0;
            double AvgSales, MaxSales, MinSales;
            for (i=0;i<Sales.Length;i++)
            {
                Console.Write("Enter sales for month {0}:",i);
                Sales[i] = Convert.ToInt32(Console.ReadLine());               
            }

            MaxSales = Sales[0];
            MinSales = Sales[0];

            for (i = 0; i < Sales.Length; i++)
            {
                sum = sum + Sales[i];
                if (MaxSales < Sales[i])
                    MaxSales = Sales[i];
                if (MinSales > Sales[i])
                    MinSales = Sales[i];
            }            

            AvgSales = sum / Sales.Length;
            Console.WriteLine("Maximum Sales:{0:0.##}", MaxSales);
            Console.WriteLine("Minimum Sales:{0:0.##}", MinSales);
            Console.WriteLine("Average Sales:{0:0.##}", AvgSales);

        }
    }
}
