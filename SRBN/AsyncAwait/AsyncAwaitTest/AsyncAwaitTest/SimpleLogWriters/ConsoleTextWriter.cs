using System;

namespace AsyncAwaitTest.SimpleLogWriters
{
    public class ConsoleLogWriter : ISimpleLogWriter
    {
        public void WriteLine(string log)
        {
            Console.WriteLine(log);
        }
    }
}
