using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StackExample
{
    public static class ABC
    {
        public static void ReadFromFile(string filePath, Stack<char> stack)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"File not found: {filePath}");
            }

            var text = File.ReadAllText(filePath).ToUpper();
            foreach (var ch in text)
            {
                if (char.IsLetter(ch))
                {
                    stack.Push(ch);
                }
            }
        }

        public static void SaveToFile(string filePath, string text)
        {
            File.WriteAllText(filePath, text);
        }
    }

    public partial class MainForm : Form
    {
        private const int NumElements = 8;
        private Stack<char> stack;

        public MainForm()
        {
            InitializeComponent();
            dataGridView.Columns.Add("Char", "Char");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Заповнюємо стек символами з файлу
                stack = new Stack<char>();
                ABC.ReadFromFile("input.txt", stack);

                // Виводимо вміст стеку в DataGridView
                dataGridView.Rows.Clear();
                foreach (var ch in stack)
                {
                    dataGridView.Rows.Add(ch);
                }

                // Виводимо перші 10 символів англійського алфавіту в багаторядкове текстове поле
                var alphabet = Enumerable.Range('A', 26).Select(c => (char)c).Take(10).ToList();
                var text = new string(stack.Where(ch => alphabet.Contains(ch)).ToArray());
                textBox.Text = text;

                // Зберігаємо результати роботи програми у файл
                ABC.SaveToFile("output.txt", text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
