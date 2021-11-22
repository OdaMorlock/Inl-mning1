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

        IDogManager dogManager;
        ICustomerManager customerManager;
        public KennelServices(IDogManager dogManager, ICustomerManager customerManager)
        {
            this.dogManager = dogManager;
            this.customerManager = customerManager;
        }

        public decimal Cost { get;set; }



        // does the cutting claw register and cost calculation
        public void CuttingClaws()
        {
            Console.WriteLine("Please Write the name of the Animal you want Getting the CuttingClaw Service");
            var AnimalName = Console.ReadLine();
            var dog = dogManager.SearchTroughtListByAnimalName(AnimalName);

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
            var dog = dogManager.SearchTroughtListByAnimalName(AnimalName);

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

        // Turns In or Out and Animal
        public void TurnInAnimal(string AnimalName)
        {
            if (dogManager.Dogs.Any(where => where.Name == AnimalName))
            {
                Console.WriteLine($"{AnimalName} Turned In");
                dogManager.Dogs.Find(Animal => Animal.Name == AnimalName).InKennel = true;
                dogManager.Dogs.Find(Animal => Animal.Name == AnimalName).SetTurnInTime();
            }


        }

        public void TakeOutAnimal(string AnimalName)
        {
            decimal cost = 10;

            if (dogManager.Dogs.Any(where => where.Name == AnimalName))
            {
                Console.WriteLine($"{AnimalName} Taken Out");
                dogManager.Dogs.Find(Animal => Animal.Name == AnimalName).InKennel = false;

                var turnInTime = dogManager.Dogs.Find(Animal => Animal.Name == AnimalName).TurnInTime;
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
