using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a tile in any case");
            string s = Console.ReadLine();
            string[] sSplit = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string result = "";
            for (int i = 0; i < sSplit.Length; i++)
            {
                string sTemp = sSplit[i].ToLower();
                result = result +sTemp.Substring(0, 1).ToUpper() + sTemp.Substring(1, sTemp.Length - 1) + " ";              
            }
            result = result.Trim();
            Console.WriteLine("=> {0}", result);
        }
    }
}
