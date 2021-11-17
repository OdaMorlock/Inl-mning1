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

        List<ICustomer> Customers = new List<ICustomer>();
        List<IDog> Dogs = new List<IDog>();

        public Menu(IKennelServices kennelServices, IAddToList addToList, IViewList viewList)
        {
            this.kennelServices = kennelServices;
            this.addToList = addToList;
            this.viewList = viewList;
        }


        public void MainMenu()
        {
             bool Active = true;
            while (Active)
            {
                Console.WriteLine("Type 1 For Viewing Adding Menu");
                Console.WriteLine("Type 2 For Viewing KennelServices Menu");
                Console.WriteLine("Type 3 For View List");
                Console.WriteLine("Type Exit or e For Exiting");
                Console.WriteLine(" ");
                var Option = Console.ReadLine();
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

        public void KennelServicesMenu()
        {
            bool Active = true;
            while (Active)
            {
                Console.WriteLine("Type 1 For Washing");
                Console.WriteLine("Type 2 For CuttingClaws ");
                Console.WriteLine("Type Exit or e To Exit To Main Menu");
                Console.WriteLine(" ");
                var Option = Console.ReadLine();
                switch (Option)
                {
                    case "1":
                        kennelServices.Washing(Dogs);
                        break;
                    case "2":
                        kennelServices.CuttingClaws(Dogs);
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

        public void AddMenu()
        {
            bool Active = true;
            while (Active)
            {
                Console.WriteLine("Type 1 To AddCustomer");
                Console.WriteLine("Type 2 To Add Dog");
                Console.WriteLine("Type 3 To Add 2 Dummy Customer and 3 Dummy Dog´s");
                Console.WriteLine("Type Exit or e To Exit To Main Menu");
                var Option = Console.ReadLine();

                switch (Option)
                {
                    case "1":
                        addToList.AddCustomer(Customers);
                        break;

                    case "2":
                        addToList.AddDog(Dogs);
                        break;
                    case "3":
                        addToList.AddDummyCustomersAndDogs(Customers,Dogs);
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

        public void ViewListMenu()
        {
            bool Active = true;
            while (Active)
            {
                Console.WriteLine("Type 1 For List Of Cumstomer");
                Console.WriteLine("Type 2 For List Of Dog");
                Console.WriteLine("Type 3 For Search for Animal Owned by Specific Owner");
                Console.WriteLine("Type Exit or e For Exiting too Service Menu");

                var Option = Console.ReadLine();
                switch (Option)
                {
                    case "1":
                        viewList.ListOfCustomer(Customers);
                        break;
                    case "2":
                        viewList.ListOfDogs(Dogs);
                        break;
                    case "3":
                        Console.WriteLine("Write Owner FullName ex: FirstName.LastName");
                        var SearchName = Console.ReadLine();
                        viewList.ListOfDogsOwnedByOwner(Dogs,SearchName);
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
