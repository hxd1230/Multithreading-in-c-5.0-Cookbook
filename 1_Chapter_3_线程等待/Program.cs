using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_Chapter_3_线程等待
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting...");
            Thread t = new Thread(PrintNumbersWithDelay);
            t.Start();
            t.Join();//直到线程t完成，主程序才会继续运行，实现在两个线程间同步执行步骤
            Console.WriteLine("Thread completed");
            Console.ReadKey();
        }
        static void PrintNumbersWithDelay()
        {
            Console.WriteLine("Starting...PrintNumbersWithDelay");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(2));
                Console.WriteLine(i);
            }
        }
    }
}
