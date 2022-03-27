using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class Super
    {
        static Super()
        {
            Console.Write("hi");
        }
        public Super()
        {
            Console.Write("solo");
        }
    }
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
        public static void Task8()
        {
            string s = "I Love C#";
            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0 || s[i - 1] == ' ')
                {
                    Console.Write(char.ToUpper(s[i]));
                }
                else
                {
                    Console.Write(s[i]);
                }
            }
        }
        public static int Hundred(int value)
        {
            value += (100 - value);
            return value;
        }
        public static void Task9()
        {
            int a = 17;
            if (Hundred(a) != Hundred(71))
            {
                Console.Write("tr");
            }
            else
            {
                Console.Write("fa");
            }
            int b = 31;
            if (Hundred(13) == Hundred(b))
            {
                Console.Write("lse");
            }
            else
            {
                Console.Write("ue");
            }
        }
        public static void Task10()
        {
            new Super();
        }
        public static void Task11()
        {
            string fruit;
            Queue<string> fruits = new Queue<string>();
            fruits.Enqueue("apple");
            fruits.Enqueue("melon");
            fruits.Enqueue("grape");
            fruit = fruits.Dequeue();
            fruits.Enqueue("peach");
            fruit = fruits.Dequeue();
            Console.WriteLine(fruit);
        }
        public static void Task12()
        {
            int x = Math.Max(2, -5);
            int y = Math.Min(3, -7);
            int z = Math.Abs(x * y);
            Console.WriteLine(z);
        }
        public static void Task13()
        {
            string word = "Hello World";
            string[] words = word.Split(' ');
            Console.WriteLine(words[1]);
        }
        public static void Task14()
        {
            uint rangeFrom;
            Console.WriteLine("Введите диапазон чисел\nДо:");
            while (!uint.TryParse(Console.ReadLine(), out rangeFrom))
            {
                Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                Console.WriteLine("До:");
            }
            int a = 0;
            int b = 1;
            int c = a + b;
            switch (rangeFrom)
            {
                case 0:
                    Console.WriteLine("Пошел на хуй со своим 0! И русский корабль забери туда же!");
                    break;
                case 1:
                    Console.WriteLine(a);
                    break;
                case 2:
                    Console.WriteLine(a + "\t" + b);
                    break;
                default:
                    Console.Write(a + "\t" + b + "\t");
                    for (int i = 0; i < rangeFrom - 2; i++)
                    {
                        c = b + a;
                        a = b;
                        b = c;
                        Console.Write(c + "\t");
                    }
                    break;
            }
        }
        public static void Task15()
        {
            uint rangeFrom, rangeUpTo;
            Console.WriteLine("Введите диапазон чисел\nДо:");
            while (!uint.TryParse(Console.ReadLine(), out rangeUpTo))
            {
                Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                Console.WriteLine("До:");
            }
            Console.WriteLine("От:");
            while (!uint.TryParse(Console.ReadLine(), out rangeFrom))
            {
                Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                Console.WriteLine("От:");
            }
            if (rangeFrom == rangeUpTo)
            {
                Console.WriteLine("Пошел на хуй со своим числом от! И русский корабль забери туда же!");
            }
            if (rangeFrom > rangeUpTo)
            {
                var arr = FibonachiArr(rangeFrom);
                for (int i = arr.Length - 1; i >= rangeUpTo; i--)
                {
                    Console.Write(arr[i] + "\t");
                }
            }
            else
            {
                var arr = FibonachiArr(rangeUpTo);
                for (uint i = rangeFrom; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + "\t");
                }
            }
        }
        static int[] FibonachiArr(uint value)
        {
            int[] arr = new int[value];

            int a = 0;
            int b = 1;
            int c = a + b;
            switch (value)
            {
                case 0:
                    Console.WriteLine("Пошел на хуй со своим 0! И русский корабль забери туда же!");
                    break;
                case 1:
                    arr[0] = a;
                    break;
                case 2:
                    arr[0] = a;
                    arr[1] = b;
                    break;
                default:
                    arr[0] = a;
                    arr[1] = b;
                    for (int i = 2; i < value; i++)
                    {
                        c = b + a;
                        a = b;
                        b = c;
                        arr[i] = c;
                    }
                    break;
            }
            return arr;
        }
    }
}
