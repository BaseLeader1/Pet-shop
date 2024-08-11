using PetShop.Data;
using PetShop.Models;

namespace PetShop.Repositories
{
    public class CategorieRepository : IRepositoryCategorie
    {


        private PetStoreContext _petStoreContext;
        public CategorieRepository(PetStoreContext petStoreContext)
        {
            _petStoreContext = petStoreContext;
        }

        public IEnumerable<Category> GetCategorie()
        {
            return _petStoreContext.Category!;
        }





    }
}
