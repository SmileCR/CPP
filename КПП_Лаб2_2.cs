using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введіть довжину сторони правильного восьмикутника: ");
        double sideLength = double.Parse(Console.ReadLine());

        // Обчислюємо радіус описаного кола
        double circumscribedCircleRadius = sideLength * Math.Sqrt(2);

        // Обчислюємо площу описаного кола
        double circumscribedCircleArea = Math.PI * Math.Pow(circumscribedCircleRadius, 2);

        // Обчислюємо радіус вписаного кола
        double inscribedCircleRadius = sideLength / (2 * Math.Sqrt(2));

        // Обчислюємо площу вписаного кола
        double inscribedCircleArea = Math.PI * Math.Pow(inscribedCircleRadius, 2);

        // Обчислюємо площу правильного восьмикутника
        double octagonArea = 2 * (1 + Math.Sqrt(2)) * Math.Pow(sideLength, 2);

        // Обчислюємо суму площ описаного та вписаного кола
        double sumOfAreas = circumscribedCircleArea + inscribedCircleArea;

        Console.WriteLine("\nСума площ описаного та вписаного кола в правильний восьмикутник зі стороною {0}:", sideLength);
        Console.WriteLine("Площа описаного кола: {0}", circumscribedCircleArea);
        Console.WriteLine("Площа вписаного кола: {0}", inscribedCircleArea);
        Console.WriteLine("Сума площ: {0}", sumOfAreas);
        Console.WriteLine("Площа правильного восьмикутника: {0}", octagonArea);

        Console.ReadLine();
    }
}
