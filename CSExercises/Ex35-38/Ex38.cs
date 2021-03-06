using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] Name = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] Mark = new int[] { 63, 29, 75, 82, 55 };
            string title1 = "Name", title2 = "Mark";
            Console.WriteLine("{0}{1}", title1.PadRight(10, ' '), title2);

            // a--> Descending order of marks
            //for (int i = 0; i < Mark.Length - 1; i++)
            //{
            //    int largest = i;
            //    for (int j = i + 1; j < Mark.Length; j++)
            //    {
            //        if (Mark[j] > Mark[largest])
            //            largest = j;
            //    }

            //    int temp = Mark[i];
            //    Mark[i] = Mark[largest];
            //    Mark[largest] = temp;

            //    string tempS = Name[i];
            //    Name[i] = Name[largest];
            //    Name[largest] = tempS;
            //}
            //int k;
            //for (k = 0; k < Mark.Length; k++)
            //{
            //    Console.WriteLine("--------------");
            //    Console.Write("{0}{1}\t", Name[k].PadRight(10, ' '), Mark[k]);
            //    Console.WriteLine();
            //}

            // b--> Sort the report on student names alphabetically
            for (int i = 0; i < Name.Length - 1; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < Name.Length; j++)
                {
                    if (Name[j].CompareTo(Name[smallest]) == -1) //important here
                        smallest = j;
                }

                int temp = Mark[i];
                Mark[i] = Mark[smallest];
                Mark[smallest] = temp;

                string tempS = Name[i];
                Name[i] = Name[smallest];
                Name[smallest] = tempS;
            }
            int k;
            for (k = 0; k < Mark.Length; k++)
            {
                Console.WriteLine("--------------");
                Console.Write("{0}{1}\t", Name[k].PadRight(10, ' '), Mark[k]);
                Console.WriteLine();
            }

            
        }
    }
}
