namespace PetShop.Repositories
{
    public interface IRepositoryComment
    {
        IEnumerable<Comment> GetComment();
        void InsertComment(Comment comment);
        void DeleteComment(int AnimalId);
    }
}
