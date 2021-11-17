using Inlämning1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Class
{
    class AddToList : IAddToList
    {
        // Would work better with API but dont wanna build one for this Assignment


        ICustomer Customer;
        IDog Dog;

        public AddToList(ICustomer customer, IDog dog)
        {
            Customer = customer;
            Dog = dog;

        }


        //Adds a Customer to the Customer List
        public void AddCustomer(List<ICustomer> customers)
        {
            Console.WriteLine("Please Write The Customers FirstName");
            Customer.FirstName = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("Please Write The Customers LastName");
            Customer.LastName = Console.ReadLine();
            Console.WriteLine(" ");

            Customer.FullName = Customer.FirstName + "." + Customer.LastName;
            Customer.Id = Guid.NewGuid();

            var _customer = new Customer
            {
                Id = Customer.Id,
                FirstName = Customer.FirstName,
                LastName = Customer.LastName,
                FullName = Customer.FullName
            };

            customers.Add(_customer);

        }

        //Adds a Dog into the Dog List
        public void AddDog(List<IDog> dogs)
        {
            Console.WriteLine("Please Write The Dog´s Name");
            Dog.Name = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("Please Write The Dog´s Age");
            var answear = Console.ReadLine();
            Console.WriteLine(" ");
            #region TryParse 

            // Attempting too turn answear into Int if invalid twice exit program
            bool TryParse = Int32.TryParse(answear, out int result);
            if (TryParse)
            {
                Dog.Age = result;
            }
            else
            {
                Console.WriteLine($"{answear} is not a valid Number Try Again");
                bool TryParse2 = Int32.TryParse(Console.ReadLine(), out int result2);
                if (TryParse2)
                {
                    Dog.Age = result2;
                }
                else
                {
                    Console.WriteLine("Shutting down Program");
                    System.Environment.Exit(1);
                }
            }
            #endregion


            Console.WriteLine("Please Write The Dog´s Gender");
            Dog.Gender = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("Please Write The Dog Type");
            Dog.DogType = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("Please Write The Owners Name");
            Dog.Owner = Console.ReadLine();
            Console.WriteLine(" ");



            Dog.SetAnimaltype();

            // Cause i dont use or have automapper and dont know how too use it
            var _dog = new Dog
            {
                Id = Dog.Id,
                Name = Dog.Name,
                Age = Dog.Age,
                Animaltype = Dog.Animaltype,
                Gender = Dog.Gender,
                Owner = Dog.Owner,
                DogType = Dog.DogType,
                InKennel = false

            };

            dogs.Add(_dog);


        }


        // Add´s 2 Customers and 3 Dog´s
        public void AddDummyCustomersAndDogs(List<ICustomer> customers, List<IDog> dogs)
        {
            // Adding Dummy Customers
            customers.Add(new Customer { Id = Guid.NewGuid(), FirstName = "Owner", LastName = "1", FullName = "Owner.1" });
            customers.Add(new Customer { Id = Guid.NewGuid(), FirstName = "Owner", LastName = "2", FullName = "Owner.2" });

            //Adding Dummy Dogs
            dogs.Add(new Dog { Id = Guid.NewGuid(), Animaltype = "Dog", Name = "Dog1Name", Age = 1, Gender = "Dog1Gender", Owner = "Owner.1", DogType = "DogType1", InKennel = false });
            dogs.Add(new Dog { Id = Guid.NewGuid(), Animaltype = "Dog", Name = "Dog2Name", Age = 2, Gender = "Dog2Gender", Owner = "Owner.2", DogType = "DogType2", InKennel = false });
            dogs.Add(new Dog { Id = Guid.NewGuid(), Animaltype = "Dog", Name = "Dog3Name", Age = 3, Gender = "Dog1Gender", Owner = "Owner.2", DogType = "DogType2", InKennel = false });

        }


    }
}
