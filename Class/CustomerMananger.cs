using Inlämning1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Class
{
    class CustomerMananger : ICustomerManager
    {

        public List<ICustomer> Customers { get; set; }

        readonly List<ICustomer> customers = new();

        ICustomer customer;

        public CustomerMananger(ICustomer customer)
        {
            this.customer = customer;
        }



        public void AddCustomer()
        {
             
            Console.WriteLine("Please Write The Customers FirstName");
            customer.FirstName = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("Please Write The Customers LastName");
            customer.LastName = Console.ReadLine();
            Console.WriteLine(" ");

            customer.FullName = customer.FirstName + "." + customer.LastName;
            customer.Id = Guid.NewGuid();

            customers.Add(customer);
        }

        public void DummyCustomer()
        {
            // Adding Dummy Customers
            customers.Add(new Customer { Id = Guid.NewGuid(), FirstName = "Owner", LastName = "1", FullName = "Owner.1" });
            customers.Add(new Customer { Id = Guid.NewGuid(), FirstName = "Owner", LastName = "2", FullName = "Owner.2" });
        }

        public void ListOfCustomer()
        {
            foreach (var item in customers)
            {
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine($"Owners FullName  :   {item.FullName}");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine(" ");
            }
        }
    }
}
