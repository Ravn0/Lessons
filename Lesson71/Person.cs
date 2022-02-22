using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson71
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void PrintFullName()
        {
            Console.WriteLine($"Фамилия: {LastName}\t Имя: {FirstName}");
        }
    }
}
