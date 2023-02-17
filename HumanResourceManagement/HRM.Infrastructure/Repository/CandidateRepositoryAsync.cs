using System;
using HRM.ApplicationCore.Contract.Repository;
using HRM.ApplicationCore.Entity;
using HRM.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HRM.Infrastructure.Repository
{
    public class CandidateRepositoryAsync : BaseRepositoryAsync<Candidate>, ICandidateRepositoryAsync
    {
        public CandidateRepositoryAsync(HRMDbContext _context) : base(_context)
        {
            db = _context;
        }
        public async Task<int> DeleteAsync(int id)
        {
            var entity = await db.Set<Candidate>().FindAsync(id);
            if (entity != null)
            {
                db.Set<Candidate>().Remove(entity);
                return await db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<Candidate>> GetAllAsync()
        {
            return await db.Set<Candidate>().ToListAsync();
        }

        public async Task<Candidate> GetByIdAsync(int id)
        {
            return await db.Set<Candidate>().FindAsync(id);
        }

        public async Task<int> InsertAsync(Candidate entity)
        {
            db.Set<Candidate>().Add(entity);
            return await db.SaveChangesAsync(); //committ 
        }

        public async Task<int> UpdateAsync(Candidate entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return await db.SaveChangesAsync();
        }
    }
}
