using Inlämning1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Class
{
    class Menu : IMenu
    {
        IKennelServices kennelServices;
        IChecksAndControlls checksAndControlls;
        ICustomerManager customerManager;
        IDogManager dogManager;



        public Menu(IKennelServices kennelServices, IChecksAndControlls checksAndControlls, ICustomerManager customerManager, IDogManager dogManager)
        {
            this.kennelServices = kennelServices;
            this.checksAndControlls = checksAndControlls;
            this.customerManager = customerManager;
            this.dogManager = dogManager;
        }

        // The Main Menu
        public void MainMenu()
        {
            try
            {
                bool Active = true;
                while (Active)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Type 1 For Viewing Adding Menu");
                    Console.WriteLine("Type 2 For Viewing KennelServices Menu");
                    Console.WriteLine("Type 3 For View List");
                    Console.WriteLine("Type Exit or e For Exiting");
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine(" ");

                    var Option = Console.ReadLine();

                    Option = checksAndControlls.UppercaseFirstLetter(Option);

                    switch (Option)
                    {

                        case "1":
                            AddMenu();
                            break;
                        case "2":
                            KennelServicesMenu();
                            break;
                        case "3":
                            ViewListMenu();
                            break;
                        case "Exit":
                            Active = false;
                            Console.WriteLine("Closeing Program");
                            break;
                        case "E":
                            Active = false;
                            Console.WriteLine("Closeing Program");
                            break;
                        default:
                            Console.WriteLine($"Invalid Option {Option}" + " " + "Please type 1 Or 2 Or 3 Or 4 or 5");
                            break;
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        //The Menu for KennelServices
        public void KennelServicesMenu()
        {
            try
            {
                bool Active = true;
                while (Active)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Type 1 For Washing");
                    Console.WriteLine("Type 2 For CuttingClaws ");
                    Console.WriteLine("Type 3 For TurningInDog ");
                    Console.WriteLine("Type 4 For TurningOutDog ");
                    Console.WriteLine("Type Exit or e To Exit To Main Menu");
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine(" ");
                    var Option = Console.ReadLine();

                    Option = checksAndControlls.UppercaseFirstLetter(Option);

                    string AnimalName;
                    switch (Option)
                    {
                        case "1":
                            kennelServices.Washing();
                            break;
                        case "2":
                            kennelServices.CuttingClaws();
                            break;
                        case "3":
                            Console.WriteLine("Name of the Dog you wish to Turn In");
                            AnimalName = Console.ReadLine();
                            kennelServices.TurnInAnimal(AnimalName);
                            Console.WriteLine("------------------------------------------");
                            break;
                        case "4":
                            Console.WriteLine("Name of the Dog you wish to Turn Out");
                            AnimalName = Console.ReadLine();
                            kennelServices.TakeOutAnimal(AnimalName);
                            Console.WriteLine("------------------------------------------");
                            break;
                        case "Exit":
                            Active = false;
                            break;
                        case "E":
                            Active = false;
                            break;
                        default:
                            Console.WriteLine($"{Option} is an Invalid Option");
                            break;
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
            

        }

        // The Menu for Adding to lists
        public void AddMenu()
        {
            try
            {
                bool Active = true;
                while (Active)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Type 1 To AddCustomer");
                    Console.WriteLine("Type 2 To Add Dog");
                    Console.WriteLine("Type 3 To Add 2 Dummy Customer and 3 Dummy Dog´s");
                    Console.WriteLine("Type Exit or e To Exit To Main Menu");
                    Console.WriteLine("------------------------------------------");
                    var Option = Console.ReadLine();

                    Option = checksAndControlls.UppercaseFirstLetter(Option);

                    switch (Option)
                    {
                        case "1":
                            customerManager.AddCustomer();
                            break;

                        case "2":
                            dogManager.AddDog();
                            break;
                        case "3":
                            dogManager.AddDummyDogs();
                            customerManager.DummyCustomer();
                            break;
                        case "Exit":
                            Active = false;
                            Console.WriteLine("Exiting to Main Menu");
                            break;
                        case "E":
                            Active = false;
                            Console.WriteLine("Exiting to Main Menu");
                            break;
                        default:
                            Console.WriteLine($"{Option} is an Invalid Option");
                            break;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        // Menu for view List and Search Through List
        public void ViewListMenu()
        {
            try
            {
                bool Active = true;
                while (Active)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Type 1 For List Of Cumstomer");
                    Console.WriteLine("Type 2 For List Of Dog");
                    Console.WriteLine("Type 3 For Search for Animal Owned by Specific Owner");
                    Console.WriteLine("Type Exit or e For Exiting too Service Menu");
                    Console.WriteLine("------------------------------------------");

                    var Option = Console.ReadLine();

                    Option = checksAndControlls.UppercaseFirstLetter(Option);

                    switch (Option)
                    {
                        case "1":
                            customerManager.ListOfCustomer();
                            break;
                        case "2":
                            dogManager.ViewListOfDogs();
                            break;
                        case "3":
                            Console.WriteLine("Write Owner FullName ex: FirstName.LastName");
                            var SearchName = Console.ReadLine();
                            dogManager.ListOfDogsOwnedByOwner(SearchName);
                            break;
                        case "Exit":
                            Active = false;
                            Console.WriteLine("Exiting List View");
                            break;
                        case "E":
                            Active = false;
                            Console.WriteLine("Exiting List View");
                            break;
                        default:
                            Console.WriteLine($"Invalid Option {Option}" + " " + "Please type 1 Or 2 Or 3 Or 4");
                            break;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }



    }
}
