using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises.Case
{
    class Case3
    {
        static void Main()
        {
            string s = "SeazAme94";
            string Reff = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[]  sNew = new char[s.Length]; 

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'z')
                    sNew[i] = 'a';
                else if(s[i] == 'Z')
                    sNew[i] = 'A';
                else if (s[i] == '9')
                    sNew[i] = '0';
                else
                for (int j = 0; j < Reff.Length;j++)
                {
                    if ( s[i] == Reff[j])
                    {
                        sNew[i]=Reff[j+1];
                        break;
                    }
                 }
            }
            string ss = "";
            for (int i = 0; i < sNew.Length; i++)
                ss = ss + sNew[i];
            Console.WriteLine("{0}-->{1}", s,ss);
        }
    }
}
