using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введіть текст: ");
        string text = Console.ReadLine();
        
        int rows = text.Length;
        int cols = 0;
        for (int i = 1; i <= rows; i++) {
            cols += i;
        }
        
        char[,] matrix = new char[rows, cols];
        int k = 0;
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < i + 1; j++) {
                if (k < text.Length) {
                    matrix[i, j] = text[k];
                    k++;
                }
            }
        }
        
        for (int i = 0; i < rows; i++) {
            bool lastRow = (i == rows - 1);
            for (int j = 0; j < i + 1; j++) {
                Console.Write(matrix[i, j]);
                if (!lastRow || j != i) {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
