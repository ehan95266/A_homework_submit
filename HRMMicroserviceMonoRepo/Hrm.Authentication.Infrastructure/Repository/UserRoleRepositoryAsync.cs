using System;
using Dapper;
using Hrm.Authentication.ApplicationCoreLayer.Contract.Repository;
using Hrm.Authentication.ApplicationCoreLayer.Entity;
using Hrm.Authentication.Infrastructure.Data;

namespace Hrm.Authentication.Infrastructure.Repository
{
	public class UserRoleRepositoryAsync : IUserRoleRepositoryAsync
    {
        DapperDbContext dbContext;
        public UserRoleRepositoryAsync()
        {
            dbContext = new DapperDbContext();

        }

        public async Task<int> DeleteAsync(int id)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "DELETE FROM UserRole WHERE Id = @id";
                return await conn.ExecuteAsync(query, new { Id = id });
            }
        }

        public async Task<IEnumerable<UserRole>> GetAllAsync()
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "SELECT Id,UserId,RoleId FROM UserRole";
                return await conn.QueryAsync<UserRole>(query);
            }
        }

        public async Task<UserRole> GetByIdAsync(int id)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "SELECT Id,UserId,RoleId FROM UserRole Where Id=@id";
                return await conn.QuerySingleOrDefaultAsync<UserRole>(query, new { Id = id });
            }
        }

        public async Task<int> InsertAsync(UserRole entity)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "INSERT INTO UserRole VALUES (@Id,@UserId,@RoleId)";
                return await conn.ExecuteAsync(query, entity);
            }
        }

        public async Task<int> UpdateAsync(UserRole entity)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "UPDATE UserRole SET UserId=@UserId,RoleId=@RoleId WHERE Id=@id";
                return await conn.ExecuteAsync(query, entity);
            }
        }
    }
}

