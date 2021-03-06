using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase:");
            string s = Console.ReadLine();
            string cpare;          
            int count=0;

            //a--> count of vowels
            for (int i = 0; i<s.Length;i++)
            {
                cpare = s.ToLower().Substring(i, 1);
                if (cpare == "a" || cpare == "e" || cpare == "i" || cpare == "o" || cpare == "u") 
                count++;              
            }
            Console.WriteLine("Total number of vowels:{0}", count);

            //b--> count of each vowel
            string[] vowel = new string[] { "a", "e", "i", "o", "u" };
            int[] CountVowel = new int[] { 0, 0, 0, 0, 0 };

            for (int i=0; i<s.Length; i++)
            {
                cpare = s.ToLower().Substring(i, 1);
                for (int j=0; j<vowel.Length;j++)
                {
                    if (cpare == vowel[j])
                    {
                        CountVowel[j]++;
                        break;
                    }
                }
            }
            for (int i = 0; i < vowel.Length; i++)
                Console.WriteLine("Number of {0}: {1}", vowel[i], CountVowel[i]);
        }
    }
}
