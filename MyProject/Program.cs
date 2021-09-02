using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;
using System.Diagnostics;
using System.Threading;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from MyProject!!!");

            /**
             * Использование собственной библиотеки
             */
            double result = MyMath.Divide(3, 5);
            Console.WriteLine(result);

            /**
             * Как измерить время выполнения кода, метода, функции, программы.
             */
            var sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
            sw.Stop();
            Console.WriteLine($"Time Spent: {sw.Elapsed} \nAnd milisecond: {sw.ElapsedMilliseconds}");
            sw.Restart(); // тоже самое что и Reset() + Start()
            Thread.Sleep(555);
            sw.Stop();
            Console.WriteLine($"Time Spent: {sw.Elapsed} \nAnd milisecond: {sw.ElapsedMilliseconds}");


            Console.ReadKey();
        }
    }
}
