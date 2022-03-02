using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprograms
{
    public class harmonicnumber
    {
        public static void harmonic( )
        {
            int i;
            int n = Convert.ToInt32(Console.ReadLine());
            float sum = 0;
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("1/" + i);


                sum = sum + (float)1 / i;



                

            }

            Console.WriteLine("harmonic mean upto " + n + " = " + sum);
        }
    }
}
