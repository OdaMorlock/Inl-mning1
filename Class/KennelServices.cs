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
        IViewList viewList;
        ISearchTroughList searchTroughList;

        public KennelServices(IViewList viewList, ISearchTroughList searchTroughList)
        {
            this.viewList = viewList;
            this.searchTroughList = searchTroughList;
        }

        public decimal Cost { get;set; }



        // does the cutting claw register and cost calculation
        public void CuttingClaws(List<IDog> dogs)
        {
            Console.WriteLine("Please Write the name of the Animal you want Getting the CuttingClaw Service");
            var AnimalName = Console.ReadLine();
            var dog = searchTroughList.SearchForAnimalUsingName(dogs, AnimalName);

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
        public void Washing(List<IDog> dogs)
        {
            Console.WriteLine("Please Write the name of the Animal you want Getting Washing the Service");
            var AnimalName = Console.ReadLine();
            var dog = searchTroughList.SearchForAnimalUsingName(dogs,AnimalName);

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
        public void TurnInAnimal(List<IDog> dogs, string AnimalName)
        {
            if (dogs.Any(where => where.Name == AnimalName))
            {
                dogs.Find(Animal => Animal.Name == AnimalName).InKennel = true;
                dogs.Find(Animal => Animal.Name == AnimalName).SetTurnInTime();
            }


        }

        public void TakeOutAnimal(List<IDog> dogs, string AnimalName)
        {
            decimal cost = 10;

            if (dogs.Any(where => where.Name == AnimalName))
            {

                dogs.Find(Animal => Animal.Name == AnimalName).InKennel = false;

                var turnInTime = dogs.Find(Animal => Animal.Name == AnimalName).TurnInTime;
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
