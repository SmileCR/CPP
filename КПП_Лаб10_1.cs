using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введіть текст: ");
        string text = Console.ReadLine();
        
        int count = 0;
        foreach (char c in text) {
            if (c == '.' || c == '?' || c == '!') {
                count++;
            }
        }
        
        Console.WriteLine("Кількість речень: " + count);
    }
}
