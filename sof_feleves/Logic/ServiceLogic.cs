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

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Service Read(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Service> ReadAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Service item)
        {
            throw new NotImplementedException();
        }
    }
}
