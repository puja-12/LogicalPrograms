using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    class perfectNo
    {
        public void number()
        {


            int x, sum = 0;
            Console.Write("enter the Number : ");
            x = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i < x; i++)
            {
                if (x % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == x)
            {
                Console.WriteLine("Entered number is a perfect number\n");

            }
            else
            {
                Console.WriteLine("Entered number is not a perfect number\n");

            }
        }
    }
}

      
    

