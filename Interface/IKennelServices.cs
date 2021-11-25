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

        void Washing(List<IAnimal> animals);
        void CuttingClaws(List<IAnimal> animals);


    }
}
