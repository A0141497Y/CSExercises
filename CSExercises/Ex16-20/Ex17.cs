using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input your name:");
            String YrName = Console.ReadLine();
            Console.WriteLine("Please input your gender, M for Male, F for Female:");
            String YrGender = Console.ReadLine();
            Console.WriteLine("Please input your age with integer:");
            int YrAge = Convert.ToInt32(Console.ReadLine());
            String YrTitle;

            if (YrAge >= 40)
            {
                switch (YrGender)
                {
                    case ("F"):
                        YrTitle = "Aunty";
                        break;
                    case ("M"):
                        YrTitle = "Uncle";
                        break;
                    default:
                        {
                            YrTitle = " ";
                            Console.WriteLine("Please input your gender in exactly way.");
                        }
                        break;
                }
            }
            else
            {
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
            }

            Console.WriteLine("Good Moring {0} {1}", YrTitle, YrName); 
        }
    }
}