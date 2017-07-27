using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_Chapter_4_终止线程
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting...Program");
            Thread t = new Thread(PrintNumbersWithDelay);
            t.Start();
            Thread.Sleep(TimeSpan.FromSeconds(6));
            t.Abort();//给线程注入ThreadAbortException，导致线程被终结，不一定总能终止线程，目标线程可以通过处理该异常并调用Thread.ResetAbort方法开拒绝被终止
            Console.WriteLine("A thread has been aborted");
            Thread tt = new Thread(PrintNumbers);
            tt.Start();
            PrintNumbers();
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
        static void PrintNumbers()
        {
            Console.WriteLine("Starting...PrintNumbers");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
