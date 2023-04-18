using System;
using System.Collections.Generic;

// Клас "Полк"
public class Regiment
{
    public List<Captain> Captains { get; set; } // Список капітанів
    public List<Leutenant> Leutenants { get; set; } // Список лейтенантів

    // Конструктор класу
    public Regiment()
    {
        Captains = new List<Captain>();
        Leutenants = new List<Leutenant>();
    }

    // Метод для додавання капітана до списку
    public void AddCaptain(Captain captain)
    {
        Captains.Add(captain);
    }

    // Метод для додавання лейтенанта до списку
    public void AddLeutenant(Leutenant leutenant)
    {
        Leutenants.Add(leutenant);
    }

    // Метод для видалення капітана зі списку
    public void RemoveCaptain(Captain captain)
    {
        Captains.Remove(captain);
    }

    // Метод для видалення лейтенанта зі списку
    public void RemoveLeutenant(Leutenant leutenant)
    {
        Leutenants.Remove(leutenant);
    }

    // Метод для отримання списку капітанів
    public List<Captain> GetCaptains()
    {
        return Captains;
    }

    // Метод для отримання списку лейтенантів
    public List<Leutenant> GetLeutenants()
    {
        return Leutenants;
    }
}
