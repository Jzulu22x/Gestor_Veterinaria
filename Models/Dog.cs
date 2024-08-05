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
        }
    }

    public void Hairdress()
    {
        Console.WriteLine($"The dog has {CoatType} hair.");
        Console.WriteLine($"The dog's bark volume is {BarkVolume}.");
    }
}
