// See https://aka.ms/new-console-template for more information
using System;

namespace LogicalProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("select no\n1)fibonacci series\n2)perfect number\n3)Prime number\n4)stopwatch\n)5 reverse number\n)6 coupun number" +
                    "");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        fibonnaci f1 = new fibonnaci();
                        f1.series();
                        break;
                    case 2:
                        perfectNo f2 = new perfectNo();
                        f2.number();
                        break;
                    case 3:
                        primeNo prime = new primeNo();
                        prime.primeNumber();
                        break;
                    case 4:
                        Demo_Stopwatchh W1 = new Demo_Stopwatchh();
                        W1.watch();
                        break;
                    case 5:
                        ReverseExample R1 = new ReverseExample();
                        R1.Reverse();
                        break;
                    case 6:
                        Coupon numb = new Coupon();
                        numb.CouponCode();
                        break;


                }
            }

        }
    }
}
    


