namespace sof_feleves.Repository
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> ReadAll();
        void Create(T item);
        T? Read(string id);
        void Update(T item);
        void Delete(string id);
    }
}
