using System;

namespace Richter
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = new Employee() { Name = "Jeff", Age = 45 }.ToString().ToUpper();
            Console.WriteLine(s);
            M();
        }
        public static void M()
        {
            Classroom classroom = new Classroom
            {
                Students = { "Jeff", "Kristin", "Aidan", "Grant" }
            };
            // Вывести имена 4 студентов, находящихся в классе
            foreach (var student in classroom.Students)
                Console.WriteLine(student);
        }
    }
}
