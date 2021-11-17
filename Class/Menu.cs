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
        IAddToList addToList;
        IViewList viewList;



        public Menu(IKennelServices kennelServices, IAddToList addToList, IViewList viewList)
        {
            this.kennelServices = kennelServices;
            this.addToList = addToList;
            this.viewList = viewList;
        }

        // The Main Menu
        public void MainMenu(List<ICustomer> customers, List<IDog> dogs)
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
                switch (Option)
                {

                    case "1":
                        AddMenu(customers,dogs);
                        break;
                    case "2":
                        KennelServicesMenu(customers, dogs);
                        break;
                    case "3":
                        ViewListMenu(customers, dogs);
                        break;
                    case "Exit":
                        Active = false;
                        Console.WriteLine("Closeing Program");
                        break;
                    case "e":
                        Active = false;
                        Console.WriteLine("Closeing Program");
                        break;
                    default:
                        Console.WriteLine($"Invalid Option {Option}" + " " + "Please type 1 Or 2 Or 3 Or 4 or 5");
                        break;
                }

            }
        }

        //The Menu for KennelServices
        public void KennelServicesMenu(List<ICustomer> customers, List<IDog> dogs)
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
                string AnimalName;
                switch (Option)
                {
                    case "1":
                        kennelServices.Washing(dogs);
                        break;
                    case "2":
                        kennelServices.CuttingClaws(dogs);
                        break;
                    case "3":
                        Console.WriteLine("Name of the Dog you wish to Turn In");
                        AnimalName = Console.ReadLine();
                        kennelServices.TurnInAnimal(dogs,AnimalName);
                        Console.WriteLine("------------------------------------------");
                        break;
                    case "4":
                        Console.WriteLine("Name of the Dog you wish to Turn Out");
                        AnimalName = Console.ReadLine();
                        kennelServices.TakeOutAnimal(dogs,AnimalName);
                        Console.WriteLine("------------------------------------------");
                        break;
                    case "Exit":
                        Active = false;
                        break;
                    case "e":
                        Active = false;
                        break;
                    default:
                        Console.WriteLine($"{Option} is an Invalid Option");
                        break;
                }

            }

        }

        // The Menu for Adding to lists
        public void AddMenu(List<ICustomer> customers, List<IDog> dogs)
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

                switch (Option)
                {
                    case "1":
                        addToList.AddCustomer(customers);
                        break;

                    case "2":
                        addToList.AddDog(dogs);
                        break;
                    case "3":
                        addToList.AddDummyCustomersAndDogs(customers,dogs);
                        break;
                    case "Exit":
                        Active = false;
                        Console.WriteLine("Exiting to Main Menu");
                        break;
                    case "e":
                        Active = false;
                        Console.WriteLine("Exiting to Main Menu");
                        break;
                    default:
                        Console.WriteLine($"{Option} is an Invalid Option");
                        break;
                }
            }
        }

        // Menu for view List and Search Through List
        public void ViewListMenu(List<ICustomer> customers, List<IDog> dogs)
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
                switch (Option)
                {
                    case "1":
                        viewList.ListOfCustomer(customers);
                        break;
                    case "2":
                        viewList.ListOfDogs(dogs);
                        break;
                    case "3":
                        Console.WriteLine("Write Owner FullName ex: FirstName.LastName");
                        var SearchName = Console.ReadLine();
                        viewList.ListOfDogsOwnedByOwner(dogs,SearchName);
                        break;
                    case "Exit":
                        Active = false;
                        Console.WriteLine("Exiting List View");
                        break;
                    case "e":
                        Active = false;
                        Console.WriteLine("Exiting List View");
                        break;
                    default:
                        Console.WriteLine($"Invalid Option {Option}" + " " + "Please type 1 Or 2 Or 3 Or 4");
                        break;
                }
            }
        }



    }
}
