using Microsoft.EntityFrameworkCore;
using System.CodeDom;
using WineCard7.DB.Entitys;

namespace WineCard7.DB.Services
{
    public class BaseServices<T> : IBaseServices<T> where T : BaseModel
    {
        private readonly DataContext _context;

        public BaseServices(DataContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            }

        public async Task UpdateAsync(T entity)
        {
            T t = _context.Set<T>().Where(x => x.ID == entity.ID).First();

            if (t != null)
            {
                _context.Set<T>().Update(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(T entity)
        {
            T t = _context.Set<T>().Find(entity);

            if (t != null)
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteByIDAsync(int id)
        {
            T t = _context.Set<T>().Where(x => x.ID == id).First();

            if (t != null)
            {
                _context.Set<T>().Remove(t);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIDAsync(int id)
        {
            return await _context.Set<T>().Where(x => x.ID == id).FirstOrDefaultAsync(); 
        }
    }
}