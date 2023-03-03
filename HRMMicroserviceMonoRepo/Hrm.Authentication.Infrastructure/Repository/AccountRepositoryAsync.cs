using System;
using Dapper;
using Hrm.Authentication.ApplicationCoreLayer.Contract.Repository;
using Hrm.Authentication.ApplicationCoreLayer.Entity;
using Hrm.Authentication.Infrastructure.Data;

namespace Hrm.Authentication.Infrastructure.Repository
{
	public class AccountRepositoryAsync : IAccountRepositoryAsync
    {

        DapperDbContext dbContext;
        public AccountRepositoryAsync()
        {
            dbContext = new DapperDbContext();

        }
        public async Task<int> DeleteAsync(int id)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "DELETE FROM Account WHERE Id = @id";
                return await conn.ExecuteAsync(query, new { Id = id });
            }
        }

        public async Task<IEnumerable<Account>> GetAllAsync()
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "SELECT Id, EmployeeId,EmailId,RoleId,FirstName,LastName,Hashpassword FROM Account";
                return await conn.QueryAsync<Account>(query);
            }
        }

        public async Task<Account> GetByIdAsync(int id)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "SELECT Id, EmployeeId,EmailId,RoleId,FirstName,LastName,Hashpassword FROM Account Where Id=@id";
                return await conn.QuerySingleOrDefaultAsync<Account>(query, new { Id=id});
            }
        }

        public async Task<int> InsertAsync(Account entity)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "INSERT INTO Account VALUES (@EmployeeId,@EmailId,@RoleId,@FirstName,@LastName,@Hashpassword)";
                return await conn.ExecuteAsync(query, entity);
            }
        }

        public async Task<int> UpdateAsync(Account entity)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "UPDATE Account SET EmployeeId = @EmployeeId,EmailId=@EmailId,RoleId=@RoleId,FirstName=@FirstName,LastName=@LastName,Hashpassword=@Hashpassword WHERE Id=@id";
                return await conn.ExecuteAsync(query, entity);
            }
        }
    }
}

