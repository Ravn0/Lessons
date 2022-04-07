using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Troelsen
{
    public class IntCollection : IEnumerable
    {
        private ArrayList arlnts = new ArrayList();
        // Получение int (выполняется распаковка) .
        public int Getlnt(int pos) => (int)arlnts[pos];
        // Вставка int (выполняется упаковка).
        public void Addlnt(int i)
        { arlnts.Add(i); }
        public void Clearlnts()
        { arlnts.Clear(); }
        public int Count => arlnts.Count;
        IEnumerator IEnumerable.GetEnumerator() => arlnts.GetEnumerator();
    }

    public class PersonCollection : IEnumerable
    {
        private ArrayList arPeople = new ArrayList();
        // Приведение для вызывающего кода.
        public Person GetPerson(int pos) => (Person)arPeople[pos];
        // Вставка только объектов Person.
        public void AddPerson(Person p)
        { arPeople.Add(p); }
        public void ClearPeople()
        { arPeople.Clear(); }
        public int Count => arPeople.Count;
        // Поддержка перечисления с помощью foreach.
        IEnumerator IEnumerable.GetEnumerator() => arPeople.GetEnumerator();
    }
    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person() { }
        public Person(string firstName, string lastName, int age)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Age: {Age}";
        }
    }
    static class IssuesWithNongenericCollections
    {
        public static void SimpleBoxUnboxOperation()
        {
            // Создать переменную ValueType (int).
            int mylnt = 25;
            // Упаковать int в ссылку на object,
            object boxedlnt = mylnt;
            // Распаковать ссылку обратно в int.
            int unboxedlnt = (int)boxedlnt;
            // Распаковать в неподходящий тип данных, чтобы
            // инициировать исключение времени выполнения.
            try
            {
                long unboxedlnt1 = (long)boxedlnt;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void WorkWithArrayList()
        {
            // Типы значений автоматически упаковываются при передаче
            // методу, который требует экземпляр типа object.
            ArrayList mylnts = new ArrayList();
            mylnts.Add(10);
            mylnts.Add(20);
            mylnts.Add(35);
            // Распаковка происходит, когда объект преобразуется
            // обратно в данные, расположенные в стеке.
            int i = (int)mylnts[0];
            // Теперь значение вновь упаковывается, т.к.
            // метод WriteLine () требует типа object!
            Console.WriteLine("Value of your int: {0}", i);
        }
        public static void ArrayListOfRandomObjects()
        {
            // ArrayList может хранить вообще все что угодно.
            ArrayList allMyObjects = new ArrayList();
            allMyObjects.Add(true);
            allMyObjects.Add(new OperatingSystem(PlatformID.MacOSX, new Version(10, 0)));
            allMyObjects.Add(66);
            allMyObjects.Add(3.14);
        }
        public static void UsePersonCollection()
        {
            Console.WriteLine("***** Custom Person Collection *****\n");
            PersonCollection myPeople = new PersonCollection();
            myPeople.AddPerson(new Person("Homer", "Simpson", 40));
            myPeople.AddPerson(new Person("Marge", "Simpson", 38));
            myPeople.AddPerson(new Person("Lisa", "Simpson", 9));
            myPeople.AddPerson(new Person("Bart", "Simpson", 7));
            myPeople.AddPerson(new Person("Maggie", "Simpson", 2));
            // Это вызовет ошибку на этапе компиляции!
            // myPeople.AddPerson(new Car());
            foreach (Person p in myPeople)
                Console.WriteLine(p);
        }
        public static void UseGenencList()
        {
            Console.WriteLine("***** Fun with Generics *****\n");
            // Этот объект List<> может хранить только объекты Person.
            List<Person> morePeople = new List<Person>();
            morePeople.Add(new Person("Frank", "Black", 50));
            Console.WriteLine(morePeople[0]);
            // Этот объект Listo может хранить только целые числа.
            List<int> morelnts = new List<int>();
            morelnts.Add(10);
            morelnts.Add(2);
            int sum = morelnts[0] + morelnts[1];
            Console.WriteLine(sum);
            // Ошибка на этапе компиляции! Объект Person
            //не может быть добавлен в список элементов int!
            // morelnts.Add(new Person())
        }
    }
}
