using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    public class Lessons
    {
        /**
         * Переменные в C#
         * 
         * Объявление (создание) переменных
         * 
         * Инициализация переменных
         * 
         * Присвоение значения переменной (помещение данных)
         */
        public static void Task4()
        {
            Console.WriteLine("Hello World!");
            bool q = true;
            Boolean qw = true;
            Console.WriteLine($"{q} + {qw}");
            var chars = new[]
            {
            'j',
            '\u006A',
            '\x006A',
            (char)106,
            };
            char w = (char)106;
            Console.WriteLine(w);
            Console.WriteLine(string.Join(" ", chars));
            object qwe = '1';
            Console.WriteLine($"{qwe}");
            qwe = "123";
            Console.WriteLine($"{qwe}");
            qwe = 12345;
            Console.WriteLine($"{qwe}");
            Console.WriteLine(System.Text.RegularExpressions.Match.Equals(2, 2));
        }
        /**
         * Ввод данных в консоль
         */
        public static void Task5()
        {
            string data;
            data = Console.ReadLine();
            Console.WriteLine("Првиет " + data + "!!!");
        }
        /**
         * Конвертация строки
         * класс Convert
         */
        public static void Task6()
        {
            string str;
            int a, b;
            Console.WriteLine("Введите первое число");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);
            Console.WriteLine("Введите второе число");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);
            int result = a + b;
            Console.WriteLine("Сумма чисел = " + result);
        }
        /**
         * Конвертация строки
         * класс Convert
         * класс NumberFormatInfo для double
         */
        public static void Task6_1()
        {
            string str = "1.55";
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = "."
            };
            double a = Convert.ToDouble(str, numberFormatInfo);
            Console.WriteLine(a);

            str = "1,44";
            a = Convert.ToDouble(str);
            Console.WriteLine(a);

            a = 1.33;
            Console.WriteLine(a);
        }
        /**
         * конвертация строки
         * parse и tryparse
         */
        public static void Task7()
        {
            string str = "5";
            int a = int.Parse(str);
            Console.WriteLine(a);

            str = "5,9";
            double b = double.Parse(str);
            Console.WriteLine(b);

            str = "5.99";
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = "."
            };
            b = double.Parse(str, numberFormatInfo);
            Console.WriteLine(b);

            str = "1 asd asdaa";
            bool result = int.TryParse(str, out a);
            if (result)
            {
                Console.WriteLine("Операция успешна, значение = " + a);
            }
            else
            {
                Console.WriteLine("Не удалось конвертировать!");
            }
        }
        /**
         * ОПЕРАТОРЫ
         * 
         * Арифметические операции с числами (+,-,*,/,%)
         */
        public static void Task8()
        {
            int a = 2;
            int b = 5;
            int result = a + b;
            Console.WriteLine(result);

            double res = (double)a / b;
            Console.WriteLine(res);

            a = 10;
            b = 3;
            result = a % b;
            Console.WriteLine(result);

            int c = 5;
            result = a + b + c;
            Console.WriteLine(result);

            result = a + 5;
            Console.WriteLine(result);
        }
        /**
         * Приоритет арифметических операций
         */
        public static void Task9()
        {
            int result = 2 + 2 * 2;
            Console.WriteLine(result);

            result = 5 * (4 / 2);
            Console.WriteLine(result);

            result = 5 - 1 + 2;
            Console.WriteLine(result);
        }
        /**
         * Несколько проектов в одном решении
         */
        public static void Task10()
        {
            Console.WriteLine("Hello World from Lessons!");
        }
        /**
         * Инкремент и декремент. Постфиксный и префиксный.
         */
        public static void Task11()
        {
            int a = 0;
            a++;
            Console.WriteLine(a);

            a = 1;
            a = ++a * a;
            Console.WriteLine(a);

            a = 1;
            a = a++ * a;
            Console.WriteLine(a);
        }
        /**
         * Операотры отношений
         * Операции сравнения
         */
        /*
         *          ==  Равно
         *          !=  Не равно
         *          >   Больше   
         *          <   Меньше
         *          >=  Больше или равно
         *          <=  Меньше или равно
         */
        public static void Task12()
        {
            int a = 5;
            int b = 5;
            bool result = a == b;
            Console.WriteLine(result);

            a = 5;
            b = 4;
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);


        }
        /**
         * конструкция if else
         */
        /*
         *          if(утверждение или выражение)
         *          {
         *              действие_1;
         *          }
         *          else
         *          {
         *              действие_2;
         *          }
         */
        public static void Task13()
        {
            bool isInfected = true;
            if (isInfected)
            {
                Console.WriteLine("Персонаж инфицирован!");
            }
            else
            {
                Console.WriteLine("Персонаж здоров!");
            }

            int a;
            a = int.Parse(Console.ReadLine());
            if (a == 5)
            {
                Console.WriteLine("a равно 5");
            }
            else
            {
                Console.WriteLine("a не равно 5");
            }
        }
        /**
         * Логические операторы
         */
        /*
         *          &&      Сокращенное И
         *          ||      Сокращенное ИЛИ
         *          &       И
         *          |       ИЛИ
         *          !       Не (унарный)
         */
        public static void Task14()
        {
            bool isInfected = false;
            if (!isInfected)
            {
                Console.WriteLine("Персонаж здоров!");
            }
            else
            {
                Console.WriteLine("Персонаж инфицирован!");
            }

            int fanSpeed = 0;
            bool isHighTemperature = false;
            bool hasNoCooling = fanSpeed <= 0;
            if (isHighTemperature || hasNoCooling)      //если первое поле true второе даже не проверяется
            {
                Console.WriteLine("Угроза повреждения процессова!!!");
            }

            if (GetTemperature() | GetCoolingStatus())  //разница в том что проверяються оба поля даже если первое true
            {
                Console.WriteLine("Угроза повреждения процессова!!!");
            }
        }
        /**
         * Вспомогательный метод для Task14()
         */
        public static bool GetTemperature()
        {
            return true;
        }
        /**
         * Вспомогательный метод для Task14()
         */
        public static bool GetCoolingStatus()
        {
            return true;
        }
        /**
         * Операотры отношений
         * Операции сравнения
         */
        public static void Task15()
        {

        }
    }
}