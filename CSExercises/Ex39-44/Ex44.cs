using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex44
    {
        public static string Substitute(string s, char c1, char c2)
        {
            string NewStr = s;
            string s1 = Convert.ToString(c1);
            string s2 = Convert.ToString(c2);

            for (int i = 0; i < s.Length;i++ )
            {
                if (s.Substring(i, 1) == Convert.ToString(c1))
                {
                    if (i == 0)
                        NewStr = c2 + NewStr.Substring(1, NewStr.Length - 1);
                    else
                        NewStr = NewStr.Substring(0, i) + c2 + NewStr.Substring(i+1, NewStr.Length - 1 - i);
                }
            }

                return NewStr;
        }

        static void Main()
        {
            Console.WriteLine("Please enter the string:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Please enter the charactor to be substituted:");
            char c1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please enter the charactor to substitut:");
            char c2 = Convert.ToChar(Console.ReadLine());

            string a = Substitute(s1,c1,c2);
            Console.WriteLine("{0}",a);
        }
    }
}
