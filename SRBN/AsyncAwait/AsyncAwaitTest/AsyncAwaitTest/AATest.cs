using AsyncAwaitTest.SimpleLogWriters;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitTest
{
    public class AATest
    {
        #region IrrelevantForAsyncAwait
        ISimpleLogWriter logWriter;

        public AATest(ISimpleLogWriter logWriter)
        {
            this.logWriter = logWriter;
        }
        
        public void Log(string message, string methodName = null)
        {
            if (methodName == null)
            {
                StackTrace st = new StackTrace();
                methodName = st.GetFrame(1).GetMethod().Name;
            }

            logWriter.WriteLine($"[{Thread.CurrentThread.ManagedThreadId,2:D}] {methodName,12:S}: {message}");
        }

        public void LogE(string message)
        {
            Log(message, "Execute");
        }

        public void LogA(string message)
        {
            Log(message, "AsyncTest");
        }

        public void LogD(string message)
        {
            Log(message, "DoSomething");
        }
        #endregion IrrelevantForAsyncAwait

        public void Execute()
        {
            AsyncTest();

            LogE("Block thread (2000 ms). What'll be with ours 'async' call?.");
            Thread.Sleep(2000);
            LogE("Thread unblocked, returning.");
        }

        private async void AsyncTest()
        {
            LogA("Calling 'async DoSomething()' first time.");
            await Task.Run((Action)DoSomething);
            LogA("Call 'async DoSomething()' returned for the first time.");

            LogA("Calling 'async DoSomething()' second time.");
            await Task.Run((Action)DoSomething);
            LogA("Call 'async DoSomething()' returned for the second time.");
        }

        private void DoSomething()
        {
            LogD("Simulate long algorithm (1000 ms).");
            Thread.Sleep(1000);
            LogD("Returning.");
        }
    }
}
