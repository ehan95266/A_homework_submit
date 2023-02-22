using System;
using Hrm.ApplicationCore.Contract.Repository;
using Hrm.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Hrm.Infrastructure.Repository
{
    public class BaseRepositoryAsync<T> : IRepositoryAsync<T> where T : class
    {
        private readonly HrmDbContext db;
        public BaseRepositoryAsync(HrmDbContext _context) //inject an object of DbContext
                                                          //how does this class access to HRMDbContext? we have already done dependency injection of DbContext in Program.cs
                                                          //so it will handle it for us
        {
            db = _context;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var entity = await db.Set<T>().FindAsync(id);
            if (entity != null)
            {
                db.Set<T>().Remove(entity);
                return await db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await db.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await db.Set<T>().FindAsync(id);
        }

        public async Task<int> InsertAsync(T entity)
        {
            db.Set<T>().Add(entity);
            return await db.SaveChangesAsync(); //committ 
        }

        public async Task<int> UpdateAsync(T entity) //data already existed just need to modify
        {
            db.Entry(entity).State = EntityState.Modified;
            return await db.SaveChangesAsync();
        }
    }
}

