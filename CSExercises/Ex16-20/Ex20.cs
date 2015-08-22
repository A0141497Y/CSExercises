using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter quantity for TV:");
            int TV_qty = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for DVD:");
            int DVD_qty = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for MP3:");
            int MP3_qty = Convert.ToInt32(Console.ReadLine());

            double TV_price = TV_qty * 900;
            double DVD_price = DVD_qty * 500;
            double MP3_price = MP3_qty * 700;
            double TotPrice = TV_price + DVD_price + MP3_price;

            if (TotPrice > 5000 && TotPrice <= 10000)
            {
                TV_price = TV_price * (1 - 0.1);
                DVD_price = DVD_price * (1 - 0.1);
            }
            else if (TotPrice > 10000)
            {
                TV_price = TV_price * (1 - 0.15);
                DVD_price = DVD_price * (1 - 0.15);
            }

            TotPrice = TV_price + DVD_price + MP3_price;

            Console.WriteLine("Total price for this order is: {0:c} ", TotPrice); 
        }
    }
}