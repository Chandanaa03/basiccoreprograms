using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprograms
{
    public class leapyear
    {
        public static void checkleapyear()
        {
            Console.WriteLine("Enter year: ");
            int Year = Convert.ToInt32(Console.ReadLine());
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                Console.WriteLine("it is leap year");
            else
                Console.WriteLine("This is not leap year");

        }
    }
}
