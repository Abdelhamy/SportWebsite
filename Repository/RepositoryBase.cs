namespace Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly DbContext DBContext;
        public RepositoryBase(DbContext dBContext)
        {
            DBContext = dBContext;
        }
       
        public virtual IQueryable<T> FindAll(bool trackChanges)
        {
            return trackChanges ? DBContext.Set<T>() : DBContext.Set<T>().AsNoTracking();
        }

        public virtual IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            return trackChanges ? DBContext.Set<T>().Where(expression) : DBContext.Set<T>().Where(expression).AsNoTracking();
        }

        public virtual int Count()
        {
            return DBContext.Set<T>().Count();
        }

        public virtual void Create(T entity)
        {
            DBContext.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity)
        {
            DBContext.Set<T>().Remove(entity);
        }
    }
}
