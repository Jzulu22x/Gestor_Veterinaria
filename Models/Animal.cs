using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filtro_5_8_2024.Models;
public class Animal
{
    protected int Id { get; set; }
    protected string? Name { get; set; }
    protected DateOnly BirthDate { get; set; }
    protected string? Breed { get; set; }
    protected string? Color { get; set; }
    protected double WeightInKg { get; set; }

    public Animal(int id, string name, DateOnly birthdate, string breed, string color, double weightinkg)
    {
        Id = id;
        Name = name;
        BirthDate = birthdate;
        Breed = breed;
        Color = color;
        WeightInKg = weightinkg;
    }

    public void ShowInformation()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Birthdate: {BirthDate}");
        Console.WriteLine($"Age in months: {CalculateAgeInMonths()}");
        Console.WriteLine($"Breed: {Breed}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Weight (kg): {WeightInKg}");
        Console.WriteLine("---------------------------");
    }
    
    protected int CalculateAgeInMonths()
    {
        int monthsActually = DateTime.Now.Year * 12;
        int monthsAnimal = BirthDate.Year * 12;
        return monthsActually - monthsAnimal;
    }

    protected void BasicReview()
    {
        if (CalculateAgeInMonths() < 5)
        {
            Console.WriteLine("This animal is a puppy.");
        }
        else if (CalculateAgeInMonths() >= 5 && CalculateAgeInMonths() <= 8)
        {
            Console.WriteLine("This animal is a kitten.");
        }
        else
        {
            Console.WriteLine("This animal is an adult.");
        }

        Console.WriteLine("---------------------------");

    }

    public string? GetName()
    {
        return Name;
    }

    public int GetId()
    {
        return Id;
    }
}
