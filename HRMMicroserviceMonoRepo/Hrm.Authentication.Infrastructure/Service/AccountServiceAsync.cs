using System;
using Hrm.Authentication.ApplicationCoreLayer.Contract.Repository;
using Hrm.Authentication.ApplicationCoreLayer.Contract.Service;
using Hrm.Authentication.ApplicationCoreLayer.Entity;
using Hrm.Authentication.ApplicationCoreLayer.Model.Request;
using Hrm.Authentication.ApplicationCoreLayer.Model.Response;

namespace Hrm.Authentication.Infrastructure.Service
{
    public class AccountServiceAsync : IAccountServiceAsync
    {
        private readonly IAccountRepositoryAsync AccountRepositoryAsync;

        public AccountServiceAsync(IAccountRepositoryAsync _AccountRepositoryAsync)
        {
            AccountRepositoryAsync = _AccountRepositoryAsync;
        }

        public Task<int> AddAccountAsync(AccountRequestModel model)
        {
            Account account = new Account()
            {
                Id = model.Id,
                RoleId = model.RoleId,
                EmployeeId = model.EmployeeId,
                EmailId = model.EmailId,
                FirstName = model.FirstName,
                LastName = model.LastName,
                HashPassword = model.HashPassword
            };
            return AccountRepositoryAsync.InsertAsync(account);
        }

        public Task<int> DeleteAccountAsync(int id)
        {
            return AccountRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<AccountResponseModel>> GetAllAccountAsync()
        {
            var result = await AccountRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new AccountResponseModel()
                {
                    Id = x.Id,
                    RoleId = x.RoleId,
                    EmployeeId = x.EmployeeId,
                    EmailId = x.EmailId,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    HashPassword = x.HashPassword
                });
            }
            return null;
        }

        public async Task<AccountResponseModel> GetAccountByIdAsync(int id)
        {
            var result = await AccountRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new AccountResponseModel()
                {
                    Id = result.Id,
                    RoleId = result.RoleId,
                    EmployeeId = result.EmployeeId,
                    EmailId = result.EmailId,
                    FirstName = result.FirstName,
                    LastName = result.LastName,
                    HashPassword = result.HashPassword
                };
            }
            return null;
        }

        public Task<int> UpdateAccountAsync(AccountRequestModel model)
        {
            Account account = new Account()
            {
                Id = model.Id,
                RoleId = model.RoleId,
                EmployeeId = model.EmployeeId,
                EmailId = model.EmailId,
                FirstName = model.FirstName,
                LastName = model.LastName,
                HashPassword = model.HashPassword
            };
            return AccountRepositoryAsync.UpdateAsync(account);
        }

    }
}

