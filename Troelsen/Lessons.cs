using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troelsen
{
    static class Lessons
    {
        public static void Lesson9_1()
        {
            // Создать массив строковых данных.
            string[] strArray = { "First", "Second", "Third" };
            // Отобразить количество элементов в массиве с помощью свойства Length.
            Console.WriteLine("This array has {0} items.", strArray.Length);
            Console.WriteLine();
            // Отобразить содержимое массива, используя перечислитель,
            foreach (string s in strArray)
            {
                Console.WriteLine("Array Entry: {0}", s);
            }
            Console.WriteLine();
            // Обратить массив и снова вывести его содержимое.
            Array.Reverse(strArray);
            foreach (string s in strArray)
            {
                Console.WriteLine("Array Entry: {0}", s);
            }
        }
        // Для доступа к ArrayList потребуется импортировать
        // пространство имен System.Collections.
        public static void Lesson9_2()
        {
            ArrayList strArray = new ArrayList();
            strArray.AddRange(new string[] { "First", "Second", "Third" });
            // Отобразить количество элементов в ArrayList.
            Console.WriteLine("This collection has {0} items.", strArray.Count);
            Console.WriteLine();
            // Добавить новый элемент и отобразить текущее их количество.
            strArray.Add("Fourth!");
            Console.WriteLine("This collection has {0} items.", strArray.Count);
            // Отобразить содержимое,
            foreach (string s in strArray)
            {
                Console.WriteLine("Entry: {0}", s);
            }
        }
        public static void Lesson9_3()
        {
            int[] mylnts = { 10, 4, 2, 33, 93 };
            // Указание заполнителя для обобщенного метода Sort<>().
            Array.Sort<int>(mylnts);
            foreach (int i in mylnts)
            {
                Console.WriteLine(i);
            }

        }
        public static void Lesson9_4()
        {

        }
    }
}
