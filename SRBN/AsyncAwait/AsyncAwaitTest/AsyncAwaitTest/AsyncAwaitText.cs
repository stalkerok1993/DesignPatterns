using AsyncAwaitTest.SimpleLogWriters;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwaitTest
{
    public partial class AsyncAwaitTest : Form
    {
        #region IrrelevantForAsyncAwait
        private ISimpleLogWriter logWriter;

        public AsyncAwaitTest()
        {
            InitializeComponent();
        }

        private void AsyncAwaitTest_Load(object sender, EventArgs e)
        {
            logWriter = new TextBoxLogWriter(textBoxDebug);

            var curContext = SynchronizationContext.Current;
        }

        private void buttonUnproperCase_Click(object sender, EventArgs e)
        {
            try
            {
                logWriter.WriteLine($"({Thread.CurrentThread.ManagedThreadId}) Insede the button handler.");
                Task.Run(() =>
                {
                    try
                    {
                        logWriter.WriteLine($"({Thread.CurrentThread.ManagedThreadId}) Trying to change prefix in non-UI thread.");
                        var button = (Button)sender;
                        button.Text = "Not so " + button.Text;
                        logWriter.WriteLine($"({Thread.CurrentThread.ManagedThreadId}) Prefix successfully changed.");
                    }
                    catch (Exception ex)
                    {
                        logWriter.WriteLine($"({Thread.CurrentThread.ManagedThreadId}) It's still bad idea to change controls outside of the UI thread. Exception:\r\n{ex.Message}");
                    }
                });
            }
            catch (Exception ex)
            {
                logWriter.WriteLine($"({Thread.CurrentThread.ManagedThreadId}) Ooops, something went wrong with threading.\r\nException: {ex.Message}");
            }
        }
        #endregion IrrelevantForAsyncAwait

        private void buttonProperCase_Click(object sender, EventArgs e)
        {
            var test = new AATest(logWriter);
            test.Execute();
        }
    }
}
