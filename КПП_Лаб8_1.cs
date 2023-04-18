using System;
using System.Windows.Forms;

namespace TriangleExistenceCheck
{
    public partial class Form1 : Form
    {
        private double[,] sidesArray = new double[3, 6];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // заповнення початкового масиву довжин сторін трикутників
            sidesArray[0, 0] = 3; sidesArray[0, 1] = 4; sidesArray[0, 2] = 5; sidesArray[0, 3] = 6; sidesArray[0, 4] = 7; sidesArray[0, 5] = 8;
            sidesArray[1, 0] = 1; sidesArray[1, 1] = 2; sidesArray[1, 2] = 3; sidesArray[1, 3] = 4; sidesArray[1, 4] = 5; sidesArray[1, 5] = 6;
            sidesArray[2, 0] = 6; sidesArray[2, 1] = 6; sidesArray[2, 2] = 6; sidesArray[2, 3] = 6; sidesArray[2, 4] = 6; sidesArray[2, 5] = 6;

            // виведення даних у таблицю DataGridView1
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = sidesArray[i, j];
                }
            }
        }

        // функція для перевірки можливості існування трикутника за довжинами його сторін
        private bool IsTriangle(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // використання функції для перевірки можливості існування трикутника для кожного елемента масиву
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    double a = sidesArray[i, j];
                    double b = sidesArray[i + 1, j];
                    double c = sidesArray[i + 2, j];

                    bool isTriangle = IsTriangle(a, b, c);

                    // виведення результату перевірки в DataGridView2
                    if (isTriangle)
                    {
                        dataGridView2.Rows[i].Cells[j].Value = "Так";
                    }
                    else
                    {
                        dataGridView2.Rows[i].Cells[j].Value = "Ні";
                    }
                }
            }
        }
    }
}
