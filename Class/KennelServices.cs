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
        IAnimal animal;
        public KennelServices(IDogManager dogManager, ICustomerManager customerManager, IAnimal animal)
        {
            this.dogManager = dogManager;
            this.customerManager = customerManager;
            this.animal = animal;
        }

        public decimal Cost { get;set; }

        // does the cutting claw register and cost calculation
        public void CuttingClaws(List<IAnimal> animals)
        {
            Console.WriteLine("Please Write the name of the Animal you want Getting the CuttingClaw Service");
            var AnimalName = Console.ReadLine();
            var theAnimal = animal.SearchTroughtListByAnimalName(animals,AnimalName);

            if (theAnimal != null)
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
        public void Washing(List<IAnimal> animals)
        {
            Console.WriteLine("Please Write the name of the Animal you want Getting Washing the Service");
            var AnimalName = Console.ReadLine();
            var theAnimal = animal.SearchTroughtListByAnimalName(animals,AnimalName); 

            if (theAnimal != null)
            {
                Cost = 15;
                Console.WriteLine($"the Service will cost {Cost} for getting {AnimalName} Washed");
            }
            else
            {
                Console.WriteLine($"Found no dog with the name: {AnimalName}");
            }

        }

       






    }
}
