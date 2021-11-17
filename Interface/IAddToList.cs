using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Interface
{
    interface IAddToList
    {
        void AddCustomer(List<ICustomer> customers);
        void AddDog(List<IDog> dogs);
        void AddDummyCustomersAndDogs(List<ICustomer> customers, List<IDog> dogs);
    }
}
