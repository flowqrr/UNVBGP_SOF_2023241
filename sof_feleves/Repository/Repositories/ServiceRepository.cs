using sof_feleves.Models;

namespace sof_feleves.Repository
{
    public class ServiceRepository : Repository<Service>, IRepository<Service>
    {
        public ServiceRepository(AppDbContext ctx) : base(ctx)
        {
        }

        public override Service? Read(string id)
        {
            return ctx.Services.FirstOrDefault(t => t.ID == id);
        }

        public override void Update(Service item)
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
