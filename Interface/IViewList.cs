using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Interface
{
    interface IViewList
    {
        void ListOfCustomer(List<ICustomer> customers);
        void ListOfDogs(List<IDog> dogs);
        void ListOfDogsOwnedByOwner(List<IDog> dogs,string OwnerFullName);
        IDog SearchForAnimalUsingName(List<IDog> dogs, string AnimalName);
    }
}
