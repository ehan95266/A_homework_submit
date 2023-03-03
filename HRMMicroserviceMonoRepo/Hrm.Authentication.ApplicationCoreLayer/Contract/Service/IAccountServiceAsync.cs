using System;
using Hrm.Authentication.ApplicationCoreLayer.Model.Request;
using Hrm.Authentication.ApplicationCoreLayer.Model.Response;

namespace Hrm.Authentication.ApplicationCoreLayer.Contract.Service
{
	public interface IAccountServiceAsync
	{
        Task<int> AddAccountAsync(AccountRequestModel model);
        Task<int> UpdateAccountAsync(AccountRequestModel model);
        Task<int> DeleteAccountAsync(int id);
        Task<AccountResponseModel> GetAccountByIdAsync(int id);
        Task<IEnumerable<AccountResponseModel>> GetAllAccountAsync();
    }
}

