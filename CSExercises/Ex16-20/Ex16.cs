using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input your name:");
            String YrName = Console.ReadLine();
            Console.WriteLine("Please input your gender, M for Male, F for Female:");
            String YrGender = Console.ReadLine();
            String YrTitle;
            switch (YrGender)
            {
                case ("F"):
                    YrTitle = "Ms.";
                    break;
                case ("M"):
                    YrTitle = "Mr.";
                    break;
                default:
                    {
                        YrTitle = " ";
                        Console.WriteLine("Please input your gender in exactly way."); 
                    }
                    break;
            }
            Console.WriteLine("Good Moring {0} {1}",YrTitle,YrName);

        }
    }
}