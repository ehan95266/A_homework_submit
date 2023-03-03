using System;
using Dapper;
using Hrm.Authentication.ApplicationCoreLayer.Contract.Repository;
using Hrm.Authentication.ApplicationCoreLayer.Entity;
using Hrm.Authentication.Infrastructure.Data;

namespace Hrm.Authentication.Infrastructure.Repository
{
	public class RoleRepositoryAsync : IRoleRepositoryAsync
    {
        DapperDbContext dbContext;
        public RoleRepositoryAsync()
        {
            dbContext = new DapperDbContext();

        }

        public async Task<int> DeleteAsync(int id)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "DELETE FROM Role WHERE Id = @id";
                return await conn.ExecuteAsync(query, new { Id = id });
            }
        }

        public async Task<IEnumerable<Role>> GetAllAsync()
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "SELECT Id,Name,Description FROM Role";
                return await conn.QueryAsync<Role>(query);
            }
        }

        public async Task<Role> GetByIdAsync(int id)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "SELECT Id,Name,Description FROM Role Where Id=@id";
                return await conn.QuerySingleOrDefaultAsync<Role>(query, new { Id = id });
            }
        }

        public async Task<int> InsertAsync(Role entity)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "INSERT INTO Role VALUES (@Id,@Name,@Description)";
                return await conn.ExecuteAsync(query, entity);
            }
        }

        public async Task<int> UpdateAsync(Role entity)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "UPDATE Role SET Name=@Name,Description=@Description WHERE Id=@id";
                return await conn.ExecuteAsync(query, entity);
            }
        }
    }
}

