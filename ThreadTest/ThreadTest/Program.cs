using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadTest
{
    class Program
    {
        static void Main()
        {
            Method();
            Method2();

            //Task t1 = new Task(TaskTest);
            //Task t2 = new Task(TaskTest2);

            //t1.Start();
            //t2.Start();

            //t2.Wait();
            //t1.Wait();
        }

        static void TaskTest()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine($"Task {i}");
            }
        }

        static void TaskTest2()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine($"Task2 {i}");
            }
        }

        static void Method()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"method1 {i}");
            }
        }

        static void Method2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"method2 {i}");
            }
        }
    }
}