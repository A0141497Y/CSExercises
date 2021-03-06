using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] ToSort = new int[]
                {
                    86,35,41,49,89,51,11,71,50,75,25,58,40,14,44,3,63,81,93,79
                };
            int i,j;

            //Simplied selection sort algorithm - -decending
           /* for (i=0; i<ToSort.Length-1; i++)
            {
                for (j = i + 1; j < ToSort.Length; j++)
                {
                    if (ToSort[j]>ToSort[i])
                    { 
                        int temp = ToSort[i];
                        ToSort[i] = ToSort[j];
                        ToSort[j] = temp;
                    }
                }
                int k;
                for (k = 0; k < ToSort.Length; k++)
                    Console.Write("{0}  ", ToSort[k]);
                Console.WriteLine();
            }  
            */

            //Refind Simplied selection sort algorithm - -decending
            for (i = 0; i < ToSort.Length - 1; i++)
            {
                int largest = i;
                for (j = i + 1; j < ToSort.Length; j++)
                {
                    if (ToSort[j] > ToSort[largest])
                        largest = j;
                }

                int temp = ToSort[i];
                ToSort[i] = ToSort[largest];
                ToSort[largest] = temp;

                int k;
                for (k = 0; k < ToSort.Length; k++)
                    Console.Write("{0}  ", ToSort[k]);
                Console.WriteLine();
            }


        }
    }
}
