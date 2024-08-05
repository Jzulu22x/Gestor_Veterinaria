using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filtro_5_8_2024.Models;
public class Dog : Animal
{
    public bool BreedingStatud { get; set; }
    public string? Temperament { get; set; }
    public string? MicrochipNumber { get; set; }
    public string? BarkVolume { get; set; }
    public string? CoatType { get; set; }

    public Dog(int id, string name, DateOnly birthdate, string breed, string color, double weightinkg, bool breedingstatud, string? temperament, string? microchipnumber,string barkVolume,string coattype) : base (id, name, birthdate, breed, color, weightinkg)
    {
       BreedingStatud = breedingstatud;
       Temperament = temperament;
       MicrochipNumber = microchipnumber;
       BarkVolume = barkVolume;
       CoatType = coattype;
    }

    public void CastrateAnimal ()
    {
        if (BreedingStatud == true)
        {
            Console.WriteLine("The dog has been castrated.");
        }
        else 
        {
            Console.WriteLine("The dog is not in a breeding mate.");
            BreedingStatud = true;
        }
    }

    public void Hairdress()
    {
        Console.WriteLine($"The dog has {CoatType} hair.");
        if (CoatType == "hairless" && CoatType == "short hair" )
        {
            Console.WriteLine("The dog is not suitable for hairdressing.");
        }
        else
        {
            Console.WriteLine("The dog is suitable for hairdressing.");
            CoatType = "short hair";
        }
    }

    public override void ShowInformation()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Birthdate: {BirthDate}");
        Console.WriteLine($"Age in months: {CalculateAgeInMonths()}");
        Console.WriteLine($"Breed: {Breed}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Weight (kg): {WeightInKg}");
        Console.WriteLine($"Breeding status: {BreedingStatud}");
        Console.WriteLine($"Temperament: {Temperament}");
        Console.WriteLine($"Microchip number: {MicrochipNumber}");
        Console.WriteLine($"Bark volume: {BarkVolume}");
        Console.WriteLine($"Coat type: {CoatType}");
        BasicReview();
    }
}
