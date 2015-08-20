using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex43
    {
        public static string Hex(int i)
        {
            //string[] HexArr = new string[]{};
            string Temp = "";
            int a, b;
            for (int j = 0; j <= 20; j++)
            {

                a = i % 16;
                b = i / 16;
                Temp = Hex15(a) + Temp;
                if (b == 0)
                    break;
                else
                    i = b;
            }
            return Temp;
        }



        public static string Hex15(int i)
        {
            string H;
            if (i <= 9)
                H = Convert.ToString(i);
            else if (i == 10)
                H = "A";
            else if (i == 11)
                H = "B";
            else if (i == 12)
                H = "C";
            else if (i == 13)
                H = "D";
            else if (i == 14)
                H = "E";
            else if (i == 15)
                H = "F";
            else H = "NULL";
            return H;
        }


        static void Main()
        {

            //Console.WriteLine("Please enter the string:{0}",Hex(389901)); //5F30D

            Console.WriteLine("Number\tHexadecimal\t"); 
            for (int n = 0; n<=100; n++)
                Console.WriteLine("{0}\t{1}\t", n,Hex(n));
        }
    }
}
