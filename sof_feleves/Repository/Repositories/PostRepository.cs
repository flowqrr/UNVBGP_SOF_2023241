using sof_feleves.Models;

namespace sof_feleves.Repository.Repositories
{
    public class PostRepository : Repository<Post>, IRepository<Post>
    {
        public PostRepository(AppDbContext ctx) : base(ctx)
        {
        }

        public override Post? Read(string id)
        {
            return ctx.Posts.FirstOrDefault(t => t.ID == id);
        }

        public override void Update(Post item)
        {
            var old = Read(item.ID);

            foreach (var property in old.GetType().GetProperties())
            {
                if (property.GetAccessors().FirstOrDefault(x => x.IsVirtual) == null)
                {
                    property.SetValue(old, property.GetValue(item));
                }
            }

            ctx.SaveChanges();
        }
    }
}
