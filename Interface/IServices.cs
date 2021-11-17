using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Interface
{
    interface IServices
    {
        void ViewServices();
        void AddCustomer();
        void AddDog();
        void ViewList();
        void AddDummyCustomersAndDogs();
        void TurnInAnimal(string Animal);
        void TakeOutAnimals(string Animal);

    }
}
