using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lessons;

namespace Lessons_MyExtension
{
    /**
    * class MyExtension для Task67()
    */
    static class MyExtension
    {
        public static void Print(this DateTime dateTime)
        {
            Console.WriteLine(dateTime);
        }
        public static bool IsDayOfWeek(this DateTime dateTime, DayOfWeek dayOfWeek)
        {
            return dateTime.DayOfWeek == dayOfWeek;
        }
        public static string GetFullName(this Student67 student)
        {
            return student.LastName + " " + student.FirstName;
        }
    }
}
