using AsyncAwaitTest.SimpleLogWriters;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using AsyncAwaitTest.Logger;

namespace AsyncAwaitTest
{
    public sealed class AATest
    {
        #region IrrelevantForAsyncAwait
        private ILogger logWriter;
        public bool UseInnerLogMethodNames = false;

        public AATest(ThreadLogger logWriter) {
            this.logWriter = logWriter;
            logWriter.LogMethodDepth = 3;
        }
        
        public void Log(string message, string methodName = null) {
            logWriter.Log(message, UseInnerLogMethodNames ? methodName : null);
        }

        public void LogE(string message) {
            Log(message, "Execute");
        }

        public void LogA(string message) {
            Log(message, "AsyncTest");
        }

        public void LogD(string message) {
            Log(message, "DoSomething");
        }
        #endregion IrrelevantForAsyncAwait

        public void Execute() {
            LogE("Calling AsyncTest method.");
            AsyncTest();
            LogE("AsyncTest method exited.");

            int blockTimeMs = 5000;
            LogE($"Blocking main thread for {blockTimeMs} ms.");
            Thread.Sleep(blockTimeMs);
            LogE("Main thread unblocked, exiting Execute method.");
        }

        private async void AsyncTest() {
            LogA("Calling 'async DoSomething()' method with 'await Task.Run' for the first time.");
            await Task.Run((Action)DoSomething);
            LogA("Call 'async DoSomething()' returned for the first time.");

            LogA("Calling 'async DoSomething()' method with 'await Task.Run' for the second time.");
            await Task.Run((Action)DoSomething);
            LogA("Call 'async DoSomething()' returned for the second time.");
        }

        private void DoSomething() {
            int jobTimeMs = 1000;
            LogD($"Simulate long algorithm in DoSomething (sleep for {jobTimeMs} ms).");
            Thread.Sleep(jobTimeMs);
            LogD("Returning from DoSomething.");
        }
    }
}
