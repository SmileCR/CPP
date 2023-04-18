using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введіть кількість дисків, які ви бажаєте придбати: ");
        int discCount = int.Parse(Console.ReadLine());

        int box50Count = discCount / 50;  // кількість коробок по 50 дисків
        discCount %= 50;  // кількість дисків, які не входять до коробок по 50

        int box20Count = discCount / 20;  // кількість коробок по 20 дисків
        discCount %= 20;  // кількість дисків, які не входять до коробок по 20

        int box10Count = discCount / 10;  // кількість коробок по 10 дисків
        discCount %= 10;  // кількість дисків, які не входять до коробок по 10

        int individualDiscCount = discCount;  // кількість окремих дисків

        int totalCost = (box50Count * 150) + (box20Count * 70) + (box10Count * 40) + (individualDiscCount * 5);
        // обчислюємо мінімальну вартість покупки

        Console.WriteLine("\nКількість коробок по 50 дисків: {0}", box50Count);
        Console.WriteLine("Кількість коробок по 20 дисків: {0}", box20Count);
        Console.WriteLine("Кількість коробок по 10 дисків: {0}", box10Count);
        Console.WriteLine("Кількість окремих дисків: {0}", individualDiscCount);
        Console.WriteLine("Мінімальна вартість покупки: {0} грн.", totalCost);

        Console.ReadLine();
    }
}
