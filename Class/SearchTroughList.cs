using Inlämning1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Class
{
    class SearchTroughList :ISearchTroughList
    {
        public IDog SearchForAnimalUsingName(List<IDog> dogs, string AnimalName)
        {
            var dog = dogs.Find(Animal => Animal.Name == AnimalName);
            return dog;
        }
    }
}
