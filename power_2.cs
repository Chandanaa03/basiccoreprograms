using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprograms
{
    public class power_2
    {
        public static void calculatepower()
        {
            int pow = 1;
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 31)
            {
                for (int i = 0; i < n; i++)
                {
                    pow = pow * 2;
                }
                Console.WriteLine(pow);
            }
        }

    }
}