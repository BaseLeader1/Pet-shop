using PetShop.Data;

namespace PetShop.Repositories
{
    public class CommentRepository : IRepositoryComment
    {
        private PetStoreContext _petStoreContext;
        public CommentRepository(PetStoreContext petStoreContext)
        {
            _petStoreContext = petStoreContext;
        }

        public IEnumerable<Comment> GetComment()
        {
            return _petStoreContext.Comment!;
        }
        public void InsertComment(Comment comments)
        {
            _petStoreContext.Comment!.Add(comments);
            _petStoreContext.SaveChanges();
        }
        public void DeleteComment(int AnimalId)
        {
            var animalInDb = _petStoreContext.Comment!.Find(AnimalId);
            if (animalInDb != null)
            {
                _petStoreContext.Comment!.Remove(animalInDb);
            }
        }
    }
}
