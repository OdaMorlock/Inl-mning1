using System.Collections.Generic;

namespace Inlämning1.Interface
{
    interface IDogManager
    {
        
        void AddDog();
        void AddDummyDogs();
        IDog SearchTroughtListByOwnerName(string OwnerFullName);
        IDog SearchTroughtListByAnimalName(string AnimalName);
        void ListOfDogsOwnedByOwner(string OwnerFullName);
        void ViewListOfDogs();

        List<IDog> Dogs { get; set; }
        
    }
}