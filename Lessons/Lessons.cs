﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
            Console.WriteLine("Hello World from Lessons!!!");
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
         * Условный оператор switch
         */
        public static void Task15()
        {
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                case 2:
                    Console.WriteLine("Вы ввели число 1 или 2");
                    break;
                default:
                    Console.WriteLine("Я не знаю, что делать с этим числом!");
                    break;
            }

            string b = Console.ReadLine();
            switch (b)
            {
                case "+":
                    Console.WriteLine("Вы ввели плюс");
                    break;
                case "-":
                    Console.WriteLine("Вы ввели минус");
                    break;
                default:
                    Console.WriteLine("Вы ввели неизвестный символ!");
                    break;
            }
        }
        /**
        * Условный оператор switch и enum ConsoleKey
        */
        public static void Task15_1()
        {
            ConsoleKey consoleKey = Console.ReadKey().Key;
            switch (consoleKey)
            {
                case ConsoleKey.Backspace:
                    Console.WriteLine("Вы нажали Backspace!");
                    break;
                case ConsoleKey.Tab:
                    break;
                case ConsoleKey.Clear:
                    break;
                case ConsoleKey.Enter:
                    break;
                case ConsoleKey.Pause:
                    break;
                case ConsoleKey.Escape:
                    break;
                case ConsoleKey.Spacebar:
                    break;
                case ConsoleKey.PageUp:
                    break;
                case ConsoleKey.PageDown:
                    break;
                case ConsoleKey.End:
                    break;
                case ConsoleKey.Home:
                    break;
                case ConsoleKey.LeftArrow:
                    break;
                case ConsoleKey.UpArrow:
                    break;
                case ConsoleKey.RightArrow:
                    break;
                case ConsoleKey.DownArrow:
                    break;
                case ConsoleKey.Select:
                    break;
                case ConsoleKey.Print:
                    break;
                case ConsoleKey.Execute:
                    break;
                case ConsoleKey.PrintScreen:
                    break;
                case ConsoleKey.Insert:
                    break;
                case ConsoleKey.Delete:
                    break;
                case ConsoleKey.Help:
                    break;
                case ConsoleKey.D0:
                    break;
                case ConsoleKey.D1:
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    break;
                case ConsoleKey.D4:
                    break;
                case ConsoleKey.D5:
                    break;
                case ConsoleKey.D6:
                    break;
                case ConsoleKey.D7:
                    break;
                case ConsoleKey.D8:
                    break;
                case ConsoleKey.D9:
                    break;
                case ConsoleKey.A:
                    break;
                case ConsoleKey.B:
                    break;
                case ConsoleKey.C:
                    break;
                case ConsoleKey.D:
                    break;
                case ConsoleKey.E:
                    break;
                case ConsoleKey.F:
                    break;
                case ConsoleKey.G:
                    break;
                case ConsoleKey.H:
                    break;
                case ConsoleKey.I:
                    break;
                case ConsoleKey.J:
                    break;
                case ConsoleKey.K:
                    break;
                case ConsoleKey.L:
                    break;
                case ConsoleKey.M:
                    break;
                case ConsoleKey.N:
                    break;
                case ConsoleKey.O:
                    break;
                case ConsoleKey.P:
                    break;
                case ConsoleKey.Q:
                    break;
                case ConsoleKey.R:
                    break;
                case ConsoleKey.S:
                    break;
                case ConsoleKey.T:
                    break;
                case ConsoleKey.U:
                    break;
                case ConsoleKey.V:
                    break;
                case ConsoleKey.W:
                    break;
                case ConsoleKey.X:
                    break;
                case ConsoleKey.Y:
                    break;
                case ConsoleKey.Z:
                    break;
                case ConsoleKey.LeftWindows:
                    break;
                case ConsoleKey.RightWindows:
                    break;
                case ConsoleKey.Applications:
                    break;
                case ConsoleKey.Sleep:
                    break;
                case ConsoleKey.NumPad0:
                    break;
                case ConsoleKey.NumPad1:
                    break;
                case ConsoleKey.NumPad2:
                    break;
                case ConsoleKey.NumPad3:
                    break;
                case ConsoleKey.NumPad4:
                    break;
                case ConsoleKey.NumPad5:
                    break;
                case ConsoleKey.NumPad6:
                    break;
                case ConsoleKey.NumPad7:
                    break;
                case ConsoleKey.NumPad8:
                    break;
                case ConsoleKey.NumPad9:
                    break;
                case ConsoleKey.Multiply:
                    break;
                case ConsoleKey.Add:
                    break;
                case ConsoleKey.Separator:
                    break;
                case ConsoleKey.Subtract:
                    break;
                case ConsoleKey.Decimal:
                    break;
                case ConsoleKey.Divide:
                    break;
                case ConsoleKey.F1:
                    break;
                case ConsoleKey.F2:
                    break;
                case ConsoleKey.F3:
                    break;
                case ConsoleKey.F4:
                    break;
                case ConsoleKey.F5:
                    break;
                case ConsoleKey.F6:
                    break;
                case ConsoleKey.F7:
                    break;
                case ConsoleKey.F8:
                    break;
                case ConsoleKey.F9:
                    break;
                case ConsoleKey.F10:
                    break;
                case ConsoleKey.F11:
                    break;
                case ConsoleKey.F12:
                    break;
                case ConsoleKey.F13:
                    break;
                case ConsoleKey.F14:
                    break;
                case ConsoleKey.F15:
                    break;
                case ConsoleKey.F16:
                    break;
                case ConsoleKey.F17:
                    break;
                case ConsoleKey.F18:
                    break;
                case ConsoleKey.F19:
                    break;
                case ConsoleKey.F20:
                    break;
                case ConsoleKey.F21:
                    break;
                case ConsoleKey.F22:
                    break;
                case ConsoleKey.F23:
                    break;
                case ConsoleKey.F24:
                    break;
                case ConsoleKey.BrowserBack:
                    break;
                case ConsoleKey.BrowserForward:
                    break;
                case ConsoleKey.BrowserRefresh:
                    break;
                case ConsoleKey.BrowserStop:
                    break;
                case ConsoleKey.BrowserSearch:
                    break;
                case ConsoleKey.BrowserFavorites:
                    break;
                case ConsoleKey.BrowserHome:
                    break;
                case ConsoleKey.VolumeMute:
                    break;
                case ConsoleKey.VolumeDown:
                    break;
                case ConsoleKey.VolumeUp:
                    break;
                case ConsoleKey.MediaNext:
                    break;
                case ConsoleKey.MediaPrevious:
                    break;
                case ConsoleKey.MediaStop:
                    break;
                case ConsoleKey.MediaPlay:
                    break;
                case ConsoleKey.LaunchMail:
                    break;
                case ConsoleKey.LaunchMediaSelect:
                    break;
                case ConsoleKey.LaunchApp1:
                    break;
                case ConsoleKey.LaunchApp2:
                    break;
                case ConsoleKey.Oem1:
                    break;
                case ConsoleKey.OemPlus:
                    break;
                case ConsoleKey.OemComma:
                    break;
                case ConsoleKey.OemMinus:
                    break;
                case ConsoleKey.OemPeriod:
                    break;
                case ConsoleKey.Oem2:
                    break;
                case ConsoleKey.Oem3:
                    break;
                case ConsoleKey.Oem4:
                    break;
                case ConsoleKey.Oem5:
                    break;
                case ConsoleKey.Oem6:
                    break;
                case ConsoleKey.Oem7:
                    break;
                case ConsoleKey.Oem8:
                    break;
                case ConsoleKey.Oem102:
                    break;
                case ConsoleKey.Process:
                    break;
                case ConsoleKey.Packet:
                    break;
                case ConsoleKey.Attention:
                    break;
                case ConsoleKey.CrSel:
                    break;
                case ConsoleKey.ExSel:
                    break;
                case ConsoleKey.EraseEndOfFile:
                    break;
                case ConsoleKey.Play:
                    break;
                case ConsoleKey.Zoom:
                    break;
                case ConsoleKey.NoName:
                    break;
                case ConsoleKey.Pa1:
                    break;
                case ConsoleKey.OemClear:
                    break;
                default:
                    break;
            }
        }
        /**
         * Цикл while
         */
        public static void Task16()
        {
            int count = 0;
            int limit = int.Parse(Console.ReadLine());
            while (count < limit)
            {
                count++;
                Console.WriteLine(count);
            }

        }
        /**
         * Цикл do while
         */
        public static void Task17()
        {
            int count = 0;
            do
            {
                count++;
                Console.WriteLine(count);
            } while (count < 5);
        }
        /**
         * Цикл for
         */
        public static void Task18()
        {
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(i);
            }
        }
        /**
         * Цикл for Особенности
         * несколько переменных
         * Цикл for в обратном порядке
         * несколько условий
         */
        public static void Task19()
        {
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(i);
            }

            for (; ; )
            {
                Console.WriteLine("for is working");
                Thread.Sleep(300);
                break;
            }

            int k = 0;
            for (; k < 3; k++)
            {
                Console.WriteLine("for_1: " + k);
            }
            for (; k < 5; k++)
            {
                Console.WriteLine("for_2: " + k);
            }

            for (int i = 0, j = 5; i < 10 && j < 12; i++, j++)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("j: " + j);
            }

            for (int i = int.Parse(Console.ReadLine()); i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 0, j = 5; i < 5; i++, j--)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("j: " + j);
            }
        }
        /**
         * Ключевое слово break
         */
        public static void Task20()
        {
            for (int i = 0; i < 100; i++)
            {
                string msg = Console.ReadLine();
                if (msg == "exit")
                {
                    break;
                }
                Console.WriteLine(i);
            }

        }
        /**
         * Ключевое слово continue
         */
        public static void Task21()
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
        /**
         * Вложениые цыклы
         */
        public static void Task22()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Цикл 1 итерация №: " + i);
                for (int j = 1; j <= 4; j++)
                {
                    Console.WriteLine("\tЦикл 2 итерация №: " + j);
                    for (int k = 1; k <= 2; k++)
                    {
                        Console.WriteLine("\t\tЦикл 3 итерация №: " + k);
                    }
                }
            }

            Console.Write("Введите высоту прямоугольника: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника: ");
            int width = int.Parse(Console.ReadLine());
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        /**
         * Вспомогательный метод для Task22_1
         */
        public static int[,] GetRandomArray(int rows, int columns)
        {
            Random random = new Random();
            var result = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = random.Next(100);
                }
            }
            return result;
        }
        /**
         * Вложениые цыклы. Пример с 2-х мерным массивом
         */
        public static void Task22_1()
        {
            int rows = 5;
            int columns = 10;
            var myArray = GetRandomArray(rows, columns);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{myArray[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        /**
         * Тернарный оператор
         * 
         * [первый операнд - условие] ? [второй операнд if_true] : [третий операнд if_false]
         */
        public static void Task23()
        {
            int a = 0;
            int b = 1;
            int c = 0;
            //унарный оператор
            a++;
            //бинарный оператор
            c = a + b;

            bool accessAllowed;
            string storedPassword = "qwerty";
            string enteredPassword = Console.ReadLine();
            //if (storedPassword == enteredPassword)
            //{
            //    accessAllowed = true;
            //}
            //else
            //{
            //    accessAllowed = false;
            //}
            accessAllowed = storedPassword == enteredPassword ? true : false; //Тернарный оператор
            Console.WriteLine(accessAllowed);

            int inputData = int.Parse(Console.ReadLine());
            int outputData = inputData < 0 ? 1 : inputData; //Тернарный оператор
            Console.WriteLine(outputData);
        }
        /**
         * Одномерные массивы
         * 
         * Тип_элементов_массива [] имя_масива;
         */
        public static void Task24()
        {
            int[] myArray;
            myArray = new int[5];
            myArray[1] = 3;
            myArray[0] = 10;
            int a = myArray[0];
            int b = myArray.Length;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        /**
         * Массивы
         * 
         * Одномерные массивы
         * 
         * Способы инициализации масива
         */
        public static void Task25()
        {
            int[] myArray1 = new int[5];
            int[] myArray2 = new int[5] { 5, 6, 9, 7, 8 };
            int[] myArray3 = new int[] { 5, 6, 9, 7 };
            int[] myArray4 = new[] { 5, 6, 9, 7 };
            int[] myArray5 = { 5, 6, 9, 7 };
            int[] myArray6 = Enumerable.Repeat(5, 10).ToArray();
            int[] myArray7 = Enumerable.Range(4, 5).ToArray();
        }
        /**
         * Массивы и цыклы
         */
        public static void Task26()
        {
            int[] myArray = { 10, 3, 2, 55 };
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
        /**
         * Как работать с массивами в C# на самом деле
         */
        public static void Task27()
        {
            int[] myArray = { 111, 10, 4, 10, 111, 64, 77, 4, 42, 5 };
            Console.WriteLine(myArray.Min());   // using System.Linq;
            Console.WriteLine(myArray.Sum());
            Console.WriteLine(myArray.Where(i => i % 2 == 0).Sum());
            Console.WriteLine(myArray.Where(i => i % 2 != 0).Min());
            int[] result = myArray.Distinct().ToArray();
            int[] result2 = myArray.OrderBy(i => i).ToArray();
            int[] result3 = myArray.OrderByDescending(i => i).ToArray();
            Array.Sort(myArray);
            int result4 = Array.Find(myArray, i => i < 70);
            int result5 = Array.FindLast(myArray, i => i < 70);
            int[] result6 = Array.FindAll(myArray, i => i < 70);
            int result7 = Array.FindIndex(myArray, i => i == 111);   //если нужного елемента в масиве нет то вернется -1
            int result8 = Array.FindLastIndex(myArray, i => i == 111);
            Array.Reverse(myArray); //записывает массив задом на перед
            int result9 = myArray.Where(i => i < 70).FirstOrDefault();  //Тоже самое что Array.Find(myArray, i => i < 70), дефол = 0 (дефолт нужен если мы не найдем таких значений)
        }
        /**
         * Индексы и диапазоны (для .Net Core)
         */
        public static void Task28()
        {
            //Goto proj LessonsCore
        }
        /**
         * Многомерные массивы
         * 
         * Двумерный прямоугольный массив
         */
        public static void Task29()
        {
            //Теория
        }
        /**
         * Многомерные массивы
         * 
         * Двумерный прямоугольный массив
         * 
         * Объявление (создание)
         * 
         * Инициализация
         * 
         * Обращение к элементам двумерного массива
         */
        public static void Task30()
        {
            //тип_данных [,] имя_массива;
            int[,] myArray = new int[3, 5]
            {
                {2,45,12,51,51},
                {6,7,8,3,1},
                {1,2,65,78,13}
            };
            int[,] myArray2 = new int[,]
            {
                {2,45,12,51,51},
                {6,7,8,3,1},
                {1,2,65,78,13}
            };
            int[,] myArray3 =
            {
                {2,45,12,51,51},
                {6,7,8,3,1},
                {1,2,65,78,13}
            };
            Console.WriteLine(myArray[0, 2]);
            Console.WriteLine(myArray2[0, 2]);
            Console.WriteLine(myArray3[0, 2]);
        }
        /**
         * 
         */
        public static void Task31()
        {

        }
    }
}