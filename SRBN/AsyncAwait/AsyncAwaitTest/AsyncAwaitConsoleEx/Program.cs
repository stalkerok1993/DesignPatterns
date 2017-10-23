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
            Console.WriteLine($"1Has SynchronizationContext? {SynchronizationContext.Current != null}");

            // see RUN method in https://github.com/StephenCleary/AsyncEx/blob/master/src/Nito.AsyncEx.Context/AsyncContext.cs
            //var _taskFactory = new TaskFactory(CancellationToken.None, TaskCreationOptions.HideScheduler, TaskContinuationOptions.HideScheduler, _taskScheduler);
            //_taskFactory.
            StartWithContext();

            GC.Collect();
            Thread.Sleep(2000);
            Console.WriteLine($"5Has SynchronizationContext? {SynchronizationContext.Current != null}");

            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }

        private static void StartWithContext() {
            Console.WriteLine($"2Has SynchronizationContext? {SynchronizationContext.Current != null}");
            using (new DummyForm()) {
                //SynchronizationContext.SetSynchronizationContext(new WindowsFormsSynchronizationContext());
                Console.WriteLine($"3Has SynchronizationContext? {SynchronizationContext.Current != null}");

                ThreadLogger logger = new ThreadLogger(new ConsoleLogWriter());
                logger.LogMethodNumber = 4;
                var test = new AATest(logger);
                test.UseInnerLogMethodNames = true;

                // WTF with this execution? See: https://habrahabr.ru/post/232169/ and https://msdn.microsoft.com/en-us/magazine/gg598924.aspx
                test.Execute();
                //new Thread(StartWithContext).Start(SynchronizationContext.Current);

                Console.WriteLine("Worker thread exited.");
            }
            Console.WriteLine($"4Has SynchronizationContext? {SynchronizationContext.Current != null}");
        }
    }
}
