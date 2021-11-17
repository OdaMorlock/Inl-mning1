using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Interface
{
    interface IDog :IAnimal
    {
        string DogType { get; set; }
        DateTime TurnInTime { get; set; }
        void SetTurnInTime();
        void SetAnimaltype();
        void SetId();

    }
}
