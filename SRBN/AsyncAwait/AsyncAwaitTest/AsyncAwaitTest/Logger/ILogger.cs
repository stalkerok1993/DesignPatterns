namespace AsyncAwaitTest.Logger {
    public interface ILogger {
        void Log(string message, string loggingFrom = null);
    }
}
