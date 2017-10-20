using AsyncAwaitTest;
using AsyncAwaitTest.SimpleLogWriters;
using System;
using AsyncAwaitTest.Logger;
using System.Threading;
using System.Threading.Tasks;

namespace AsuncAwaitConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadLogger logger = new ThreadLogger(new ConsoleLogWriter());
            logger.LogMethodNumber = 4;
            var test = new AATest(logger);
            test.UseInnerLogMethodNames = true;

            // WTF with this execution? See: https://habrahabr.ru/post/232169/ and https://msdn.microsoft.com/en-us/magazine/gg598924.aspx
            test.Execute();

            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
