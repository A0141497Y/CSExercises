using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises.Case
{
    class Case2
    {
        // Assumption for case 2: 
        // 1) Block number is always 3 digit.
        // 2) There is always a space between word and number in a address.
        // 3) The input can only be old address

        static void Main(string[] args)
        {
            //Console.WriteLine("Please input the old address:");
            //string AddOld = Console.ReadLine();
            //string AddOld = "Block 201 Ave 6 Clementi Singapore 2352" ;
            string AddOld = "Blk 201B Ave 6 Clementi Singapore 2352";
            string AddNew = "";
            string NewPostal = AddOld.Substring(AddOld.Length-2, 2);
            int ind1 = FindWord(AddOld,"Block");
            int ind2 = FindWord(AddOld,"Blk");
            int ind3 = FindWord(AddOld,"Singapore");

            if (ind1 != -1)
                NewPostal = NewPostal + GetAlphabet(AddOld.Substring(ind1 + 9, 1)) + AddOld.Substring(ind1 + 6, 3);
            else if (ind2 != -1)
                NewPostal = NewPostal + GetAlphabet(AddOld.Substring(ind2 + 7, 1)) + AddOld.Substring(ind2 + 4, 3);
            else
                NewPostal = " No Potal";
            if (ind1 != -1 || ind2 != -1)
                AddNew = AddOld.Substring(0, ind3 + 9 + 1) + NewPostal;
            else
                AddNew = AddOld; ;

            Console.WriteLine("New address:{0}",AddNew);
        }

        public static string GetAlphabet(string A)
        {
            string Alp;
            switch (A)
            {
                case "A":
                    Alp = "1";
                    break;
                case "B":
                    Alp = "2";
                    break;
                case "C":
                    Alp = "3";
                    break;
                case "D":
                    Alp = "4";
                    break;
                case "E":
                    Alp = "5";
                    break;
                case "F":
                    Alp = "6";
                    break;
                case "G":
                    Alp = "7";
                    break;
                case "H":
                    Alp ="8";
                    break;
                default:
                    Alp = "0";
                    break;
            }
            return Alp;
        }
        

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
