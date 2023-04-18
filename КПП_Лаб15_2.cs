using System;
using System.Collections.Generic;
using System.IO;

namespace MyApp
{
    public partial class MainForm : Form
    {
        Queue<int> queue = new Queue<int>(); // очередь для хранения целых чисел

        public MainForm()
        {
            InitializeComponent();
        }

        // Створення черги з 7 цілих чисел і заповнення її випадковими числами
        private void createQueueButton_Click(object sender, EventArgs e)
        {
            queue = new Queue<int>(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            MessageBox.Show("Queue created successfully!");
        }

        // Додавання елемента в чергу
        private void addButton_Click(object sender, EventArgs e)
        {
            int number = int.Parse(numberTextBox.Text); // отримання числа з текстового поля
            queue.Enqueue(number); // додавання числа в чергу
            MessageBox.Show("Number added successfully!");
        }

        // Видалення елемента з черги
        private void removeButton_Click(object sender, EventArgs e)
        {
            int number = queue.Dequeue(); // видалення числа з черги
            MessageBox.Show(string.Format("Number {0} removed successfully!", number));
        }

        // Збереження черги в одному рядку в текстовому файлі
        private void saveButton_Click(object sender, EventArgs e)
        {
            string queueString = string.Join(",", queue.ToArray()); // перетворення черги в рядок у форматі "1,2,3,4,5,6,7"
            File.WriteAllText("queue.txt", queueString); // запис рядка у текстовий файл
            MessageBox.Show("Queue saved successfully!");
        }
    }
}
