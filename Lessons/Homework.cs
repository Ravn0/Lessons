using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class Homework
    {
        /**
         * Домашнее задание из 8-го урока
         * 
         * 1.1.   Напишите программу, вычисляющую среднее арифметическое двух чисел
         */
        public static void Homework1_1()
        {
            double firstNumber, secondNumber;
            Console.WriteLine("Введите первое число:");
            while (!double.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                Console.WriteLine("Введите первое число:");
            }
            Console.WriteLine("Введите второе число:");
            while (!double.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                Console.WriteLine("Введите второе число:");
            }
            double result = (firstNumber + secondNumber) / 2;
            Console.WriteLine($"Среднее арифметическое двух чисел = {result}");
        }
        /**
         * Домашнее задание из 8-го урока
         * 
         * 1.2.   Введите три числа и выведите на экран значение суммы и произведение этих чисел.
         */
        public static void Homework1_2()
        {
            Console.WriteLine("Введите первое число:");
            double firstNumber, secondNumber, thirdNumber;
            while (!double.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                Console.WriteLine("Введите первое число:");
            }
            Console.WriteLine("Введите второе число:");
            while (!double.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                Console.WriteLine("Введите второе число:");
            }
            Console.WriteLine("Введите третье число:");
            while (!double.TryParse(Console.ReadLine(), out thirdNumber))
            {
                Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                Console.WriteLine("Введите третье число:");
            }
            Console.WriteLine($"Сумма данный чисел = {firstNumber + secondNumber + thirdNumber}\nПроизведение этих числе = {firstNumber * secondNumber * thirdNumber}");
        }
        /**
         * Домашнее задание из 8-го урока
         * 
         * 1.3.   Напишите простой конвертер валют (без возможности динамического выбора валют пользователем).
         *      Валюты заданы харкором и не изменяются. Тип валют на выбор программиста.
         */
        public static void Homework1_3()
        {
            double UahToEur = 0.0318;
            double UahToUsd = 0.0374;
            double UahToRub = 2.75752;
            Console.WriteLine("Введите сумму в UAH:");
            double UAH;
            while (!double.TryParse(Console.ReadLine(), out UAH))
            {
                Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                Console.WriteLine("Введите количество валюты в гривнах:");
            }
            Console.WriteLine($"В евро = {UAH * UahToEur}\nВ долларах США = {UAH * UahToUsd}\nВ рублях = {UAH * UahToRub}");
        }
        /**
         * Домашнее задание из 13-го урока
         * 
         * 2.   Напишите программу, проверяющую число, введенное с клавиатуры, на четность.
         */
        public static void Homework2()
        {
            double firstNumber, secondNumber;
            Console.WriteLine("Введите первое число:");
            while (!double.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                Console.WriteLine("Введите первое число:");
            }
            Console.WriteLine("Введите второе число:");
            while (!double.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                Console.WriteLine("Введите второе число:");
            }
            if (firstNumber % secondNumber == 0)
            {
                Console.WriteLine($"Число {firstNumber} четное (кратное) числу {secondNumber}");
            }
            else
            {
                Console.WriteLine($"Число {firstNumber} НЕ четное (кратное) числу {secondNumber}");
            }
        }
        /**
         * Домашнее задание из 15-го урока
         * 
         * 3.   Написать калькулятор при помощи конструкции Switch.
         */
        public static void Homework3_Switch()
        {
            Console.Title = "Калькулятор";
            double firstValue, secondValue, result = 0;
            string action, toContinue;
            do
            {
                Console.Clear();
                Console.WriteLine("Введите первое число:");
                while (!double.TryParse(Console.ReadLine(), out firstValue))
                {
                    Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                    Console.WriteLine("Введите первое число:");
                }
                Console.WriteLine("Выберите операцию которую вы хотите произвести с числами ('+','-','*','/')");
                action = Console.ReadLine();
                Console.WriteLine("Введите второе число:");
                while (!double.TryParse(Console.ReadLine(), out secondValue))
                {
                    Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                    Console.WriteLine("Введите второе число:");
                }
                switch (action)
                {
                    case "+":
                        result = firstValue + secondValue;
                        break;
                    case "-":
                        result = firstValue - secondValue;
                        break;
                    case "*":
                        result = firstValue * secondValue;
                        break;
                    case "/":
                        if (secondValue != 0)
                        {
                            result = firstValue / secondValue;
                        }
                        break;

                    default:
                        Console.WriteLine("ОШИБКА! Калькулятор сломался!");
                        break;
                }
                Console.WriteLine($"Результат = {result}");
                Console.WriteLine("Посчитаем что-то еще раз? (Да/Нет)");
                toContinue = Console.ReadLine();
                toContinue = toContinue.ToLower();
            }
            while (toContinue == "да");
        }
        /**
         * Домашнее задание из 15-го урока
         * 
         * 3.   Написать калькулятор при помощи конструкции If.
         */
        public static void Homework3_If()
        {
            Console.Title = "Калькулятор";
            double firstValue, secondValue, result = 0;
            string action, toContinue;
            do
            {
                Console.Clear();
                Console.WriteLine("Введите первое число:");
                while (!double.TryParse(Console.ReadLine(), out firstValue))
                {
                    Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                    Console.WriteLine("Введите первое число:");
                }
                Console.WriteLine("Выберите операцию которую вы хотите произвести с числами ('+','-','*','/')");
                action = Console.ReadLine();
                Console.WriteLine("Введите второе число:");
                while (!double.TryParse(Console.ReadLine(), out secondValue))
                {
                    Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                    Console.WriteLine("Введите второе число:");
                }
                if (action == "+")
                {
                    result = firstValue + secondValue;
                }
                else if (action == "-")
                {
                    result = firstValue - secondValue;
                }
                else if (action == "*")
                {
                    result = firstValue * secondValue;
                }
                else if (action == "/" && secondValue != 0)
                {
                    result = firstValue / secondValue;
                }
                else
                {
                    Console.WriteLine("ОШИБКА! Калькулятор сломался!");
                }
                Console.WriteLine($"Результат = {result}");
                Console.WriteLine("Посчитаем что-то еще раз? (Да/Нет)");
                toContinue = Console.ReadLine();
                toContinue = toContinue.ToLower();
            }
            while (toContinue == "да");
        }
        /**
         * Домашнее задание из 16-го урока
         * 
         * 4.   Написать программу для подсчета суммы и количества чётных и нечётных чисел в диапазоне заданых пользывателем
         */
        public static void Homework4()
        {
            int rangeFrom, rangeUpTo, sumEven = 0, sumUneven = 0;
            uint qtyEven = 0, qtyUneven = 0;
            Console.WriteLine("Введите диапазон чисел\nОт:");
            while (!int.TryParse(Console.ReadLine(), out rangeFrom))
            {
                Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                Console.WriteLine("От:");
            }
            Console.WriteLine("До:");
            while (!int.TryParse(Console.ReadLine(), out rangeUpTo))
            {
                Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                Console.WriteLine("До:");
            }
            while (rangeFrom <= rangeUpTo)
            {
                if (rangeFrom % 2 == 0)
                {
                    qtyEven++;
                    sumEven += rangeFrom;
                }
                else
                {
                    qtyUneven++;
                    sumUneven += rangeFrom;
                }
                rangeFrom++;
            }
            Console.WriteLine($"Итог:\nКоличество чётных чисел = {qtyEven}\nКоличество нечётных чисел= {qtyUneven}\nСумма чётных чисел = {sumEven}\nСумма нечётных чисел = {sumUneven}");
        }
        /**
         * Домашнее задание из 22-го урока
         * 
         * 5.   Треугольники в консоли C#
         */
        public static void Homework5()
        {
            int heightTriangle;
            Console.WriteLine("Введите высоту треугольника:");
            while (!int.TryParse(Console.ReadLine(), out heightTriangle))
            {
                Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                Console.WriteLine("Введите высоту треугольника:");
            }
            /*
          
             #
             ##
             ###
             ####
             #####  

            */
            for (int i = 1; i <= heightTriangle; i++)
            {
                Console.WriteLine(new string('#', i));
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
            }
            /*
          
             #####
             ####
             ###
             ##
             #  

            */
            for (int i = heightTriangle; i >= 1; i--)
            {
                Console.WriteLine(new string('#', i));
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
            }
            /*
          
                 #
                ##
               ###
              ####
             #####  

            */
            for (int i = 1, j = heightTriangle - 1; i <= heightTriangle; i++, j--)
            {
                Console.WriteLine(new string(' ', j) + new string('#', i));
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
            }
            /*
          
             #####
              ####
               ###
                ##
                 #  

            */
            for (int i = heightTriangle, j = 0; i >= 1; i--, j++)
            {
                Console.WriteLine(new string(' ', j) + new string('#', i));
            }
        }
        /**
         * Домашнее задание из 22-го урока
         * 
         * 5.   Треугольники в консоли C#
         */
        public static void Homework5V2()
        {
            int heightTriangle;
            Console.WriteLine("Введите высоту треугольника:");
            while (!int.TryParse(Console.ReadLine(), out heightTriangle))
            {
                Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                Console.WriteLine("Введите высоту треугольника:");
            }
            /*
          
             #
             ##
             ###
             ####
             #####  

            */
            for (int i = 0; i < heightTriangle; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
            }
            /*
          
             #####
             ####
             ###
             ##
             #  

            */
            for (int i = 0; i < heightTriangle; i++)
            {
                for (int j = heightTriangle; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
            }
            /*
          
                 #
                ##
               ###
              ####
             #####  

            */
            //for (int i = 0; i < heightTriangle; i++)
            //{
            //    Console.SetCursorPosition(heightTriangle - i - 1, heightTriangle * 3 + i + 1);
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("#");
            //    }
            //}
            //Console.WriteLine();
            for (int i = 0; i < heightTriangle; i++)
            {
                for (int j = heightTriangle - 1; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
            }
            /*
          
             #####
              ####
               ###
                ##
                 #  

            */
            for (int i = 0; i < heightTriangle; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = heightTriangle; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        /**
         * Домашнее задание из 26-го урока
         * 
         * 6.   Заполнить массив с клавиатуры
         * 7.   Вывести массив в обратном порядке
         * 8.   Найти сумму четный числе в массиве.
         * 9.   Найти найменьшее число в масиве.
         */
        public static void Homework6789()
        {
            int[] myArray;
            //6.   Заполнить массив с клавиатуры
            uint elementsCount;
            Console.Write("Введите размер массива:");
            while (!uint.TryParse(Console.ReadLine(), out elementsCount))
            {
                Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                Console.Write("Введите размер массива:");
            }
            myArray = new int[elementsCount];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Введите элемент массива № {i + 1}:");
                while (!int.TryParse(Console.ReadLine(), out myArray[i]))
                {
                    Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                    Console.Write($"Введите элемент массива № { i + 1}:");
                }
            }
            //7.   Вывести массив в обратном порядке
            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine();
            //8.   Найти сумму четный числе в массиве.
            int sumEven = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    sumEven += myArray[i];
                }
            }
            Console.WriteLine($"Сумма четных числе в масиве = {sumEven}");
            //9.   Найти найменьшее число в масиве. 
            Console.WriteLine($"Найменшее число в масиве {myArray.Min()}");
            //9.   Найти найменьшее число в масиве. Версия 2
            int minValue = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                minValue = minValue < myArray[i] ? minValue : myArray[i];
            }
            Console.WriteLine($"Найменшее число в масиве {minValue}");

        }
        /**
         * Домашнее задание из 35-го урока
         * 
         * 10.   Написать метод который выводит на экран строку.
         *       Символы из которых сосоит строка и их количество вводятся пользователем
         */
        public static void Homework10()
        {
            char symbol;    //Console.ReadKey().KeyChar; вместо следующих 6-ти строчек
            Console.Write("Введите символ который хотите вывести: ");
            while (!char.TryParse(Console.ReadLine(), out symbol))
            {
                Console.WriteLine("ОШИБКА! Вы ввели строку а не символ. Попробуйте еще раз.");
                Console.Write("Введите символ который хотите вывести: ");
            }
            uint qtySymbols;
            Console.Write("Сколько раз вы хотите вывести этот символ?: ");
            while (!uint.TryParse(Console.ReadLine(), out qtySymbols))
            {
                Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                Console.Write("Сколько раз вы хотите вывести этот символ?: ");
            }
            Console.WriteLine("Результат:");
            NewString(symbol, qtySymbols);
        }
        /**
         * Домашнее задание из 35-го урока
         * 
         * 10.   Написать метод который выводит на экран строку.
         *       Символы из которых сосоит строка и их количество вводятся пользователем
         */
        public static void Homework10V2()
        {
            Console.Write("Введите строку которую хотите вывести: ");
            string symbol = Console.ReadLine();
            uint qtySymbols;
            Console.Write("Сколько раз вы хотите вывести эту строку?: ");
            while (!uint.TryParse(Console.ReadLine(), out qtySymbols))
            {
                Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                Console.Write("Сколько раз вы хотите вывести этот символ?: ");
            }
            Console.WriteLine("Результат:");
            PrintLine(symbol, qtySymbols);
        }
        /**
         * Вспомогательный метод для Homework10()
         */
        static void NewString(char symbol, uint qtySymbols)
        {
            Console.WriteLine(new string(symbol, (int)qtySymbols));
        }
        /**
         * Вспомогательный метод для Homework10V2()
         */
        static void PrintLine(string symbol, uint symbolCount)
        {
            for (int i = 0; i < symbolCount; i++)
            {
                Console.Write(symbol);
            }
        }
        /**
         * Домашнее задание из 35-го урока
         * 
         * 11.   Написать метод для поиска индекса элемента массива (тип элементов в массиве - int),
         *       метод должен вернуть индекс первого найденного элемента (если он будет найдет).
         */
        public static void Homework11()
        {
            uint rows;
            Console.Write("Введите количетсво строк для массива: ");
            while (!uint.TryParse(Console.ReadLine(), out rows))
            {
                Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                Console.Write("Введите количетсво строк для массива: ");
            }
            uint columns;
            Console.Write("Введите количетсво столбцов для массива: ");
            while (!uint.TryParse(Console.ReadLine(), out columns))
            {
                Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                Console.Write("Введите количетсво столбцов для массива: ");
            }
            int element;
            Console.Write("Введите элемент который хотите найти (типа int): ");
            while (!int.TryParse(Console.ReadLine(), out element))
            {
                Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                Console.Write("Введите элемент который хотите найти (типа int): ");
            }
            var myArray = Lessons.GetRandomArray((int)rows, (int)columns);
            bool elementNotFouded = true;
            int indexI = 0, indexJ = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{myArray[i, j]}\t");
                    if (elementNotFouded && myArray[i, j] == element)
                    {
                        indexI = i;
                        indexJ = j;
                        elementNotFouded = false;
                    }
                }
                Console.WriteLine();
            }
            if (elementNotFouded)
            {
                Console.WriteLine("Элемент не был найден(");
            }
            else
            {
                Console.WriteLine($"Элемент найден.\nСтрока - {indexI}.\nСтолбец - {indexJ}");
            }
        }
        /**
         * Домашнее задание из 43-го урока
         * 
         * 12.   Написать метод Resize изменяющий количиство елементов массива 
         *       (метод должен иметь возможность увеличить или уменьшить количество элементов массива).
         */
        public static void Homework12()
        {
            uint size;
            Console.Write("Введите количетсво элементов: ");
            while (!uint.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                Console.Write("Введите количетсво элементов: ");
            }
            var myArray = GetRandomArray((int)size);
            PrintArray(ref myArray);
            Console.Write("Введите новое количетсво элементов: ");
            while (!uint.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("ОШИБКА! Число было введено не верно. Попробуйте еще раз.");
                Console.Write("Введите новое количетсво элементов: ");
            }
            Resize(ref myArray, ref size);
            PrintArray(ref myArray);

            string[] strArray = { "test", "hello", "world" };
            Resize(ref strArray, ref size);
            PrintArray(ref strArray);
        }
        /**
         * Вспомогательный метод для Homework12()
         */
        static void Resize<T>(ref T[] arr, ref uint newSize)
        {
            T[] newArray = new T[newSize];
            if (newSize == arr.Length)
            {
                return;
            }
            for (int i = 0; i < arr.Length && i < newArray.Length; i++)
            {
                newArray[i] = arr[i];
            }
            arr = newArray;
        }
        /**
         * Вспомогательный метод для Homework12()
         */
        public static int[] GetRandomArray(int size)
        {
            Random random = new Random();
            var result = new int[size];
            for (int i = 0; i < size; i++)
            {
                result[i] = random.Next(100);
            }
            return result;
        }
        /**
         * Вспомогательный метод для Homework12()
         */
        public static void PrintArray<T>(ref T[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]} ");
            }
            Console.WriteLine();
        }
        /**
         * Домашнее задание из 43-го урока
         * 
         * 13.   Написать методы для добавления элемента в начало массива,
         *       в конец массива и по указанному индексу.
         */
        public static void Homework13()
        {
            int[] myArray = GetRandomArray(10);
            PrintArray(ref myArray);
            InsertIntoArrayFirst(ref myArray, -1);
            PrintArray(ref myArray);
            InsertIntoArrayLast(ref myArray, -1);
            PrintArray(ref myArray);
            InsertIntoArray(ref myArray, -1, 6);
            PrintArray(ref myArray);
        }
        /**
         * Вспомогательный метод для Homework13()
         */
        public static void InsertIntoArray<T>(ref T[] myArray, T value, int index)
        {
            T[] newArray = new T[myArray.Length + 1];
            if (index < 0 || index >= newArray.Length)
            {
                Console.WriteLine("Данный индекс не входит в рамки массива");
                return;
            }
            for (int i = 0; i < index; i++)
            {
                newArray[i] = myArray[i];
            }
            newArray[index] = value;
            for (int i = index; i < myArray.Length; i++)
            {
                newArray[i + 1] = myArray[i];
            }
            myArray = newArray;
        }
        /**
         * Вспомогательный метод для Homework13()
         */
        public static void InsertIntoArrayFirst<T>(ref T[] myArray, T value)
        {
            InsertIntoArray(ref myArray, value, 0);
        }
        /**
         * Вспомогательный метод для Homework13()
         */
        public static void InsertIntoArrayLast<T>(ref T[] myArray, T value)
        {
            InsertIntoArray(ref myArray, value, myArray.Length);
        }
        /**
         * Домашнее задание из 43-го урока
         * 
         * 14.   Написать методы для удаления первого элемента массива,
         *       последнего элемента массива 
         *       и элемента по указаному индексу
         */
        public static void Homework14()
        {
            int[] myArray = GetRandomArray(10);
            PrintArray(ref myArray);
            RemoveFromArrayFirst(ref myArray);
            PrintArray(ref myArray);
            RemoveFromArrayLast(ref myArray);
            PrintArray(ref myArray);
            RemoveFromArray(ref myArray, 4);
            PrintArray(ref myArray);
        }
        /**
 * Вспомогательный метод для Homework14()
 */
        public static void RemoveFromArray<T>(ref T[] myArray, int index)
        {
            T[] newArray = new T[myArray.Length - 1];
            if (index < 0 || index > newArray.Length)
            {
                Console.WriteLine("Данный индекс не входит в рамки массива");
                return;
            }
            for (int i = 0; i < index; i++)
            {
                newArray[i] = myArray[i];
            }
            for (int i = index + 1; i < myArray.Length; i++)
            {
                newArray[i - 1] = myArray[i];
            }
            myArray = newArray;
        }
        /**
         * Вспомогательный метод для Homework14()
         */
        public static void RemoveFromArrayFirst<T>(ref T[] myArray)
        {
            RemoveFromArray(ref myArray, 0);
        }
        /**
         * Вспомогательный метод для Homework14()
         */
        public static void RemoveFromArrayLast<T>(ref T[] myArray)
        {
            RemoveFromArray(ref myArray, myArray.Length - 1);
        }
        /**
         * Домашнее задание из 49-го урока
         * 
         * 15.   Реализовать вывод массива с помощью рекурсии.
         */
        public static void Homework15()
        {
            var myArray = GetRandomArray(10);
            PrintArray(myArray);
        }
        /**
         * Вспомогательный метод для Homework15()
         */
        public static void PrintArray<T>(in T[] myArray, int index = 0)
        {
            if (index < myArray.Length)
            {
                Console.Write($"{myArray[index]} ");
                PrintArray(myArray, ++index);
            }
        }
        /**
         * Домашнее задание из 49-го урока
         * 
         * 16.   Найти сумму элементов массива с помощью рекурсии.
         */
        public static void Homework16()
        {
            int[] myArray = { 10, 5, 3, 2 };
            SumArray(myArray);
            int result = Sum(myArray);
            Console.WriteLine(result);
        }
        /**
         * Вспомогательный метод для Homework16()
         */
        public static void SumArray(in int[] myArray, int index = 0, int result = 0)
        {
            if (index < myArray.Length)
            {
                result += myArray[index];
                SumArray(myArray, index + 1, result);
            }
            if (index == myArray.Length)
            {
                Console.WriteLine(result);
            }
        }
        /**
         * Вспомогательный метод для Homework16()
         */
        public static int Sum(in int[] myArray, int index = 0)
        {
            if (index >= myArray.Length)
            {
                return 0;
            }
            return myArray[index] + Sum(myArray, index + 1);
        }
        /**
         * Домашнее задание из 49-го урока
         * 
         * 17.   Найти сумму цифр числа с помощью рекурсии.
         * 
         *       561=12
         */
        public static void Homework17()
        {
            int myValue = 561;
            int result = SumSpecial(myValue);
            Console.WriteLine(result);
            result = 0;
            result = SumSpecialWhile(myValue);
            Console.WriteLine(result);
        }
        /**
         * Вспомогательный метод для Homework17()
         */
        public static int SumSpecial(in int value)
        {
            if (value < 10)
            {
                return value;
            }
            return value % 10 + SumSpecial(value / 10);
        }
        /**
         * Вспомогательный метод для Homework17()
         */
        public static int SumSpecialWhile(int value)
        {
            int result = 0;
            while (value > 0)
            {
                result += value % 10;
                value /= 10;
            }
            return result;
        }
        /**
         * Домашнее задание из -го урока
         * 
         * 18.   Заполнить массив с клавиатуры
         */
        public static void Homework18()
        {

        }
    }
}
