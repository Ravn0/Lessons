using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    /**
    * class Person68 для Task68()
    */
    partial class Person68
    {
        public partial string GetFullName()
        {
            return LastName + " " + FirstName;
        }
        public void PrintFullName()
        {
            Console.WriteLine(GetFullName());
        }
    }
}
