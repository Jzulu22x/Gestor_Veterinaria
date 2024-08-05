using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filtro_5_8_2024.Models;
public class Cat : Animal
{
    public bool BreedingStatud { get; set; }
    public string? FurLenght { get; set; }

    public Cat(int id, string name, DateOnly birthdate, string breed, string color, double weightinkg, bool breedingstatud, string? furlenght) : base(id, name, birthdate, breed, color, weightinkg)
    {
        BreedingStatud = breedingstatud;
        FurLenght = furlenght;
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
        Console.WriteLine($"The cat has {FurLenght} fur.");
    }
}
