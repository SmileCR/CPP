using System;
using System.Windows.Forms;

namespace NetworkSpeedCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void calculateMenuItem_Click(object sender, EventArgs e)
        {
            double fileSize, transferTime;
            bool validInputs = double.TryParse(fileSizeTextBox.Text, out fileSize) && double.TryParse(transferTimeTextBox.Text, out transferTime);

            if (validInputs)
            {
                double speed = fileSize / transferTime;
                resultTextBox.Text = speed.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid values for file size and transfer time.");
            }
        }
        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            string version = "1.0";
            string author = "John Smith";
            string message = $"Network Speed Calculator\nVersion {version}\n\nCreated by: {author}";
            MessageBox.Show(message);
        }
    }
}