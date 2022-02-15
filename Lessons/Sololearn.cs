using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class Sololearn
    {
        public static void Task1()
        {
            int x = 5;
            int y = ++x;
            int z = ++y - ++x;
            y = (y < z) ? x * y : x / y;
            Console.WriteLine(y);
        }
        public static void Task2()
        {
            List<int> items = new List<int>() { 0, 2, 4, 6 };
            Console.WriteLine(items.Single(x => x == 1));
        }
        public static void Task3()
        {
            int a = 5;
            int b = ++a;
            Console.WriteLine(a + b % 3);
        }
        public static void Task4()
        {
            int x = 3;
            int y = 6;
            int z = x + y % 2;
            Console.WriteLine(++z);
        }
        public static void Task5()
        {
            string myname = "user";
            if (myname.Contains("us"))
            {
                Console.WriteLine(":)");
            }
            else
            {
                Console.WriteLine(":(");
            }
        }
        public static void Task6()
        {
            int x = 12;
            x = x << 2;
            Console.WriteLine(x);
        }
        public static void Task7()
        {
            int[] arr = { 10, 15, 16 };
            var x = arr.FirstOrDefault(z => z.Equals(14));
            Console.WriteLine(x + 15);
        }
    }
}
