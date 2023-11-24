using sof_feleves.Logic.Interfaces;
using sof_feleves.Models;
using sof_feleves.Repository;

namespace sof_feleves.Logic
{
    public class PostLogic : IPostLogic
    {
        private readonly IRepository<Post> _repository;

        public PostLogic(IRepository<Post> repo)
        {
            this._repository = repo;
        }

        public void Create(Post item)
        {
            if (item.Title.Length < 2)
            {
                throw new ArgumentException("Post title must have at least 2 characters");
            }

            _repository.Create(item);
        }

        public void Delete(string id)
        {
            _repository.Delete(id);
        }

        public Post Read(string id)
        {
            Post Post = _repository.Read(id);

            if (Post == null)
            {
                throw new ArgumentException("Post does not exist");
            }

            return Post;
        }

        public IQueryable<Post> ReadAll()
        {
            return _repository.ReadAll();
        }

        public void Update(Post item)
        {
            _repository.Update(item);
        }
    }
}
