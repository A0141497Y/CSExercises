using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex42
    {

        static void Main()
        {
            Console.WriteLine("Please enter the first string:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Please enter the second string:");
            string s2 = Console.ReadLine();

            int ind = FindWord(s1, s2);
            if (ind == -1)
                Console.WriteLine("\"{0}\" is not in \"{1}\"", s2, s1);
            else
                Console.WriteLine("\"{0}\" is in \"{1}\". \nThe first occurance is at position at {2} of \"{1}\"", s2, s1, ind + 1);
        }

        // My assumption: 1) ignore case difference  2) find the position s2 first occurs in s1
        public static int FindWord(string s1, string s2)
        {
            int ind = -1;
            int s1Len, s2Len;
            s1Len = s1.Length;
            s2Len = s2.Length;
            if (s2Len > s1Len)
                ind = -1;
            else
            {
                string s1Lower, s2Lower;
                s1Lower = s1.ToLower();
                s2Lower = s2.ToLower();
                for (int i = 0; i <= (s1Len - s2Len); i++)
                    if (s2Lower == s1Lower.Substring(i, s2Len))
                    {
                        ind = i;
                        break;
                    }
            }
            return ind;
        }




    }
}
