﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson80
{
    public static class Extensions
    {
        public static void Foo(this ILogger logger)
        {
            Console.WriteLine("Foo");
        }
    }
}
