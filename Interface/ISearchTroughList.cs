using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Interface
{
    interface ISearchTroughList
    {
        IDog SearchForAnimalUsingName(List<IDog> dogs, string AnimalName);
    }
}
