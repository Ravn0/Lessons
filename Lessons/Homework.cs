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
            double UahToEur = 0.0319;
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
    }
}
