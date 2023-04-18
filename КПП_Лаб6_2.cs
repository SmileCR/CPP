using System;
using System.Windows.Forms;

namespace MultiplyBy6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // зчитуємо значення А1 та А2 з елементів NumericUpDown
            int a1 = (int)numUpDownA1.Value;
            int a2 = (int)numUpDownA2.Value;

            // ініціалізуємо лічильник кількості чисел, кратних 6
            int count = 0;

            // ініціалізуємо змінну для збереження добутку
            int product = 1;

            // проходимо по діапазону від А1 до А2 і шукаємо числа, кратні 6
            for (int i = a1; i <= a2; i++)
            {
                if (i % 6 == 0)
                {
                    // якщо число кратне 6, збільшуємо лічильник та множимо на нього добуток
                    count++;
                    product *= i;

                    // якщо знайшли перші три числа, кратні 6, можемо виходити з циклу
                    if (count == 3)
                    {
                        break;
                    }
                }
            }

            // виводимо результат у текстове поле
            txtBoxResult.Text = product.ToString();
        }
    }
}
