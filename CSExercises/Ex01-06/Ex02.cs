using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
           Console.WriteLine("Please input an Integer:");
           /*Double b = Convert.ToDouble(Console.ReadLine());
           int a = Convert.ToInt32(b);*/
           int a = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("The square of the input is: {0}", a * a);
        }
    }
}
