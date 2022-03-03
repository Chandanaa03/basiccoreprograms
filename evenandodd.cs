using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprograms
{
    public class evenandodd
    {
        public static void checkevenandodd()
        {
            int i;

            Console.WriteLine("Enter the number : ");
            i = Convert.ToInt32(Console.ReadLine());
            if  (i % 2 == 0)
            {
                Console.WriteLine("The given number is even");
            }

            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
