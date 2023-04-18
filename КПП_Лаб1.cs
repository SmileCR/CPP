using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            Console.Write("Введіть перше двоцифрове число: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Введіть друге двоцифрове число: ");
            secondNumber = int.Parse(Console.ReadLine());

            int firstDigitFirstNumber = firstNumber / 10;
            int secondDigitFirstNumber = firstNumber % 10;
            int firstDigitSecondNumber = secondNumber / 10;
            int secondDigitSecondNumber = secondNumber % 10;

            int firstFourDigitNumber = (firstDigitFirstNumber * 1000) + (firstDigitSecondNumber * 100) + (secondDigitFirstNumber * 10) + secondDigitSecondNumber;
            int secondFourDigitNumber = (firstDigitSecondNumber * 1000) + (secondDigitSecondNumber * 100) + (firstDigitFirstNumber * 10) + secondDigitFirstNumber;

            Console.WriteLine("Перше чотирицифрове число: " + firstFourDigitNumber);
            Console.WriteLine("Друге чотирицифрове число: " + secondFourDigitNumber);

            Console.ReadKey();
        }
    }
}
