using System;

class Program {
    static void Main(string[] args) {
        int[] numbers = new int[16];

        // Заповнюємо масив числами, введеними користувачем
        for (int i = 0; i < 16; i++) {
            Console.Write("Введіть ціле число: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nПеревірка подільності на 16 з використанням побітових операцій:");

        // Перевіряємо кожне число на подільність на 16
        for (int i = 0; i < 16; i++) {
            if ((numbers[i] & 15) == 0) {
                Console.WriteLine(numbers[i] + " є подільним на 16");
            } else {
                Console.WriteLine(numbers[i] + " не є подільним на 16");
            }
        }

        Console.ReadLine();
    }
}