using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the amount between 0.05 and 3.50:");
            double amount = Convert.ToDouble(Console.ReadLine());
            int k = Convert.ToInt32(Math.Ceiling(amount / 0.05));
            int c100 = k / 20;
            k = k % 20;
            int c50 = k / 10;
            k = k % 10;
            int c20 = k / 4;
            k = k % 4;
            int c5 = k;
            int i;
            while(c100 > 0)
            {
                Console.WriteLine("100c");
                c100--;
            }
            while (c50 > 0)
            {
                Console.WriteLine("50c");
                c50--;
            }
            while (c20 > 0)
            {
                Console.WriteLine("20c");
                c20--;
            }
            while (c5 > 0)
            {
                Console.WriteLine("5c");
                c5--;
            }
        }


    }
}
