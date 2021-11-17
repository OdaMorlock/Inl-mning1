using Inlämning1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Class
{
    class Services : IServices
    {
        // Would work better with API but dont wanna build one for this Assignment
        List<ICustomer> Customers = new List<ICustomer>();
        List<IDog> Dogs = new List<IDog>();


        ICustomer Customer;
        IDog Dog;
   
        public Services(ICustomer customer, IDog dog)
        {
            Customer = customer;
            Dog = dog;

        }

        // runs the options from Services , Add Dog/Customer and View List and TurnIn/OutAnimal
        public void ViewServices()
        {
            bool Active = true;
            while (Active)
            {
                Console.WriteLine("Type 1 To AddCustomer");
                Console.WriteLine("Type 2 To Add Dog");
                Console.WriteLine("Type 3 For View List");
                Console.WriteLine("Type 4 For Takeing Animal In");
                Console.WriteLine("Type 5 For Takeing Animal Out");
                Console.WriteLine("Type Exit To Exit To Main Menu");
                var Option = Console.ReadLine();

                switch (Option)
                {
                    case "1":
                        AddCustomer();
                        break;

                    case "2":
                        AddDog();
                        break;

                    case "3":
                        ViewList();
                        break;

                    case "4":
                        Console.WriteLine("Name of the Animal you wish too Turn In");
                        string Animal = Console.ReadLine();
                        TurnInAnimal(Animal);
                        break;

                    case "5":
                        Console.WriteLine("Name of the Animal you wish too Turn Out");
                        string Animal2 = Console.ReadLine();
                        TakeOutAnimals(Animal2);
                        break;

                    case "Exit":
                        Active = false;
                        break;
                    default:
                        Console.WriteLine($"{Option} is an Invalid Option");
                        break;
                }
            }
        }

        //Adds a Customer to the Customer List
        public void AddCustomer()
        {
            Console.WriteLine("Please Write The Customers FirstName");
            Customer.FirstName = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("Please Write The Customers LastName");
            Customer.LastName = Console.ReadLine();
            Console.WriteLine(" ");

            Customer.FullName = Customer.FirstName +"."+ Customer.LastName;
            Customer.Id = Guid.NewGuid();

            var _customer = new Customer { 
            Id = Customer.Id,
            FirstName = Customer.FirstName,
            LastName = Customer.LastName,
            FullName = Customer.FullName
            };

            Customers.Add(_customer);
        }

        //Adds a Dog into the Dog List
        public void AddDog()
        {
            Console.WriteLine("Please Write The Dog´s Name");
            Dog.Name = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("Please Write The Dog´s Age");
            var answear = Console.ReadLine();
            Console.WriteLine(" ");
            #region TryParse 

            // Attempting too turn answear into Int if invalid twice exit program
            bool TryParse = Int32.TryParse(answear, out int result);
            if (TryParse)
            {
                Dog.Age = result;
            }
            else
            {
                Console.WriteLine($"{answear} is not a valid Number Try Again");
                bool TryParse2 = Int32.TryParse(Console.ReadLine(), out int result2);
                if (TryParse2)
                {
                    Dog.Age = result2;
                }
                else
                {
                    Console.WriteLine("Shutting down Program");
                    System.Environment.Exit(1);
                }
            }
            #endregion

       
            Console.WriteLine("Please Write The Dog´s Gender");
            Dog.Gender = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("Please Write The Dog Type");
            Dog.DogType = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("Please Write The Owners Name");
            Dog.Owner = Console.ReadLine();
            Console.WriteLine(" ");



            Dog.SetAnimaltype();

            // Cause i dont use or have automapper and dont know how too use it
            var _dog = new Dog
            {
                Id = Dog.Id,
                Name = Dog.Name,
                Age = Dog.Age,
                Animaltype = Dog.Animaltype,
                Gender = Dog.Gender,
                Owner = Dog.Owner,
                DogType = Dog.DogType,
                InKennel = false

            };

            Dogs.Add(_dog);


        }


        // Runs the options for Viewing Lists
        public void ViewList()
        {
            bool Active = true;
            while (Active)
            {
                Console.WriteLine("Type 1 For List Of Cumstomer");
                Console.WriteLine("Type 2 For List Of Dog");
                Console.WriteLine("Type 3 For Search for Animal Owned by Specific Owner");
                Console.WriteLine("Type Exit For Exiting too Service Menu");

                var Option = Console.ReadLine();
                switch (Option)
                {
                    case "1":
                        foreach (var item in Customers)
                        {
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine($"Owners FullName  :   {item.FullName}");
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine(" ");
                        }
                        break;
                    case "2":
                        foreach (var item in Dogs)
                        {
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine($"Dog Owner:{item.Owner}");
                            Console.WriteLine($"Dog Name:{item.Name} " + $"Dog Age:{item.Age}");                  
                            Console.WriteLine($"Dog Gender:{item.Gender}");
                            Console.WriteLine($"Dog Type:{item.DogType}   In Kennel:{item.InKennel}");
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine(" ");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Write Owner FullName ex: FirstName.LastName");
                        var SearchName = Console.ReadLine();
                        var found = Dogs.FindAll(item => item.Owner == SearchName);

                        foreach (var item in found)
                        {
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine($"Dog Owner:{item.Owner}");
                            Console.WriteLine($"Dog Name:{item.Name} " + $"Dog Age:{item.Age}");
                            Console.WriteLine($"Dog Gender:{item.Gender}");
                            Console.WriteLine($"Dog Type:{item.DogType}   In Kennel:{item.InKennel}");
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine(" ");
                        }
                        break;
                    case "Exit":
                        Active = false;
                        Console.WriteLine("Exiting List View");
                        break;
                    default:
                        Console.WriteLine($"Invalid Option {Option}" + " " + "Please type 1 Or 2 Or 3 Or 4");
                        break;
                }
            }
        }
        // Add´s 2 Customers and 3 Dog´s
        public void AddDummyCustomersAndDogs()
        {
            // Adding Dummy Customers
            Customers.Add(new Customer { Id = Guid.NewGuid(), FirstName = "Owner", LastName = "1", FullName = "Owner1"});
            Customers.Add(new Customer { Id = Guid.NewGuid(), FirstName = "OwneR", LastName = "2", FullName = "OwneR2" });

            //Adding Dummy Dogs
            Dogs.Add(new Dog { Id = Guid.NewGuid(), Animaltype = "Dog", Name = "Dog1Name", Age = 1, Gender = "Dog1Gender", Owner = "Owner1", DogType = "DogType1", InKennel = false });
            Dogs.Add(new Dog { Id = Guid.NewGuid(), Animaltype = "Dog", Name = "Dog2Name", Age = 2, Gender = "Dog2Gender", Owner = "OwneR2", DogType = "DogType2", InKennel = false });
            Dogs.Add(new Dog { Id = Guid.NewGuid(), Animaltype = "Dog", Name = "Dog3Name", Age = 3, Gender = "Dog1Gender", Owner = "OwneR2", DogType = "DogType2", InKennel = false });
 
        }


        // Would have wanted them too be in IKennel but i dont have an API so it dont work if i dont have the List from Serivces
        public void TurnInAnimal(string AnimalName)
        {
            if (Dogs.Any(where  => where.Name == AnimalName))
            {
               Dogs.Find(Animal => Animal.Name == AnimalName).InKennel = true;
               Dogs.Find(Animal => Animal.Name == AnimalName).SetTurnInTime();
            }
            

        }

        public void TakeOutAnimals(string AnimalName)
        {
            decimal cost = 10;

            if (Dogs.Any(where => where.Name == AnimalName))
            {

                Dogs.Find(Animal => Animal.Name == AnimalName).InKennel = false;

                var turnInTime = Dogs.Find(Animal => Animal.Name == AnimalName).TurnInTime;
                var difference = DateTime.Now.Hour - turnInTime.Hour;
                if (difference > 0)
                {
                    difference = 1;
                }
                cost = cost * difference;


            }
        }

    }
}
