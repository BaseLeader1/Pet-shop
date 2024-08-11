using PetShop.Models;

namespace PetShop.Repositories
{
    public interface IRepositoryAnimal
    {
        IEnumerable<Animal> GetAnimal();
        void InsertAnimals(Animal animals);
        void UpdateAnimals(int AnimalId, Animal animals);
        void DeleteAnimals(int AnimalId);
        Animal GetAnimalById(int AnimalId);
    }
}
