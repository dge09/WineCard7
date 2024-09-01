namespace WineCard7.DB.Services
{
    public interface IBaseServices<T>
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task DeleteByIDAsync(int id);
        Task<T> GetByIDAsync(int id);
        Task<List<T>> GetAllAsync();
    }
}
