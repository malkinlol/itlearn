using itlearn.dal.Context;
using itlearn.dal.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace itlearn.dal.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>
             where T : class
    {
        private readonly ApplicationContext _context;

        public BaseRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>()
                .ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>()
                .FindAsync(id);
        }

        public async Task<bool> Create(T entity)
        {
            await _context.Set<T>()
                .AddAsync(entity);

            int created = await _context.SaveChangesAsync();

            return created > 0;
        }

        public async Task<bool> Update(T entity)
        {
            _context.Set<T>()
                .Update(entity);

            int updated = await _context.SaveChangesAsync();

            return updated > 0;
        }

        public async Task<bool> Delete(T entity)
        {
            _context.Set<T>()
                .Remove(entity);

            int deleted = await _context.SaveChangesAsync();

            return deleted > 0;
        }

        public async Task<int> Count()
        {
            return await _context.Set<T>()
                .CountAsync();
        }
    }
}
