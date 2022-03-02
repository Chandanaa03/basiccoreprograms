using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprograms
{
    public class quotientandremainder
    {
       
            public static void calculatequotientandremainder( )
            {

                     int  dividend = 10;
                     int divisor = 5;

                int quotient = dividend / divisor;
                int remainder = dividend % divisor;

                Console.WriteLine("Dividend: {0} Divisor :{1}", dividend, divisor);
                Console.WriteLine("Quotient : {0}", quotient);
                Console.WriteLine("Remainder : {0}", remainder);
            }
        
    }
}
