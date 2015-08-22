using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises.Case
{
    class Case1
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input the amount:");
            double Amount = Convert.ToDouble(Console.ReadLine());
            double ADo = Math.Floor(Amount);
            double ACent = Amount - ADo;
            string Result1 = "";
            string Result2 = "";
            string Result = "";

            // Caculate Cents
            if (ACent > 0)
            {
                int ACentInt = Convert.ToInt16(Math.Round(ACent * 100));
                if (ACentInt > 0)
                {
                    Result1 = "Cents " + Transform1(ACentInt) + Result1;
                }
            }

            // Caculate Dollar
            int ADoInt = Convert.ToInt32(ADo);
            if (ADoInt > 0)
            {
                //Result = " and " + Result;
                int T = ADoInt / 1000;
                int H = ADoInt % 1000;
                if (T > 0)
                {
                    if (H == 0)
                        Result2 = Transform2(T) + " Thousand";
                    else
                        Result2 = Transform2(T) + " Thousand " + Transform2(H);
                }
                else
                    Result2 = Transform2(H);
                Result2 = "Dollar " + Result2;
            }

            //Get final result
            if (ADo == 0 && ACent > 0)
                Result = Result1;
            else if (ADo > 0 && ACent == 0)
                Result = Result2;
            else if (ADo > 0 && ACent > 0)
                Result = Result2 + " and " + Result1;
            else if (ACent == 0 && ADo == 0)
                Result = "Zero";
            else
                Result = "Null";
            Result = Result + " only";

            Console.WriteLine("**{0}**", Result);

            //for (int i=800;i<1000;i++)
            //Console.WriteLine("{0}\t *{1}*",i,Transform2(i));
        }



        // Transform an interger from 0-99
        public static string Transform1(int i)
        {
            string result;
            string [] arr1 = new string [10]{"Zero","One","Two","Three","Four","Five","Six","Seven","Eight","Nine"};
            string [] arr2 = new string [10]{"Ten","Eleven","Twelve","Thirteen","Fourteen","Fifteen","Sixteen","Seventeen","Eighteen","Nineteen"};
            string [] arr3 = new string [10]{"","","Twenty","Thirty","Fourty","Fifty","Sixty","Seventy","Eighty","Ninety"};
            if (i<10)
                result = arr1[i];
            else if (i<20)
                result = arr2[i-10];
            else if (i<100)
            {
                if (i%10 == 0)
                    result = arr3[i/10];
                else 
                    result = arr3[i/10] + " " + arr1[i%10];
            }
            else 
                result = "Null";
            return result;
        }

        // Transform an interger from 0-999
        public static string Transform2(int i)
        {
            string result;
            string [] arr1 = new string [10]{"Zero","One","Two","Three","Four","Five","Six","Seven","Eight","Nine"};
            if (i < 100)
                result = Transform1(i);
            else if (i < 1000)
            {
                if (i%100 == 0)
                    result = arr1[i/100] + " hundred";
                else
                    result = arr1[i/100] + " hundred and " + Transform1(i%100);

            }
            else
                result = "Null";
            return result;
        }


        
        //public static string Transform2(int 0-19)
        //public static string Transform3(int 20-99)
        //public static string Transform4(int 0-99)
    
    }
}
