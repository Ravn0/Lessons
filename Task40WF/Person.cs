using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task40and42WF
{
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SecondName { get; set; }
        public Contacts Contacts { get; set; }

        public string GetFullName()
        {
            return $"Фамилия: {SecondName ?? "Нет данных"} | Имя: {FirstName ?? "Нет данных"} | Отчество: {MiddleName ?? "Нет данных"}";
        }
        public string GetPhoneNumber()
        {
            return $"Phone Number: {Contacts?.PhoneNumber ?? "Нет данных"}";
        }
    }
}
