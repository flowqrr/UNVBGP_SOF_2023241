using Humanizer;
using sof_feleves.Logic.Interfaces;
using sof_feleves.Models;
using sof_feleves.Repository;

namespace sof_feleves.Logic
{
    public class AppointmentLogic : IAppointmentLogic
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
            if (item.MaxApplicants <= 0)
            {
                throw new ArgumentException("Number of applicants should be a positive number");
            }
            if (item.Date <= DateTime.Now)
            {
                throw new ArgumentException("Date of the appointment cannot be in the past");
            }

            item.Date = item.Date.ToUniversalTime();
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

        public void ApplyForAppointment(Appointment appointment, SiteUser user)
        {
            if (appointment == null)
            {
                throw new ArgumentException("Appointment to apply for was not found");
            }
            else if (user == null)
            {
                throw new ArgumentException("User was not found. Try signing in");
            }
            else if (appointment.MaxApplicants == appointment.Applicants.Count)
            {
                throw new AppointmentFullException();
            }

            appointment.Applicants.Add(user);
            Update(appointment);
        }

        public void CancelAppointmentApplication(Appointment appointment, SiteUser user)
        {
            if (appointment == null)
            {
                throw new ArgumentException("Appointment to cancel was not found");
            }
            else if (user == null)
            {
                throw new ArgumentException("User was not found. Try signing in");
            }
            else if (!appointment.Applicants.Contains(user))
            {
                throw new ArgumentException("User cannot be removed from this appointment because they aren't on the applicant list");
            }

            appointment.Applicants.Remove(user);
            Update(appointment);
        }
    }

    public class AppointmentFullException : Exception
    {
        public AppointmentFullException() : base("This appointment is already full:(") { }
    }
}
