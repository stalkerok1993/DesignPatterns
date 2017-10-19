using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using AsyncAwaitTest.SimpleLogWriters;

namespace AsyncAwaitTest.Logger {
    public class ThreadLogger : ILogger {
        public int LogMethodDepth { get; set; } = 1;
        public int LogMethodNumber { get; set; } = 2;

        private ISimpleLogWriter logWriter;

        public ThreadLogger(ISimpleLogWriter logWriter) {
            this.logWriter = logWriter;
        }

        public void Log(string message, string loggingFrom = null) {
            if (loggingFrom == null) {
                StackTrace st = new StackTrace();

                int logMethods = Math.Min(LogMethodNumber, st.FrameCount);
                loggingFrom = "";
                for (int i = 0; i < logMethods; i++) {
                    MethodBase method = st.GetFrame(i + LogMethodDepth).GetMethod();

                    if (i > 0) {
                        loggingFrom = "," + loggingFrom;
                    }
                    loggingFrom = $"{Environment.NewLine}{method.Name,25:S}" + loggingFrom;
                }
            } else {
                loggingFrom = $"{Environment.NewLine}{loggingFrom,25:S}";
            }

            int currentThreadId = Thread.CurrentThread.ManagedThreadId;
            logWriter.WriteLine($"                      [{Thread.CurrentThread.ManagedThreadId,2:D}] " + loggingFrom + ": " + message);
        }
    }
}
