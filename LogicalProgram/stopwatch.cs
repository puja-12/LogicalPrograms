using System;
using System.Diagnostics;
using System.Threading; 
class Demo_Stopwatchh 
{
    public void watch()
    {
        Stopwatch stopw = new Stopwatch();
        stopw.Start();
        for (int i = 0; i < 100; i++)
        {
            Thread.Sleep(2);
        }
        stopw.Stop();
        Console.WriteLine(" Time elapsed: {0} ", stopw.Elapsed);
    }
}