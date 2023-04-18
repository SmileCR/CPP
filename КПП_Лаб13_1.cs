using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StackExample
{
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
            // Заповнюємо стек випадковими символами
            var rand = new Random();
            var chars = Enumerable.Range('A', 26).Select(c => (char)c).ToList();
            stack = new Stack<char>();
            for (int i = 0; i < NumElements; i++)
            {
                var index = rand.Next(chars.Count);
                stack.Push(chars[index]);
                chars.RemoveAt(index);
            }

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
        }
    }
}
