using AsyncAwaitTest;
using AsyncAwaitTest.SimpleLogWriters;
using System;

namespace AsuncAwaitConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new AATest(new ConsoleLogWriter());
            test.Execute();

            Console.ReadKey();
        }
    }
}
