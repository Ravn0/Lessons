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
         * 1.   Напишите программу, вычисляющую среднее арифметическое двух чисел
         */
        public static void Homework1()
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
         * 2.   Введите три числа и выведите на экран значение суммы и произведение этих чисел.
         */
        public static void Homework2()
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
         * 3.   Напишите простой конвертер валют (без возможности динамического выбора валют пользователем).
         *      Валюты заданы харкором и не изменяются. Тип валют на выбор программиста.
         */
        public static void Homework3()
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
         * 4.   Напишите программу, проверяющую число, введенное с клавиатуры, на четность.
         */
        public static void Homework4()
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
         * 5.   Написать калькулятор при помощи конструкции Switch.
         */
        public static void Homework5_Switch()
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
         * 5.   Написать калькулятор при помощи конструкции If.
         */
        public static void Homework5_If()
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
         * 5.   Написать программу для подсчета суммы и количества четных и нечетных чисел в диапазоне заданых пользывателем
         */
        public static void Homework6()
        {
            int rangeFrom, rangeUpTo, qtyEven = 0, qtyUneven = 0, sumEven = 0, sumUneven = 0;
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
            while (rangeFrom < rangeUpTo + 1)
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
            Console.WriteLine($"Итог:\nКоличество четных = {qtyEven}\nКоличество нечетных = {qtyUneven}\nСумма четных чисел = {sumEven}\nСумма нечетных чисел = {sumUneven}");
        }
    }
}
