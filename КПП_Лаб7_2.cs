using System;
using System.Windows.Forms;

namespace SortingArray
{
    public partial class Form1 : Form
    {
        // ініціалізуємо масив
        int[] grades = new int[] { 9, 7, 12, 5, 6, 10, 8, 11, 4, 7, 9, 12 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // виводимо несортований масив у DataGridView1
            for (int i = 0; i < grades.Length; i++)
            {
                dataGridView1.Rows.Add(grades[i]);
            }

            // сортуємо масив за спаданням
            Array.Sort(grades);
            Array.Reverse(grades);

            // виводимо відсортований масив у DataGridView2
            for (int i = 0; i < grades.Length; i++)
            {
                dataGridView2.Rows.Add(grades[i]);
            }
        }
    }
}
