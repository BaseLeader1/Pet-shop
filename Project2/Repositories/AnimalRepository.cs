using Microsoft.EntityFrameworkCore;
using PetShop.Data;
using PetShop.Models;

namespace PetShop.Repositories

{
    public class AnimalRepository : IRepositoryAnimal
    {
        private PetStoreContext _petStoreContext;
        public AnimalRepository(PetStoreContext petStoreContext)
        {
            _petStoreContext = petStoreContext;
        }

        public IEnumerable<Animal> GetAnimal()
        {
            return _petStoreContext.Animal!.Include(x => x.Comment);
        }

        public void InsertAnimals(Animal animals)
        {
            _petStoreContext.Animal!.Add(animals);
            _petStoreContext.SaveChanges();
        }

        public void UpdateAnimals(int AnimalId, Animal animals)
        {

            var animalInDb = GetAnimalById(AnimalId);
            if (animalInDb != null)
            {
                animalInDb.Name = animals.Name;
                animalInDb.Age = animals.Age;
                animalInDb.CategoryId = animals.CategoryId;
                animalInDb.Description = animals.Description;
            }
            _petStoreContext.SaveChanges();
        }
        public void DeleteAnimals(int AnimalId)
        {
            var animalInDb = _petStoreContext.Animal!.Find(AnimalId);
            if (animalInDb != null)
            {
                _petStoreContext.Animal!.Remove(animalInDb);
            }
            _petStoreContext.SaveChanges();
        }
        public Animal GetAnimalById(int AnimalId)
        {
            return _petStoreContext.Animal!.Find(AnimalId)!;
        }
    }

}
