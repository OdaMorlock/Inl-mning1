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

        IDog SearchForAnimalUsingName(string AnimalName);
        void Washing();
        void CuttingClaws();
        void ViewKennelServices();

    }
}
