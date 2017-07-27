using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_Chapter_2_暂停线程
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(PrintNumbersWithDelay);
            t.Start();
            PrintNumbers();
            Console.ReadKey();
        }
        static void PrintNumbers()
        {
            Console.WriteLine("Starting...PrintNumbers");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void PrintNumbersWithDelay()
        {
            Console.WriteLine("Starting...PrintNumbersWithDelay");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(2));//线程等待，不消耗操作系统资源，线程处于休眠状态时，占用尽可能少的cpu时间
                Console.WriteLine(i);
            }
        }
    }
}
