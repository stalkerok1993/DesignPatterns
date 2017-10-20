using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsyncAwaitTest;
using AsyncAwaitTest.Logger;
using AsyncAwaitTest.SimpleLogWriters;

namespace AsyncAwaitConsoleEx {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine($"Has SynchronizationContext? {SynchronizationContext.Current != null}");
            using (new DummyForm()) {
                //SynchronizationContext.SetSynchronizationContext(new WindowsFormsSynchronizationContext());
                Console.WriteLine($"Has SynchronizationContext? {SynchronizationContext.Current != null}");

                ThreadLogger logger = new ThreadLogger(new ConsoleLogWriter());
                logger.LogMethodNumber = 4;
                var test = new AATest(logger);
                test.UseInnerLogMethodNames = true;

                // WTF with this execution? See: https://habrahabr.ru/post/232169/ and https://msdn.microsoft.com/en-us/magazine/gg598924.aspx
                test.Execute();
                //new Thread(StartWithContext).Start(SynchronizationContext.Current);

            }
            GC.Collect();
            Thread.Sleep(2000);
            Console.WriteLine($"Has SynchronizationContext? {SynchronizationContext.Current != null}");

            Console.WriteLine("Press any key to continue . . .");
            //Console.ReadKey();
        }

        private static void StartWithContext(object context) {
            ThreadLogger logger = new ThreadLogger(new ConsoleLogWriter());
            logger.LogMethodNumber = 4;
            var test = new AATest(logger);
            test.UseInnerLogMethodNames = true;

            // WTF with this execution? See: https://habrahabr.ru/post/232169/ and https://msdn.microsoft.com/en-us/magazine/gg598924.aspx
            Task.Factory.StartNew(test.Execute, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());

            Console.WriteLine($"Has SynchronizationContext? {SynchronizationContext.Current != null}");
        }
    }
}
