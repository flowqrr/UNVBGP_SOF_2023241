using sof_feleves.Models;

namespace sof_feleves.Repository.Repositories
{
    public class AppointmentRepository : Repository<Appointment>, IRepository<Appointment>
    {
        public AppointmentRepository(AppDbContext ctx) : base(ctx)
        {
        }

        public override Appointment Read(string id)
        {
            return ctx.Appointments.FirstOrDefault(t => t.ID == id);
        }

        public override void Update(Appointment item)
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
