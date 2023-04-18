using System;

class Passport
{
    // Властивості для зберігання даних про паспорт
    public string Name { get; set; }
    public string Surname { get; set; }
    public string PassportNumber { get; set; }
    public DateTime DateOfIssue { get; set; }
    public DateTime ExpirationDate { get; set; }

    // Конструктор, який ініціалізує дані про паспорт
    public Passport(string name, string surname, string passportNumber, DateTime dateOfIssue, DateTime expirationDate)
    {
        Name = name;
        Surname = surname;
        PassportNumber = passportNumber;
        DateOfIssue = dateOfIssue;
        ExpirationDate = expirationDate;
    }

    // Метод для обробки паспорту
    public void Process()
    {
        Console.WriteLine("Processing passport of {0} {1}", Name, Surname);
        // виконання дій з обробки паспорту
    }
}
