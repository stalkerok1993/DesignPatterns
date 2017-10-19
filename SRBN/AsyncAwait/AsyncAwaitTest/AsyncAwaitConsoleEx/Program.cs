using System;
using System.Threading;
using AsyncAwaitTest;
using AsyncAwaitTest.Logger;
using AsyncAwaitTest.SimpleLogWriters;

namespace AsyncAwaitConsoleEx {
    class Program {
        static void Main(string[] args) {
            var currentContext = SynchronizationContext.Current;
            SynchronizationContext.SetSynchronizationContext(new SynchronizationContext());

            var test = new AATest(new ThreadLogger(new ConsoleLogWriter()));
            test.Execute();

            Console.ReadKey();
        }
    }
}
