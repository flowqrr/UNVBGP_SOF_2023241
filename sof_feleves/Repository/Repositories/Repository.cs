namespace sof_feleves.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected AppDbContext ctx;

        public Repository(AppDbContext ctx)
        {
            this.ctx = ctx;
        }
        public void Create(T item)
        {
            ctx.Set<T>().Add(item);
            ctx.SaveChanges();
        }
        public abstract T Read(string id);
        public IQueryable<T> ReadAll()
        {
            return ctx.Set<T>();
        }
        // every descendant implements this differently
        public abstract void Update(T item);
        public void Delete(string id)
        {
            ctx.Set<T>().Remove(Read(id));
            ctx.SaveChanges();
        }
    }
}
