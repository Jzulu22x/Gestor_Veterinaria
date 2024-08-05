using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gestor_Veterinaria.Models;

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
        ManagerApp.WaitForKey();
    }

    public void SaveCat(Cat newcat)
    {
        Cats.Add(newcat);
        Console.WriteLine($"Cat {newcat.GetName()} saved successfully.");
        ManagerApp.WaitForKey();

    }

    public void UpdateDog(int id)
    {
        var oldDog = Dogs.FirstOrDefault(d=> d.GetId() == id);
        Dogs.Remove(oldDog);
        var newDog = ManagerApp.CreateDog(id);
        Dogs.Add(newDog);
        Console.WriteLine();
        Console.WriteLine($"Dog {oldDog.GetName()} updated successfully.");
        ManagerApp.WaitForKey();
    }

    public void UpdateCat(int id)
    {
        var oldCat = Cats.FirstOrDefault(c=> c.GetId() == id);
        Cats.Remove(oldCat);
        var newCat = ManagerApp.CreateCat(id);
        Console.WriteLine();
        Console.WriteLine($"Cat {oldCat.GetName()} updated successfully.");
        ManagerApp.WaitForKey();
    }

    public void DeleteDog(int Id)
    {
        Dogs.RemoveAt(Dogs.FindIndex(d => d.GetId() == Id));
        Console.WriteLine($"Dog with ID {Id} deleted successfully.");
        ManagerApp.WaitForKey();
    }

    public void DeleteCat(int Id)
    {
        Cats.RemoveAt(Cats.FindIndex(c => c.GetId() == Id));
        Console.WriteLine($"Cat with ID {Id} deleted successfully.");
        ManagerApp.WaitForKey();
    }

    public void ShowAllPatients()
    {
        Console.WriteLine("Dogs:");
        Console.WriteLine("");
        foreach (var dog in Dogs)
        {
            ManagerApp.ShowSeparator();
            dog.ShowInformation();
            ManagerApp.ShowSeparator();
        }

        Console.WriteLine("Cats:");
        foreach (var cat in Cats)
        {
            ManagerApp.ShowSeparator();
            cat.ShowInformation();
            ManagerApp.ShowSeparator();
        }
        ManagerApp.WaitForKey();
    }

    public void ShowAnimals(string? Type)
    {
        if (Type == "dog")
        {
            Console.WriteLine("Dogs:");
            Console.WriteLine("");
            foreach (var dog in Dogs)
            {
                dog.ShowInformation();
            }
        }
        else if (Type == "cat")
        {
            Console.WriteLine("Cats:");
            Console.WriteLine("");
            foreach (var cat in Cats)
            {
                ManagerApp.ShowSeparator();
                cat.ShowInformation();
                ManagerApp.ShowSeparator();
            }
        }
        else
        {
            Console.WriteLine("Error: Unknown type");
        }
        ManagerApp.WaitForKey();
    }

    public void ShowPatient(int Id)
    {
        Dog? dog = Dogs.Find(d => d.GetId() == Id);
        Cat? cat = Cats.Find(c => c.GetId() == Id);

        if (dog!= null)
        {
            ManagerApp.ShowSeparator();
            dog.ShowInformation();
            ManagerApp.ShowSeparator();
        }
        else if (cat!= null)
        {
            ManagerApp.ShowSeparator();
            cat.ShowInformation();
            ManagerApp.ShowSeparator();
        }
        else
        {
            ManagerApp.ShowSeparator();
            Console.WriteLine("Error: Patient not found");
            ManagerApp.ShowSeparator();
        }
        ManagerApp.WaitForKey();

    }
}
