using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from MyProject!!!");
            double result = MyMath.Divide(3, 5);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
