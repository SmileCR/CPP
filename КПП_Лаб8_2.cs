using System;
using System.Windows.Forms;

namespace DiagonalSum
{
    public partial class Form1 : Form
    {
        private int[,] randomArray = new int[4, 4];
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillArray();
            DisplayArray();
        }

        // функція для створення масиву і заповнення його випадковими числами
        private void FillArray()
        {
            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    randomArray[i, j] = rand.Next(10);
                }
            }
        }

        // функція для відображення масиву в DataGridView
        private void DisplayArray()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = randomArray[i, j];
                }
            }
        }

        // функція для обчислення суми елементів масиву, які лежать на діагоналі таблиці
        private int GetDiagonalSum()
        {
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                sum += randomArray[i, i];
            }
            return sum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int diagonalSum = GetDiagonalSum();
            label1.Text = "Сума елементів на діагоналі: " + diagonalSum;
        }
    }
}
