using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            //23 a;
            /*Random r = new Random();
            int SecretNumber = r.Next(1, 11);
            int guess;
            int i = 0;
            do
            {
                Console.Write("Enter your guess:");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess != SecretNumber)
                    Console.WriteLine("Sorry! Wrong guess!");
                i++;
            } while (guess != SecretNumber);
            
            Console.WriteLine("Congratulation!You get the number {0}. You tried {1} times in this game!", SecretNumber,i); */

            //23 b;
            Random r = new Random();
            int SecretNumber = r.Next(1, 11);
            int guess;
            int i = 0;
            do
            {
                Console.Write("Enter your guess:");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess != SecretNumber)
                    Console.WriteLine("Try again!");
                i++;
            } while (guess != SecretNumber);
            
            if (i <= 2)
                Console.WriteLine("You are a Wizard!"); 
            else if(i <= 5)
                Console.WriteLine("You are a good guess!"); 
            else
                Console.WriteLine("You are a lousy!"); 

        }
    }
}
