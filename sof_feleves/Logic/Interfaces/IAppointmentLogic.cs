using sof_feleves.Models;

namespace sof_feleves.Logic.Interfaces
{
    public interface IApointmentLogic
    {
        void Create(Appointment item);
        void Delete(string id);
        Appointment Read(string id);
        IQueryable<Appointment> ReadAll();
        void Update(Appointment item);
    }
}
