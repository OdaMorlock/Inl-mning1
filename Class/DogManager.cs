using Inlämning1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Class
{
    class DogManager : IDogManager
    {
        IDog dog;

        public DogManager(IDog dog)
        {
            this.dog = dog;
            Dogs = new List<IDog>(); 
        }

        public List<IDog> Dogs { get; set; }


        public void AddDog()
        {
            Console.WriteLine("Please Write The Dog´s Name");
            dog.Name = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("Please Write The Dog´s Age");
            var answear = Console.ReadLine();
            Console.WriteLine(" ");
            #region TryParse 

            // Attempting too turn answear into Int if invalid twice exit program
            bool TryParse = Int32.TryParse(answear, out int result);
            if (TryParse)
            {
                dog.Age = result;
            }
            else
            {
                Console.WriteLine($"{answear} is not a valid Number Try Again");
                bool TryParse2 = Int32.TryParse(Console.ReadLine(), out int result2);
                if (TryParse2)
                {
                    dog.Age = result2;
                }
                else
                {
                    Console.WriteLine("Shutting down Program");
                    System.Environment.Exit(1);
                }
            }
            #endregion


            Console.WriteLine("Please Write The Dog´s Gender");
            dog.Gender = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("Please Write The Dog Type");
            dog.DogType = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("Please Write The Owners Name");
            dog.Owner = Console.ReadLine();
            Console.WriteLine(" ");



            dog.SetAnimaltype();
            dog.InKennel = false;

            Dogs.Add(dog);
   
        }

        public void ViewListOfDogs()
        {
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
        }


        public void ListOfDogsOwnedByOwner(string OwnerFullName)
        {


            var found = Dogs.FindAll(x => x.Owner == OwnerFullName);

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
            else if (found.Count == 0)
            {
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine($"Chould not find an dog with Owner: {OwnerFullName}");
                Console.WriteLine("");
                Console.WriteLine("----------------------------------------------------------");
            }

        }

        public void AddDummyDogs()
        {
            //Adding Dummy Dogs
            Dogs.Add(new Dog { Id = Guid.NewGuid(), Animaltype = "Dog", Name = "Dog1Name", Age = 1, Gender = "Dog1Gender", Owner = "Owner.1", DogType = "DogType1", InKennel = false });
            Dogs.Add(new Dog { Id = Guid.NewGuid(), Animaltype = "Dog", Name = "Dog2Name", Age = 2, Gender = "Dog2Gender", Owner = "Owner.2", DogType = "DogType2", InKennel = false });
            Dogs.Add(new Dog { Id = Guid.NewGuid(), Animaltype = "Dog", Name = "Dog3Name", Age = 3, Gender = "Dog1Gender", Owner = "Owner.2", DogType = "DogType2", InKennel = false });

        }

        public void TurnInAnimal(string AnimalName)
        {
            if (Dogs.Any(where => where.Name == AnimalName))
            {
                Console.WriteLine($"{AnimalName} Turned In");
                Dogs.Find(Animal => Animal.Name == AnimalName).InKennel = true;
                Dogs.Find(Animal => Animal.Name == AnimalName).SetTurnInTime();

            }

        }

        public void TakeOutAnimal(string AnimalName)
        {
            int difference = 0;
            if (Dogs.Any(where => where.Name == AnimalName))
            {
                Console.WriteLine($"{AnimalName} Taken Out");
                Dogs.Find(Animal => Animal.Name == AnimalName).InKennel = false;

                var turnInTime = Dogs.Find(Animal => Animal.Name == AnimalName).TurnInTime;
                 difference = DateTime.Now.Hour - turnInTime.Hour;
                if (difference < 0)
                {
                    difference = 1;
                }
                decimal cost = 5;
                cost = cost * difference;
                Console.WriteLine($"Cost is :{cost} ");

            }
    
        }
    
    }
}
