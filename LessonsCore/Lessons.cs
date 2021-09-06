using System;
using System.Collections.Generic;
using System.Text;

namespace LessonsCore
{
    class Lessons
    {
        /**
         * Индексы и диапазоны (для .Net Core)
         */
        public static void Task28()
        {
            int[] myArray = { 111, 10, 4, 10, 111, 64, 77, 4, 42, 5 };
            Console.WriteLine(myArray[^1]);      //последний елемент массива, начинается с индекса 1 
            int[] myArray2 = myArray[1..4];      // до 4 индекса
            int[] myArray3 = myArray[..4];       // от начала до 4 индекса
            int[] myArray4 = myArray[5..];       // от 5 индекса до конца

            Index myIndex = new Index(3, true);   //Index myIndex = ^3;
            Console.WriteLine(myArray[myIndex]);
            Console.WriteLine($"value {myIndex.Value} isFromEnd {myIndex.IsFromEnd}");

            Range myRange = new Range(1, 4);    //Range myRange = 1..4;
            int[] myArray5 = myArray[myRange];

            Range myRange1 = ^4..^1;
            int[] myArray6 = myArray[myRange];

            string str = "Hello World !!! =)";
            Console.WriteLine(str[6..11]);
        }
    }
}
