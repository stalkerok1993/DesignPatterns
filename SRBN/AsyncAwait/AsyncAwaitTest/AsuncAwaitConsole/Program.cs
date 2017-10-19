using AsyncAwaitTest;
using AsyncAwaitTest.SimpleLogWriters;
using System;
using AsyncAwaitTest.Logger;

namespace AsuncAwaitConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadLogger logger = new ThreadLogger(new ConsoleLogWriter());
            logger.LogMethodNumber = 4;
            var test = new AATest(logger);
            test.UseInnerLogMethodNames = false;
            test.Execute();

            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
