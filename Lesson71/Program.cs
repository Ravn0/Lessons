using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson71
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher { FirstName = "Мартин", LastName = "Дугин" };
            Student student = new Student { FirstName = "Кей", LastName = "Альтос" };

            Person[] people = { teacher, student };

            PrintPeople(people);
        }

        static void PrintPeople(Person[] people)
        {
            foreach (var person in people)
            {
                person.PrintFullName();
            }
        }
    }
}
