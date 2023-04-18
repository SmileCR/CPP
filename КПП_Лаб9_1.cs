using System;
using System.Windows.Forms;

namespace TrigonometryCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void sinMenuItem_Click(object sender, EventArgs e)
        {
            double angle = 0;
            if (double.TryParse(angleTextBox.Text, out angle))
            {
                double sine = Math.Sin(Math.PI * angle / 180);
                resultTextBox.Text = sine.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid angle in degrees.");
            }
        }

        private void cosMenuItem_Click(object sender, EventArgs e)
        {
            double angle = 0;
            if (double.TryParse(angleTextBox.Text, out angle))
            {
                double cosine = Math.Cos(Math.PI * angle / 180);
                resultTextBox.Text = cosine.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid angle in degrees.");
            }
        }

        private void tanMenuItem_Click(object sender, EventArgs e)
        {
            double angle = 0;
            if (double.TryParse(angleTextBox.Text, out angle))
            {
                double tangent = Math.Tan(Math.PI * angle / 180);
                resultTextBox.Text = tangent.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid angle in degrees.");
            }
        }

        private void clearMenuItem_Click(object sender, EventArgs e)
        {
            angleTextBox.Clear();
            resultTextBox.Clear();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
