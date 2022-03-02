using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprograms
{
    public class flip_coin
    {
       public static void flipcoinpercentage()
        {
            int head = 0;
            int tail = 0;
            int headcount = 0;
            int tailcount = 0;

            double headpercentage;
            double tailpercentage;

            int flip = Convert.ToInt32(Console.ReadLine());

            if (flip > 0)
            {
                for (int i = 1; i <= flip; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    Console.WriteLine(number);

                    if (number == 1)
                    {
                        head = 1;
                        headcount += head;
                    }
                    else if (number == 0)
                    {
                        tail = 1;
                        tailcount += tail;
                    }

                }

                Console.WriteLine("-------------");
                headpercentage = (headcount * 100) / flip;
                tailpercentage = (tailcount * 100) / flip;

                Console.WriteLine("headpercentage : " + headpercentage);
                Console.WriteLine("tail percentage : " + tailpercentage);
            }
            else
            {
                Console.WriteLine("enter positive");
            }
        }
    }
}
