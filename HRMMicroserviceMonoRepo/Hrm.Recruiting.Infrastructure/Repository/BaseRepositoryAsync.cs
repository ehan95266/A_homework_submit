﻿using System;
using Hrm.Recruiting.ApplicationCoreLayer.Contract.Repository;
using Hrm.Recruiting.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Hrm.Recruiting.Infrastructure.Repository
{
        public class BaseRepositoryAsync<T> : IRepositoryAsync<T> where T : class
        {
            private readonly RecruitmentDbContext db;
            public BaseRepositoryAsync(RecruitmentDbContext _context)
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
                return await db.SaveChangesAsync();
            }

            public async Task<int> UpdateAsync(T entity)
            {
                db.Entry(entity).State = EntityState.Modified;
                return await db.SaveChangesAsync();
            }
        }
    
}

