using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main";
            Task task1 = new Task(() => DoStuff1());
            task1.Start();

            #region Task Factory
            Task task2 = Task.Factory.StartNew(() => DoStuff2());
            #endregion

            #region Task Run
            Task<string> task3 = Task.Run<string>(() => DoStuff3());
            #endregion

            Console.WriteLine("I am in main on thread: {0}", 
                Thread.CurrentThread.Name);

            task1.Wait();
            task2.Wait();
            task3.Wait();

            Console.WriteLine("Done waiting. On thread: {0}",
                Thread.CurrentThread.Name);

            Console.WriteLine("Data from task3 {0}", task3.Result);

            Console.ReadLine();

        }

        static void DoStuff1()
        {
            Thread.CurrentThread.Name = "Working";
            Thread.Sleep(5000);
            Console.WriteLine("Doing DoStuff1 on thread: {0}",
                Thread.CurrentThread.Name);
        }

        static void DoStuff2()
        {
            Thread.CurrentThread.Name = "AnotherWork";
            Thread.Sleep(2000);
            Console.WriteLine("Doing DoStuff2 on thread: {0}",
                Thread.CurrentThread.Name);
        }

        static string DoStuff3()
        {
            Thread.CurrentThread.Name = "ThirdWork";
            Thread.Sleep(10000);
            Console.WriteLine("Doing DoStuff3 on thread: {0}",
                Thread.CurrentThread.Name);

            return DateTime.Now.ToShortDateString();
        }
    }
}
