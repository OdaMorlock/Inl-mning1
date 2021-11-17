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
        //Writes full list of ICustomer
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

        //Writes full list of IDog
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

        //Search in list of IDog by Owner NAme
        public void ListOfDogsOwnedByOwner(List<IDog> dogs, string OwnerFullName)
        {
            
            var found = dogs.FindAll(x => x.Owner == OwnerFullName);
            
            if (found.Count != 0)
            {
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
            else if(found.Count == 0)
            {
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine($"Chould not find an dog with Owner: {OwnerFullName}");
                Console.WriteLine("");
                Console.WriteLine("----------------------------------------------------------");
            }
            
        }

        // Search in List By AnimalName


    }
}
