using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task40WF
{
    class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SecondName { get; set; }

        public string GetFullName()
        {
            return $"Фамилия: {SecondName ?? "Нет данных"} | Имя: {FirstName ?? "Нет данных"} | Отчество: {MiddleName ?? "Нет данных"}";
        }
    }
}
