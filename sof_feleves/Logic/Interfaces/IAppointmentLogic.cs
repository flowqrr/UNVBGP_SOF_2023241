using sof_feleves.Models;

namespace sof_feleves.Logic.Interfaces
{
    public interface IAppointmentLogic
    {
        void Create(Appointment item);
        void Delete(string id);
        Appointment Read(string id);
        IQueryable<Appointment> ReadAll();
        void Update(Appointment item);
        public void ApplyForAppointment(Appointment appointment, SiteUser user);
        public void CancelAppointmentApplication(Appointment appointment, SiteUser user);
    }
}
