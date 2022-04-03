﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson80
{
    public interface ILogger
    {
        void Log(LogLevel logLevel, string message);
        void LogError(string message)
        {
            Log(LogLevel.Error, message);
        }
    }
}
