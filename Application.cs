using Inlämning1.Class;
using Inlämning1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1
{
    class Application : IApplication
    {
        IServices services;
        IKennelServices kennelServices;

        public Application(IServices services, IKennelServices kennelServices)
        {
            this.services = services;
            this.kennelServices = kennelServices;
        }

        private bool Active = true;
        // Runs the Main Menu
        public void Run()
        {
            while (Active)
            {
                Console.WriteLine("Type 1 For Viewing Services");
                Console.WriteLine("Type 2 For Viewing KennelServices");
                Console.WriteLine("Type Exit For Exiting");
                Console.WriteLine("Type 4 For Adding Dummy Dog´s And Customers");
                Console.WriteLine(" ");
                var Option = Console.ReadLine();
                switch (Option)
                {

                    case "1":
                        services.ViewServices();
                        break;
                    case "2":
                        kennelServices.ViewKennelServices();
                        break;
                    case "Exit":
                        Active = false;
                        Console.WriteLine("Closeing Program");
                        break;
                    case "4":
                        services.AddDummyCustomersAndDogs();
                        break;
                    default:
                        Console.WriteLine($"Invalid Option {Option}" + " " + "Please type 1 Or 2 Or 3 Or 4 or 5");
                        break;
                }

            }
            
        }
    }
}
