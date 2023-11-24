using sof_feleves.Models;

namespace sof_feleves.Logic.Interfaces
{
    public interface IPostLogic
    {
        void Create(Post item);
        void Delete(string id);
        Post Read(string id);
        IQueryable<Post> ReadAll();
        void Update(Post item);
    }
}
