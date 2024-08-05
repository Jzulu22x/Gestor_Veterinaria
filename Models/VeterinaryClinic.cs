using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filtro_5_8_2024.Models;
public class VeterinaryClinic
{
    public string? Name { get; set; }
    public  string? Address { get; set; }
    public List<Dog> Dogs = [];
    public List<Cat> Cats = [];

    public VeterinaryClinic() { }

    public VeterinaryClinic(string name, string address)
    {
        Name = name;
        Address = address;
    }

    public void SaveDog(Dog newdog)
    {
        Dogs.Add(newdog);
        Console.WriteLine($"Dog {newdog.GetName()} saved successfully.");
    }

    public void SaveCat(Cat newcat)
    {
        Cats.Add(newcat);
        Console.WriteLine($"Cat {newcat.GetName()} saved successfully.");
    }

    public void UpdateDog(int Id,Dog dog)
    {
        Dogs[Dogs.FindIndex(d => d.GetId() == Id)] = dog;
        Console.WriteLine($"Dog {dog.GetName()} updated successfully.");
    }

    public void UpdateCat(int Id, Cat cat)
    {
        Cats[Cats.FindIndex(c => c.GetId() == Id)] = cat;
        Console.WriteLine($"Cat {cat.GetName()} updated successfully.");
    }

    public void DeleteDog(int Id)
    {
        Dogs.RemoveAt(Dogs.FindIndex(d => d.GetId() == Id));
        Console.WriteLine($"Dog with ID {Id} deleted successfully.");
    }

    public void DeleteCat(int Id)
    {
        Cats.RemoveAt(Cats.FindIndex(c => c.GetId() == Id));
        Console.WriteLine($"Cat with ID {Id} deleted successfully.");
    }

    public void ShowAllPatients()
    {
        Console.WriteLine("Dogs:");
        foreach (var dog in Dogs)
        {
            dog.ShowInformation();
        }

        Console.WriteLine("Cats:");
        foreach (var cat in Cats)
        {
            cat.ShowInformation();
        }
    }

    public void ShowAnimals(string? Type)
    {
        if (Type == "dog")
        {
            Console.WriteLine("Dogs:");
            foreach (var dog in Dogs)
            {
                dog.ShowInformation();
            }
        }
        else if (Type == "cat")
        {
            Console.WriteLine("Cats:");
            foreach (var cat in Cats)
            {
                cat.ShowInformation();
            }
        }
        else
        {
            Console.WriteLine("Error: Unknown type");
        }
    }

    public void ShowPatient(int Id)
    {
        Dog? dog = Dogs.Find(d => d.GetId() == Id);
        Cat? cat = Cats.Find(c => c.GetId() == Id);

        if (dog!= null)
        {
            dog.ShowInformation();
        }
        else if (cat!= null)
        {
            cat.ShowInformation();
        }
        else
        {
            Console.WriteLine("Error: Patient not found");
        }
    }
}
