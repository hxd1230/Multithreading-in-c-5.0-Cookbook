using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_Chapter_5_检测线程状态
{
    class Program
    {
        //线程是独立运行的，其状态可以在任何时候被改变
        static void Main(string[] args)
        {
            Console.WriteLine("Starting...Program");
            Thread t = new Thread(PrintNumbersWithStatus);
            Thread t2 = new Thread(DoNothing);
            t2.Start();
            t.Start();
            for (int i = 1; i < 30; i++)
            {
                Console.WriteLine("30循环 t state：" + t.ThreadState.ToString());
            }
            Console.WriteLine("睡眠6ms");
            Thread.Sleep(TimeSpan.FromSeconds(6));
            t.Abort();
            Console.WriteLine("A thread has been aborted");
            Console.WriteLine("t state：" + t.ThreadState.ToString());
            Console.WriteLine("t2 state：" + t2.ThreadState.ToString());
            Console.ReadKey();
        }
        static void DoNothing()
        {
            Console.WriteLine("DoNothing");
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
        static void PrintNumbersWithStatus()
        {
            Console.WriteLine("Starting...PrintNumbersWithStatus");
            Console.WriteLine("PrintNumbersWithStatus status:" + Thread.CurrentThread.ThreadState.ToString());
            for (int i = 1; i < 10; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(2));//WaitSleepJoin
                Console.WriteLine("i :" + i);
            }
        }
    }
}