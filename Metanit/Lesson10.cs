using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metanit
{
    public static class Lesson10
    {
        public static void AddToList()
        {
            List<string> people = new List<string>() { "Tom" };

            people.Add("Bob"); // добавление элемента
            // people = { "Tom", "Bob" };

            people.AddRange(new[] { "Sam", "Alice" });   // добавляем массив
            // people = { "Tom", "Bob", "Sam", "Alice" };
            // также можно было бы добавить другой список
            // people.AddRange(new List<string>(){ "Sam", "Alice" });

            people.Insert(0, "Eugene"); // вставляем на первое место
            // people = { "Eugene", "Tom", "Bob", "Sam", "Alice" };

            people.InsertRange(1, new string[] { "Mike", "Kate" }); // вставляем массив с индекса 1
            // people = { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Alice" };
            // также можно было бы добавить другой список
            // people.InsertRange(1, new List<string>(){ "Mike", "Kate" });
        }
        public static void RemoveToList()
        {
            var people = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };

            people.RemoveAt(1); //  удаляем второй элемент
            // people = { "Eugene", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };

            people.Remove("Tom"); //  удаляем элемент "Tom"
            // people = { "Eugene", "Kate", "Bob", "Sam", "Tom", "Alice" };

            // удаляем из списка все элементы, длина строки которых равна 3
            people.RemoveAll(person => person.Length == 3);
            // people = { "Eugene", "Kate", "Alice" };

            // удаляем из списка 2 элемента начиная с индекса 1
            people.RemoveRange(1, 2);
            // people = { "Eugene"};

            // полностью очищаем список
            people.Clear();
            // people = {  };
        }
        public static void FindAndExistsToList()
        {
            var people = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam" };

            var containsBob = people.Contains("Bob");     //  true
            var containsBill = people.Contains("Bill");    // false

            // проверяем, есть ли в списке строки с длиной 3 символа
            var existsLength3 = people.Exists(p => p.Length == 3);  // true

            // проверяем, есть ли в списке строки с длиной 7 символов
            var existsLength7 = people.Exists(p => p.Length == 7);  // false

            // получаем первый элемент с длиной в 3 символа
            var firstWithLength3 = people.Find(p => p.Length == 3); // Tom

            // получаем последний элемент с длиной в 3 символа
            var lastWithLength3 = people.FindLast(p => p.Length == 3);  // Sam

            // получаем все элементы с длиной в 3 символа в виде списка
            List<string> peopleWithLength3 = people.FindAll(p => p.Length == 3);
            // peopleWithLength3 { "Tom", "Bob", "Sam"}
        }
        public static void GetRangeAndCopyToToList()
        {
            List<string> people = new List<string>() { "Eugene", "Tom", "Mike", "Sam", "Bob" };

            // получаем диапазон со второго по четвертый элемент
            var range = people.GetRange(1, 3);
            // range = { "Tom", "Mike", "Sam"};

            // копируем в массив первые три элемента
            string[] partOfPeople = new string[3];
            people.CopyTo(0, partOfPeople, 0, 3);
            // partOfPeople = { "Eugene", "Tom", "Mike"};
        }
        public static void ReverseToList()
        {
            var people = new List<string>() { "Eugene", "Tom", "Mike", "Sam", "Bob" };

            // переворачиваем весь список
            people.Reverse();
            // people = { "Bob","Sam", "Mike", "Tom", "Eugene"};

            var people2 = new List<string>() { "Eugene", "Tom", "Mike", "Sam", "Bob" };
            // переворачиваем часть только 3 элемента с индекса 1
            people2.Reverse(1, 3);
            // people2 = { "Eugene","Sam", "Mike", "Tom", "Bob" };
        }
    }
}
