using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filtro_5_8_2024.Models;
public abstract class Animal
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

    public abstract void ShowInformation();
    
    protected int CalculateAgeInMonths()
    {
        int monthsActually = (DateTime.Now.Year * 12) + DateTime.Now.Month;
        int monthsAnimal = (BirthDate.Year * 12) + BirthDate.Month;
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
