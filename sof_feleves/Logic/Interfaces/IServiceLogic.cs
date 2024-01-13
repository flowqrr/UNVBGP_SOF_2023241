using sof_feleves.Models;
using System;

namespace sof_feleves.Logic.Interfaces
{
    public interface IServiceLogic
    {
        void Create(Service item);
        void Delete(string id);
        Service Read(string id);
        IQueryable<Service> ReadAll();
        void Update(Service item);
        int CountItems();
    }
}
