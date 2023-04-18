using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введіть довжину сторони квадрата: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введіть довжину прямокутника: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введіть ширину прямокутника: ");
        double b = double.Parse(Console.ReadLine());

        double squareArea = x * x;  // обчислюємо площу квадрата
        double squarePerimeter = 4 * x;  // обчислюємо периметр квадрата

        double rectangleArea = a * b;  // обчислюємо площу прямокутника
        double rectanglePerimeter = 2 * (a + b);  // обчислюємо периметр прямокутника

        Console.WriteLine("\nПлоща квадрата: {0}", squareArea);
        Console.WriteLine("Периметр квадрата: {0}", squarePerimeter);
        Console.WriteLine("Площа прямокутника: {0}", rectangleArea);
        Console.WriteLine("Периметр прямокутника: {0}", rectanglePerimeter);

        if (squareArea > rectangleArea) {
            Console.WriteLine("\nПлоща квадрата більша за площу прямокутника.");
        }
        else if (squareArea < rectangleArea) {
            Console.WriteLine("\nПлоща прямокутника більша за площу квадрата.");
        }
        else {
            Console.WriteLine("\nПлощі квадрата і прямокутника рівні.");
        }

        if (squarePerimeter > rectanglePerimeter) {
            Console.WriteLine("Периметр квадрата більший за периметр прямокутника.");
        }
        else if (squarePerimeter < rectanglePerimeter) {
            Console.WriteLine("Периметр прямокутника більший за периметр квадрата.");
        }
        else {
            Console.WriteLine("Периметри квадрата і прямокутника рівні.");
        }

        Console.ReadLine();
    }
}
