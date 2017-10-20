using AsyncAwaitTest.SimpleLogWriters;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsyncAwaitTest.Logger;

namespace AsyncAwaitTest
{
    public partial class AsyncAwaitTest : Form
    {
        #region IrrelevantForAsyncAwait
        private ThreadLogger logWriter;

        public AsyncAwaitTest()
        {
            InitializeComponent();
        }

        private void AsyncAwaitTest_Load(object sender, EventArgs e)
        {
            logWriter = new ThreadLogger(new TextBoxLogWriter(textBoxDebug));

            var curContext = SynchronizationContext.Current;
        }

        private void buttonUnproperCase_Click(object sender, EventArgs e)
        {
            try
            {
                logWriter.Log("Insede the button handler.");
                Task.Run(() =>
                {
                    try
                    {
                        logWriter.Log("Trying to change prefix in non-UI thread.");
                        var button = (Button)sender;
                        button.Text = "Not so " + button.Text;
                        logWriter.Log("Prefix successfully changed.");
                    }
                    catch (Exception ex)
                    {
                        logWriter.Log($"It's still bad idea to change controls outside of the UI thread. Exception:\r\n{ex.Message}");
                    }
                });
            }
            catch (Exception ex)
            {
                logWriter.Log($"Ooops, something went wrong with threading.\r\nException: {ex.Message}");
            }
        }
        #endregion IrrelevantForAsyncAwait

        private void buttonProperCase_Click(object sender, EventArgs e)
        {
            logWriter.LogMethodNumber = 1;
            var test = new AATest(logWriter);
            test.UseInnerLogMethodNames = true;
            test.Execute();
        }
    }
}
