using Filtro_5_8_2024.Models;
using Gestor_Veterinaria.Models;

bool run = true;
var instanceVeterinary = new VeterinaryClinic();
int id = 0;

while (run)
{

    int IdToSend = (instanceVeterinary.Cats.Count()) + (instanceVeterinary.Dogs.Count()) + 1;       
    Console.Clear();
    ManagerApp.ShowHeader();
    Console.WriteLine("Welcome to the Animal Shelter!");
    ManagerApp.ShowSeparator();
    Console.WriteLine("Choose an option:");
    Console.WriteLine();
    Console.WriteLine("1. manage animals");
    Console.WriteLine("2. List animals");
    Console.WriteLine("3. Search an animal");
    Console.WriteLine("4. Exit");
    ManagerApp.ShowFooter();

    int choice;
    if (!int.TryParse(Console.ReadLine(), out choice))
    {
        Console.WriteLine();
        Console.WriteLine("Invalid input. Please enter a number.");
        ManagerApp.WaitForKey();
        continue;
    }

    switch (choice)
    {
        case 1:
            Console.Clear();
            ManagerApp.ShowHeader();
            Console.WriteLine("manage animal:");
            ManagerApp.ShowSeparator();
            Console.WriteLine("Choose an option:");
            Console.WriteLine();
            Console.WriteLine("1. Register a dog");
            Console.WriteLine("2. Register a cat");
            Console.WriteLine("3. Delete a dog");
            Console.WriteLine("4. Delete a cat");
            Console.WriteLine("5. Update a dog");
            Console.WriteLine("6. Update a cat");
            Console.WriteLine("7. Exit to main menu");
            ManagerApp.ShowFooter();

            int animalChoice;
            if (!int.TryParse(Console.ReadLine(), out animalChoice))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Please enter a number.");
                ManagerApp.WaitForKey();
                continue;
            }

            ManagerApp.ShowSeparator();

            switch (animalChoice)
            {
                case 1:
                    Dog newDog = ManagerApp.CreateDog(IdToSend);
                    instanceVeterinary.SaveDog(newDog);
                    break;

                case 2:
                    id ++;
                    Cat newCat = ManagerApp.CreateCat(IdToSend);
                    instanceVeterinary.SaveCat(newCat);
                    break;

                case 3:
                    Console.WriteLine("Enter the ID of the dog you want to delete:");
                    ManagerApp.ShowSeparator();
                    int dogId;
                    if (!int.TryParse(Console.ReadLine(), out dogId))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid input. Please enter a number.");
                        ManagerApp.WaitForKey();
                        break;
                    }

                    instanceVeterinary.DeleteDog(dogId);
                    break;

                case 4:
                    Console.WriteLine("Enter the ID of the cat you want to delete:");
                    int catId;
                    if (!int.TryParse(Console.ReadLine(), out catId))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid input. Please enter a number.");
                        ManagerApp.WaitForKey();
                        break;
                    }

                    ManagerApp.ShowSeparator();

                    instanceVeterinary.DeleteCat(catId);

                    break;
                case 5:
                    Console.WriteLine("Enter the ID of the dog you want to update:");
                    ManagerApp.ShowSeparator();
                    int dogUpdateId;
                    if (!int.TryParse(Console.ReadLine(), out dogUpdateId))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid input. Please enter a number.");
                        ManagerApp.WaitForKey();
                        break;
                    }

                    ManagerApp.ShowSeparator();
                    
                    Dog? dogToUpdate = instanceVeterinary.Dogs.Find(d => d.GetId() == dogUpdateId);
                    if (dogToUpdate == null)
                    {
                        Console.WriteLine("Error: Dog not found.");
                        ManagerApp.WaitForKey();
                        break;
                    }

                    instanceVeterinary.UpdateDog(dogToUpdate);
                    break;

                case 6:
                    Console.WriteLine("Enter the ID of the cat you want to update:");
                    ManagerApp.ShowSeparator();
                    int catUpdateId;
                    if (!int.TryParse(Console.ReadLine(), out catUpdateId))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid input. Please enter a number.");
                        ManagerApp.WaitForKey();
                        break;
                    }

                    ManagerApp.ShowSeparator();

                    Cat? catToUpdate = instanceVeterinary.Cats.Find(c => c.GetId() == catUpdateId);
                    if (catToUpdate == null)
                    {
                        Console.WriteLine("Error: Cat not found.");
                        ManagerApp.WaitForKey();
                        break;
                    }

                    instanceVeterinary.UpdateCat(catToUpdate);
                    break;

                case 7:

                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose a number between 1 and 2.");
                    break;
            }
            break;

        case 2:

            Console.Clear();
            ManagerApp.ShowHeader();
            Console.WriteLine("list animal:");
            ManagerApp.ShowSeparator();
            Console.WriteLine("Choose an option:");
            Console.WriteLine();
            Console.WriteLine("1. List animal");
            Console.WriteLine("2. List all pets");
            Console.WriteLine("3. Exit to main menu");
            
            ManagerApp.ShowFooter();

            int listChoice;
            if (!int.TryParse(Console.ReadLine(), out listChoice))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Please enter a number.");
                ManagerApp.WaitForKey();
                continue;
            }

            ManagerApp.ShowSeparator();

            switch (listChoice)
            {
                case 1:
                    Console.WriteLine("Please enter the type of the animal");
                    string? type = Console.ReadLine()?.ToLower();
                    if(string.IsNullOrEmpty(type))
                    {
                        Console.WriteLine("Error: Type cannot be empty.");
                        ManagerApp.WaitForKey();
                        break;
                    }

                    ManagerApp.ShowSeparator();

                    instanceVeterinary.ShowAnimals(type);
                    break;
                case 2:
                    Console.WriteLine("All pets:");
                    instanceVeterinary.ShowAllPatients();
                    break;
            }
            break;
        case 3:
            Console.Clear();
            ManagerApp.ShowHeader();
            Console.WriteLine("search an animal:");
            ManagerApp.ShowSeparator();
            Console.WriteLine("Enter the ID of the animal you want to search:");
            ManagerApp.ShowFooter();
            int searchId;
            if (!int.TryParse(Console.ReadLine(), out searchId))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Please enter a number.");
                ManagerApp.WaitForKey();
                break;
            }

            ManagerApp.ShowSeparator();

            instanceVeterinary.ShowPatient(searchId);
            break;
        case 4:
            run = false;
            break;
        default:
            Console.WriteLine("Invalid option. Please choose a number between 1 and 4.");
            break;
    }
}