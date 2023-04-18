using System;

// Батьківський клас "Офіцер"
public class Officer
{
    public string Name { get; set; } // Ім'я офіцера
    public int Age { get; set; } // Вік офіцера
    public int YearsOfService { get; set; } // Роки служби офіцера
    public string Rank { get; set; } // Звання офіцера

    // Конструктор класу
    public Officer(string name, int age, int yearsOfService, string rank)
    {
        Name = name;
        Age = age;
        YearsOfService = yearsOfService;
        Rank = rank;
    }

    // Віртуальний метод "Працювати"
    public virtual void Work()
    {
        Console.WriteLine($"{Name} is working.");
    }

    // Віртуальний метод "Відпочивати"
    public virtual void Rest()
    {
        Console.WriteLine($"{Name} is resting.");
    }
}

// Клас "Капітан", похідний від класу "Офіцер"
public class Captain : Officer
{
    public string Ship { get; set; } // Назва корабля
    public int CrewSize { get; set; } // Кількість екіпажу

    // Конструктор класу
    public Captain(string name, int age, int yearsOfService, string rank, string ship, int crewSize)
        : base(name, age, yearsOfService, rank)
    {
        Ship = ship;
        CrewSize = crewSize;
    }

    // Перевизначений віртуальний метод "Працювати"
    public override void Work()
    {
        Console.WriteLine($"{Name} is commanding the ship {Ship} with a crew of {CrewSize}.");
    }

    // Перевизначений віртуальний метод "Відпочивати"
    public override void Rest()
    {
        Console.WriteLine($"{Name} is relaxing in their quarters on the ship {Ship}.");
    }
}

// Клас "Лейтенант", похідний від класу "Офіцер"
public class Leutenant : Officer
{
    public string Unit { get; set; } // Назва підрозділу

    // Конструктор класу
    public Leutenant(string name, int age, int yearsOfService, string rank, string unit)
        : base(name, age, yearsOfService, rank)
    {
        Unit = unit;
    }

    // Перевизначений віртуальний метод "Працювати"
    public override void Work()
    {
        Console.WriteLine($"{Name} is leading their unit {Unit} on a mission.");
    }

    // Перевизначений віртуальний метод "Відпочивати"
    public override void Rest()
    {
        Console.WriteLine($"{Name} is taking a break from the mission with their unit {Unit}.");
    }
}
