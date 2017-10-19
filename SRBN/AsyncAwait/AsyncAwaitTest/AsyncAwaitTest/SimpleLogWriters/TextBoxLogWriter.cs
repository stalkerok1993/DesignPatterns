using System;
using System.Windows.Forms;

namespace AsyncAwaitTest.SimpleLogWriters
{
    public class TextBoxLogWriter : ISimpleLogWriter
    {
        private delegate void AppendText(string text);
        private TextBox logTextBox;

        public TextBoxLogWriter(TextBox logTextBox) {
            this.logTextBox = logTextBox;
        }

        public void WriteLine(string log) {
            logTextBox.Invoke((AppendText)AppendTextBox, log + Environment.NewLine);
        }

        public void AppendTextBox(string text) {
            logTextBox.Text += text;
        }
    }
}
