using AsyncAwaitTest;
using AsyncAwaitTest.SimpleLogWriters;
using System;
using System.Threading;

namespace AsyncAwaitConsoleEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentContext = SynchronizationContext.Current;
            SynchronizationContext.SetSynchronizationContext(new SynchronizationContext());

            var test = new AATest(new ConsoleLogWriter());
            test.Execute();

            Console.ReadKey();
        }
    }
}
