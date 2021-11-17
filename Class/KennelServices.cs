using Inlämning1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Class
{
    class KennelServices : IKennelServices
    {
        // Should be an Api but i´m Lazy and i just Assume The list´s are accurate.

        List<IDog> Dogs = new List<IDog>();
        List<ICustomer> Customers = new List<ICustomer>();

        public decimal Cost { get;set; }


        // Runs the options for KennelServices
        public void ViewKennelServices()
        {
            bool Active = true;
            while (Active)
            {
                Console.WriteLine("Type 1 For Washing");
                Console.WriteLine("Type 2 For CuttingClaws ");
                Console.WriteLine("Type Exit To Exit To Main Menu");
                Console.WriteLine("Type 3 For Addin Dummy Customer and Dog´s ");
                Console.WriteLine(" ");
                var Option = Console.ReadLine();
                switch (Option)
                {
                    case "1":
                        Washing();
                        break;
                    case "2":
                        CuttingClaws();
                        break;
                    case "Exit":
                        Active = false;
                        break;
                    case "3":
                        AddDummyCustomersAndDogs();
                        break;
                    default:
                        Console.WriteLine($"{Option} is an Invalid Option");
                        break;
                }

            }
            
        }
        // does the cutting claw register and cost calculation
        public void CuttingClaws()
        {
            Console.WriteLine("Please Write the name of the Animal you want Getting the CuttingClaw Service");
            var AnimalName = Console.ReadLine();
            var dog = SearchForAnimalUsingName(AnimalName);

            if (dog != null)
            {
                Cost = 25;
                Console.WriteLine($"the Service will cost {Cost} for getting {AnimalName} Claws Cut");
            }
            else
            {
                Console.WriteLine($"Found no dog with the name: {AnimalName}");
            }

        }
        // does the Washing register and cost calculation
        public void Washing()
        {
            Console.WriteLine("Please Write the name of the Animal you want Getting Washing the Service");
            var AnimalName = Console.ReadLine();
            var dog = SearchForAnimalUsingName(AnimalName);

            if (dog != null)
            {
                Cost = 15;
                Console.WriteLine($"the Service will cost {Cost} for getting {AnimalName} Washed");
            }
            else
            {
                Console.WriteLine($"Found no dog with the name: {AnimalName}");
            }

        }
        // Add´s 2 dummy Customer and 3 Dog´s
        public void AddDummyCustomersAndDogs()
        {
            // Adding Dummy Customers
            Customers.Add(new Customer { Id = Guid.NewGuid(), FirstName = "Owner", LastName = "1", FullName = "Owner1" });
            Customers.Add(new Customer { Id = Guid.NewGuid(), FirstName = "OwneR", LastName = "2", FullName = "OwneR2" });

            //Adding Dummy Dogs
            Dogs.Add(new Dog { Id = Guid.NewGuid(), Animaltype = "Dog", Name = "Dog1Name", Age = 1, Gender = "Dog1Gender", Owner = "Owner1", DogType = "DogType1", InKennel = true });
            Dogs.Add(new Dog { Id = Guid.NewGuid(), Animaltype = "Dog", Name = "Dog2Name", Age = 2, Gender = "Dog2Gender", Owner = "OwneR2", DogType = "DogType2", InKennel = false });
            Dogs.Add(new Dog { Id = Guid.NewGuid(), Animaltype = "Dog", Name = "Dog3Name", Age = 3, Gender = "Dog1Gender", Owner = "OwneR2", DogType = "DogType2", InKennel = true });
            Console.WriteLine(" 3 dog´s added: with names : Dog1Name. Dog2Name. Dog3Name");

        }
        // Search for a Dog in list by Name and return´s 1 dog
        public IDog SearchForAnimalUsingName(string AnimalName)
        {

            var dog = Dogs.Find(Animal => Animal.Name == AnimalName);

            return dog;
        }
    }
}
