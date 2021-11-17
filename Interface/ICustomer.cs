using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Interface
{
    interface ICustomer
    {
        Guid Id { get; set;}
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; set; }
        

    }
}
