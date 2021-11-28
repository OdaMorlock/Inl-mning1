using System.Collections.Generic;

namespace Inlämning1.Interface
{
    interface IDogManager
    {
        void AddDog();
        void AddDummyDogs();
        void ListOfDogsOwnedByOwner(string OwnerFullName);
        void ViewListOfDogs();

        List<IDog> Dogs { get; set; }
        void TurnInAnimal(string AnimalName);
        void TakeOutAnimal(string AnimalName);

    }
}