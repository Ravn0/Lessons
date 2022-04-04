using System;

namespace Lesson81
{
    interface IInterface
    {
        void Foo();
    }
    public class ClassPoint : IInterface
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Foo()
        {
            Console.WriteLine("Foo");
        }

        public void Print()
        {
            Console.WriteLine($"X:{X}\tY:{Y}");
        }
    }
    public struct StructPoint : IInterface
    {
        public StructPoint(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }

        public void Foo()
        {
            Console.WriteLine("Foo");
        }

        public void Print()
        {
            Console.WriteLine($"X:{X}\tY:{Y}");
        }
    }
    class Program
    {
        static void Foo(ClassPoint classPoint)
        {
            classPoint.X++;
            classPoint.Y++;
        }
        static void Bar(StructPoint structPoint)
        {
            structPoint.X++;
            structPoint.Y++;
        }
        static void Main(string[] args)
        {
            ClassPoint classPoint = new ClassPoint();
            ClassPoint classPoint1 = new ClassPoint { X = 2, Y = 3 };
            ClassPoint classPoint2 = new ClassPoint { X = 2, Y = 3 };
            bool classesAreEqual = classPoint1.Equals(classPoint2);
            StructPoint structPoint = new StructPoint();
            StructPoint structPoint1 = new StructPoint { X = 2, Y = 3 };
            StructPoint structPoint2 = new StructPoint { X = 2, Y = 3 };
            bool structsAreEquel = structPoint1.Equals(structPoint2);
            Foo(classPoint);
            Bar(structPoint);
        }
    }
}
