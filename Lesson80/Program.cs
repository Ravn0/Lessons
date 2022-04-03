using System;

namespace Lesson80
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger consoleLogger = new ConsoleLogger();
            consoleLogger.Log(LogLevel.Debug, "some event");
            consoleLogger.Log(LogLevel.Warning, "some warning");
            consoleLogger.Log(LogLevel.Fatal, "some fatal error");
            consoleLogger.Foo();
            consoleLogger.LogError("some error");
        }
    }
}
