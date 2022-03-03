using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprograms
{
    public class largestnumber
    {
        public static void largest_number()
        {
           int num1, num2, num3;
            Console.WriteLine("Enter the numbers: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());


            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("num1 is largest number");

            }
            else if(num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("num2 is largest");
            }
            else
            {
                Console.WriteLine("num3 is largest");
            }
        }
    }
}
