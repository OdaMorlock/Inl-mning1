using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Interface
{
    interface IKennelServices
    {

        Decimal Cost { get; set; }

        void Washing(List<IDog> dogs);
        void CuttingClaws(List<IDog> dogs);
        public void TurnInAnimal(List<IDog> dogs,string AnimalName);
        public void TakeOutAnimal(List<IDog> dogs,string AnimalName);

    }
}
