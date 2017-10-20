using System;
using System.Threading;
using System.Threading.Tasks;
using AsyncAwaitTest.Logger;

namespace AsyncAwaitTest {
    public sealed class AATest
    {
        #region IrrelevantForAsyncAwait
        private ILogger logWriter;
        public bool UseInnerLogMethodNames = false;

        public AATest(ThreadLogger logWriter) {
            this.logWriter = logWriter;
            logWriter.LogMethodDepth = 3;
        }
        
        private void Log(string message, string methodName = null) {
            logWriter.Log(message, UseInnerLogMethodNames ? methodName : null);
        }

        private void LogE(string message) {
            Log(message, "Execute");
        }

        private void LogA(string message) {
            Log(message, "AsyncTest");
        }

        private void LogD(string message) {
            Log(message, "DoSomething");
        }
        #endregion IrrelevantForAsyncAwait

        public void Execute() { // M
            LogE("Calling AsyncTest method."); // M
            AsyncTest(); // M
            LogE("AsyncTest method exited.");

            int blockTimeMs = 1000; // M
            LogE($"Blocking main thread for {blockTimeMs} ms - first time.");
            Thread.Sleep(blockTimeMs); // M

            LogE($"Blocking main thread for {blockTimeMs} ms - second time.");
            Thread.Sleep(blockTimeMs); // M

            LogE("Main thread unblocked, exiting Execute method.");
        }

        private async void AsyncTest() { // M
            LogA("Calling 'async DoSomething()' method with 'await Task.Run' for the first time."); // M
            Task task = Task.Run((Action)DoSomething); // M

            int jobTimeMs = 500;
            LogD($"Simulate long algorithm in AsyncTest (sleep for {jobTimeMs} ms).");
            Thread.Sleep(jobTimeMs);
            LogD("Job ended.");

            await task; // T1
            LogA("Call 'async DoSomething()' returned for the first time."); // M

            LogA("Calling 'async DoSomething()' method with 'await Task.Run' for the second time."); // M
            await Task.Run((Action)DoSomething); // T2
            LogA("Call 'async DoSomething()' returned for the second time."); // M
        }

        private void DoSomething() { // T1 or T2
            int jobTimeMs = 1000;
            LogD($"Simulate long algorithm in DoSomething (sleep for {jobTimeMs} ms).");
            Thread.Sleep(jobTimeMs);
            LogD("Returning from DoSomething.");
        }
    }
}
