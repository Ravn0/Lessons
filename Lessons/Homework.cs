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
            for (int i = 1, j = heightTriangle; i <= heightTriangle; i++, j--)
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

        public static void Homework5_V_2()
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
    }
}
