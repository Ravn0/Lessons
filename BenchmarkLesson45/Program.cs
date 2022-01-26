using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkLesson45
{
    class Program
    {
        struct MyStruct
        {
            public decimal a;
            public decimal b;
            public decimal c;
            public decimal d;
            public decimal e;
            public decimal f;
            public decimal g;
            public decimal h;
        }
        static void Foo(MyStruct value)
        {

        }
        static void Bar(in MyStruct value)
        {

        }
        static void Main(string[] args)
        {
            MyStruct a = new MyStruct();
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < int.MaxValue; i++)
            {
                Foo(a);
            }
            sw.Stop();
            Console.WriteLine($"Foo {sw.ElapsedMilliseconds}");
            sw.Restart();
            for (int i = 0; i < int.MaxValue; i++)
            {
                Bar(a);
            }
            sw.Stop();
            Console.WriteLine($"Bar {sw.ElapsedMilliseconds}");
            Console.ReadKey();
        }
    }
}
