using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int x;
            do
            {
                Console.Write("Please enter an interger:");
                x = Convert.ToInt32(Console.ReadLine());
                if (x!=88)
                    Console.WriteLine("The number is wrong.");
            } while (x != 88);

            Console.WriteLine("Lucky you...");
        }
    }
}
