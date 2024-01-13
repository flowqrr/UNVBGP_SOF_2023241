using sof_feleves.Logic.Interfaces;
using sof_feleves.Models;
using sof_feleves.Repository;
using System;

namespace sof_feleves.Logic
{
    public class ServiceLogic : IServiceLogic
    {
        private readonly IRepository<Service> _repository;

        public ServiceLogic(IRepository<Service> repo)
        {
            this._repository = repo;
        }

        public void Create(Service item)
        {
            if (item.Name.Length < 2)
            {
                throw new ArgumentException("Service name must have at least 2 characters");
            }

            _repository.Create(item);
        }

        public void Delete(string id)
        {
            _repository.Delete(id);
        }

        public Service Read(string id)
        {
            Service service = _repository.Read(id);

            if (service == null)
            {
                throw new ArgumentException("Service does not exist");
            }

            return service;
        }

        public IQueryable<Service> ReadAll()
        {
            return _repository.ReadAll();
        }

        public void Update(Service item)
        {
            _repository.Update(item);
        }

        public int CountItems()
        {
            return _repository.CountItems();
        }
    }
}
