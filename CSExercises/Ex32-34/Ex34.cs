using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] score = new int[,]
                {
                    {56,84,68,29},{94,73,31,89},{41,63,36,90},{99,9,18,17},{62,3,65,75},
                    {40,96,53,23},{81,15,27,30},{21,70,100,22},{88,50,13,12},{48,54,52,78},
                    {64,71,67,25},{16,93,46,72}
                };
           // Console.WriteLine("{0},{1}", score.GetLength(0), score.GetLength(1));
            int M = score.GetLength(0);
            int N = score.GetLength(1);
            // a--> total marks for each student
            int[] StuTotal = new int[M];
            int i,j,k,StuSum;
            for (i = 0; i < M; i++)
            {
                StuSum = 0;
                for (j=0;j<N;j++)
                {
                    StuSum = StuSum + score[i, j];
                }
                StuTotal[i] = StuSum;
            }
            Console.Write("Total marks for each student:");
            for (k = 0; k < StuTotal.Length; k++)
                Console.Write("{0}  ", StuTotal[k]);
            Console.WriteLine();
         
            // b--> average marks for each subject

            int[] SubTotal = new int[N];
            double[] SubAvg = new double[N];

            int SubSum;

            for (i = 0; i < N; i++)
            {
                SubSum = 0;
                for (j = 0; j < M; j++)
                {
                    SubSum = SubSum + score[j, i];
                }
                SubTotal[i] = SubSum;
                SubAvg[i] = 1.0 * SubSum / M;

            }
            //Print 
            /*Console.Write("Total marks for each subject:");
            for (k = 0; k < SubTotal.Length; k++)
            {
                Console.Write("{0}  ", SubTotal[k]);
            }
            Console.WriteLine();*/

            Console.Write("Average marks for each subject:");
            for (k = 0; k < SubAvg.Length; k++)
            {
                Console.Write("{0}  ", SubAvg[k]);
            }
            Console.WriteLine();

            //b--> standard deviation of marks for each subject
            double[] SubVar = new double[N];
            double[] SubStdv = new double[N];
            double SubVarTemp=0;
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    SubVarTemp = SubVarTemp + Math.Pow((score[j, i] - SubAvg[i]), 2);
                }
                SubVar[i] = SubVarTemp /M ;
                SubStdv[i] = Math.Sqrt(SubVar[i]);
            }
            //Print
           /* Console.Write("Variance of marks for each subject:");
            for (k = 0; k < SubVar.Length; k++)
            {
                Console.Write("{0:0.##}  ", SubVar[k]);
            }
            Console.WriteLine();*/

            Console.Write("Standard deviation of marks for each subject:");
            for (k = 0; k < SubStdv.Length; k++)
            {
                Console.Write("{0:0.##}  ", SubStdv[k]);
            }
            Console.WriteLine();


            //c--> overall average of marks for whole class for all subjects

            int OverSum = 0;
            double OverAvg;
            for (i = 0; i<M; i++)
            {
                for (j=0;j<N;j++)
                {
                OverSum = OverSum + score[i,j];
                }
            }

            OverAvg = 1.0 * OverSum / M / N;
            Console.WriteLine("Overall average of marks for whole class for all subjects:{0:0.##}", OverAvg);

        }
    }
}
