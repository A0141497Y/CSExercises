using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input your mark between 0 and 100:");
            int YrScore = Convert.ToInt32(Console.ReadLine());
            String YrGrade;
            if (YrScore >= 80 && YrScore <= 100)
                YrGrade = "A";
            else if (YrScore >= 60 && YrScore <= 79)
                YrGrade = "B";
            else if (YrScore >= 40 && YrScore <= 59)
                YrGrade = "C";
            else if (YrScore >= 0 && YrScore <= 39)
                YrGrade = "F";
            else 
                YrGrade = "**Error**";

            Console.WriteLine("You scored {0} marks which is {1} grade.", YrScore, YrGrade);

        }
    }
}