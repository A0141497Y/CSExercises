using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            //a--> Palindrome for word or phrase
            //Console.WriteLine("Please enter a word or phrase:");
            //string s = Console.ReadLine();
            //bool ind = true;
            //for (int i = 0; i < s.Length/2; i++)
            //{
            //    if (s.Substring(i, 1) != s.Substring(s.Length - 1 - i, 1))
            //    {
            //        ind = false;
            //        break;
            //    }
            //}
            //if (ind)
            //    Console.WriteLine("Palindrome");
            //else
            //    Console.WriteLine("Not Palidrome");

            //b--> Palindrome for sentance
            Console.WriteLine("Please enter a sentance:");
            string ss = Console.ReadLine();
            string[] ssSplit = ss.ToLower().Split(new char[] { ' ', ',', '.', '!', '?', '"', '<', '>', '-' }, StringSplitOptions.RemoveEmptyEntries);
            string ssNew = "";
            for (int i = 0; i < ssSplit.Length; i++)
            {
                ssNew = ssNew + ssSplit[i];
                //Console.WriteLine("*{0}*", ssNew);
            }

            bool ind2 = true;
            for (int i = 0; i < ssNew.Length / 2; i++)
            {
                if (ssNew.Substring(i, 1) != ssNew.Substring(ssNew.Length - 1 - i, 1))
                {
                    ind2 = false;
                    break;
                }
            }
            if (ind2)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palidrome");

             

        }
    }
}
