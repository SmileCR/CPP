using System;
using System.Windows.Forms;

namespace ArrayMinMaxProduct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double[] array = new double[8];
            double min = double.MaxValue;
            double max = double.MinValue;

            // Зчитуємо елементи масиву з DataGridView
            for (int i = 0; i < dgvArray.Rows.Count; i++)
            {
                if (double.TryParse(dgvArray.Rows[i].Cells[0].Value.ToString(), out double value))
                {
                    array[i] = value;

                    // Знаходимо найменший і найбільший елементи масиву
                    if (value < min)
                    {
                        min = value;
                    }
                    if (value > max)
                    {
                        max = value;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input at row " + (i + 1));
                    return;
                }
            }

            // Обчислюємо добуток найменшого і найбільшого елементів масиву
            double product = min * max;

            // Виводимо результат у текстове поле
            textBoxResult.Text = product.ToString();
        }
    }
}
