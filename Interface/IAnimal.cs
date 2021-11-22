using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Interface
{
    interface IAnimal
    {
       
        Guid Id { get; set; }
        string Animaltype { get; set; }
        string Name { get; set; }
        int Age { get; set; }
        string Gender { get; set; }
        string Owner { get; set; }
        bool InKennel { get; set; }
        DateTime TurnInTime { get; set; }
        void SetTurnInTime();
        void SetId();

    }
}


