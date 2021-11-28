using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Interface
{
    interface ICustomerManager
    {

        List<ICustomer> Customers { get; set; }

        void AddCustomer();

        void ListOfCustomer();

        void DummyCustomer();

    }
}
