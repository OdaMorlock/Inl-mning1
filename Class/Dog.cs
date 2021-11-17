using Inlämning1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Class
{
    class Dog : IDog
    {
    
        public Guid Id { get; set; }

        public string Owner { get; set; }
        public string Animaltype { get; set; }


        public string DogType { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public bool InKennel { get; set; }
        public DateTime TurnInTime { get; set; }


        #region Set 
        public void SetAnimaltype()
        {
            if (string.IsNullOrWhiteSpace(Animaltype))
            {
                Animaltype = "Dog";
            }
          
        }



        public void SetId()
        {
            if (Id == Guid.Empty)
            {
                Id = Guid.NewGuid();
            }
 
        }

        public void SetTurnInTime()
        {
            TurnInTime = DateTime.Now;
        }
        #endregion


    }
}
