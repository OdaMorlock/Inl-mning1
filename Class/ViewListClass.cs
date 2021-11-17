using Inlämning1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Class
{
    class ViewListClass : IViewList
    {
        public void ListOfCustomer(List<ICustomer> customers)
        {
            foreach (var item in customers)
            {
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine($"Owners FullName  :   {item.FullName}");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine(" ");
            }
        }

        public void ListOfDogs(List<IDog> dogs)
        {
            foreach (var item in dogs)
            {
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine($"Dog Owner:{item.Owner}");
                Console.WriteLine($"Dog Name:{item.Name} " + $"Dog Age:{item.Age}");
                Console.WriteLine($"Dog Gender:{item.Gender}");
                Console.WriteLine($"Dog Type:{item.DogType}   In Kennel:{item.InKennel}");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine(" ");
            }
        }

        public void ListOfDogsOwnedByOwner(List<IDog> dogs, string OwnerFullName)
        {
            var found = dogs.FindAll(item => item.Owner == OwnerFullName);

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
        }

        public IDog SearchForAnimalUsingName(List<IDog> dogs, string AnimalName)
        {
            var dog = dogs.Find(Animal => Animal.Name == AnimalName);
            return dog;
        }      

    }
}
