using Diary.Domain.Repository;
using Diary.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Diary.Infrastructure.Core
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly DiaryContext _context;
        private readonly DbSet<T> _entities;

        public BaseRepository(DiaryContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task AddAsync(T entity)
        {
            await _entities.AddAsync(entity);
        }

        public void Update(T entity)
        {
            _entities.Update(entity);
        }

        public void Delete(T entity)
        {
            _entities.Remove(entity);
        }
    }
}
