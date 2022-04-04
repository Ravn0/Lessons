using System;

namespace Lesson82
{
    interface IPrintable
    {
        void Print();
    }
    struct Point : IPrintable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Print()
        {
            Console.WriteLine($"X:{X}\tY:{Y}");
        }
    }
    class Program
    {
        static void Print(IPrintable printable)
        {
            printable.Print();
        }
        static void Main(string[] args)
        {
            Point point = new Point { X = 2, Y = 4 };
            Print(point);
        }
    }
}
