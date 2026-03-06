namespace Repositories.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        T? GetById(object id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}
