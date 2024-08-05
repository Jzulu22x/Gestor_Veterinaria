using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro_5_8_2024.Models;

namespace Gestor_Veterinaria.Models;
public class ManagerApp
{
    

    public static Dog CreateDog(int id)
    {
        var InstanceVeterinary = new VeterinaryClinic();

        Console.WriteLine("Please enter your dog name: ");
        string? name = Console.ReadLine();
        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Error: Name cannot be empty.");
            WaitForKey();
            return CreateDog(id);
        }

        Console.WriteLine("Please enter your dog birthdate (YYYY-MM-DD): ");
        DateOnly BirthDate;
        if (!DateOnly.TryParse(Console.ReadLine(), out BirthDate))
        {
            Console.WriteLine("Error: Invalid birthdate format.");
            WaitForKey();
            return CreateDog(id);
        }

        Console.WriteLine("Please enter your dog breed: ");
        string? breed = Console.ReadLine();
        if (string.IsNullOrEmpty(breed))
        {
            Console.WriteLine("Error: Breed cannot be empty.");
            WaitForKey();
            return CreateDog(id);
        }

        Console.WriteLine("Please enter your dog color: ");
        string? color = Console.ReadLine();
        if (string.IsNullOrEmpty(color))
        {
            Console.WriteLine("Error: Color cannot be empty.");
            WaitForKey();
            return CreateDog(id);
        }

        Console.WriteLine("Please enter your dog weight (kg): ");
        double weightInKg;
        if (!double.TryParse(Console.ReadLine(), out weightInKg))
        {
            Console.WriteLine("Error: Invalid weight format.");
            WaitForKey();
            return CreateDog(id);
        }

        Console.WriteLine("Is your dog in a breeding mate? (yes/no)");
        string? breedingStatud = Console.ReadLine();
        bool breedingStatus = breedingStatud?.ToLower() == "yes";
        if (breedingStatus == false && breedingStatus == true)
        {
            Console.WriteLine("Error: Invalid answer.");
            WaitForKey();
            return CreateDog(id);
        }

        Console.WriteLine("Please enter your dog's temperament: ");
        string? temperament = Console.ReadLine();
        if (string.IsNullOrEmpty(temperament))
        {
            Console.WriteLine("Error: Temperament cannot be empty.");
            WaitForKey();
            return CreateDog(id);
        }

        Console.WriteLine("Please enter your dog's microchip number: ");
        string? microchipNumber = Console.ReadLine();
        if (string.IsNullOrEmpty(microchipNumber))
        {
            Console.WriteLine("Error: Microchip number cannot be empty.");
            WaitForKey();
            return CreateDog(id);
        }

        Console.WriteLine("Please enter your dog's bark volume: ");
        string? barkVolume = Console.ReadLine();
        if (string.IsNullOrEmpty(barkVolume))
        {
            Console.WriteLine("Error: Bark volume cannot be empty.");
            WaitForKey();
            return CreateDog(id);
        }

        Console.WriteLine("Please enter your dog's coat type: ");
        string? coatType = Console.ReadLine();
        if (string.IsNullOrEmpty(coatType))
        {
            Console.WriteLine("Error: Coat type cannot be empty.");
            WaitForKey();
            return CreateDog(id);
        }
        
        return new Dog(id, name, BirthDate, breed, color, weightInKg, breedingStatus, temperament, microchipNumber, barkVolume, coatType);
    }
    
    public static Cat CreateCat(int id)
    {

        Console.WriteLine("Please enter your cat name: ");
        string? name = Console.ReadLine();
        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Error: Name cannot be empty.");
            WaitForKey();
            return CreateCat(id);
        }

        Console.WriteLine("Please enter your cat birthdate (YYYY-MM-DD): ");
        DateOnly BirthDate;
        if (!DateOnly.TryParse(Console.ReadLine(), out BirthDate))
        {
            Console.WriteLine("Error: Invalid birthdate format.");
            WaitForKey();
            return CreateCat(id);
        }

        Console.WriteLine("Please enter your cat breed: ");
        string? breed = Console.ReadLine();
        if (string.IsNullOrEmpty(breed))
        {
            Console.WriteLine("Error: Breed cannot be empty.");
            WaitForKey();
            return CreateCat(id);
        }

        Console.WriteLine("Please enter your cat color: ");
        string? color = Console.ReadLine();
        if (string.IsNullOrEmpty(color))
        {
            Console.WriteLine("Error: Color cannot be empty.");
            WaitForKey();
            return CreateCat(id);
        }

        Console.WriteLine("Please enter your cat weight (kg): ");
        double weightInKg;
        if(!double.TryParse(Console.ReadLine(), out weightInKg))
        {
            Console.WriteLine("Error: Invalid weight format.");
            WaitForKey();
            return CreateCat(id);
        }

        Console.WriteLine("Is your cat in a breeding mate? (yes/no)");
        string? breedingStatud = Console.ReadLine();
        bool breedingStatus = breedingStatud?.ToLower() == "yes";
        if (breedingStatus == false && breedingStatus == true)
        {
            Console.WriteLine("Error: Invalid answer.");
            WaitForKey();
            return CreateCat(id);
        }

        Console.WriteLine("Please enter your cat's fur lenght: ");
        string? furLenght = Console.ReadLine();
        if (string.IsNullOrEmpty(furLenght))
        {
            Console.WriteLine("Error: Fur lenght cannot be empty.");
            WaitForKey();
            return CreateCat(id);
        }

        var InstanceVeterinary = new VeterinaryClinic();
        return new Cat ( id, name, BirthDate, breed, color, weightInKg, breedingStatus, furLenght);
    }

    public static void ShowHeader()
    {
        Console.WriteLine();
        Console.WriteLine(new string('#', 40));
        Console.WriteLine();
    }

    public static void ShowFooter()
    {
        Console.WriteLine();
        Console.WriteLine(new string('=', 40));
        Console.WriteLine();
    }

    public static void ShowSeparator()
    {
        Console.WriteLine();
        Console.WriteLine(new string('-', 40));
        Console.WriteLine();
    }

    public static void WaitForKey()
    {
        Console.WriteLine("");
        Console.WriteLine("press any key to continue...");
        Console.ReadKey();
        Console.WriteLine("");
    }
}
