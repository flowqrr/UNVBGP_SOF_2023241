using sof_feleves.Logic.Interfaces;
using sof_feleves.Models;
using sof_feleves.Repository;

namespace sof_feleves.Logic
{
    public class AppointmentLogic : IApointmentLogic
    {
        private readonly IRepository<Appointment> _repository;

        public AppointmentLogic(IRepository<Appointment> repo)
        {
            this._repository = repo;
        }

        public void Create(Appointment item)
        {
            if (item.ServiceID == null)
            {
                throw new ArgumentException("Appointment must contain a ServiceID");
            }

            _repository.Create(item);
        }

        public void Delete(string id)
        {
            _repository.Delete(id);
        }

        public Appointment Read(string id)
        {
            Appointment appointment = _repository.Read(id);

            if (appointment == null)
            {
                throw new ArgumentException("Appointment does not exist");
            }

            return appointment;
        }

        public IQueryable<Appointment> ReadAll()
        {
            return _repository.ReadAll();
        }

        public void Update(Appointment item)
        {
            _repository.Update(item);
        }
    }
}
