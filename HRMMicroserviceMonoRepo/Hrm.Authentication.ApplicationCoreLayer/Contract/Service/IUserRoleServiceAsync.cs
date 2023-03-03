using System;
using Hrm.Authentication.ApplicationCoreLayer.Model.Request;
using Hrm.Authentication.ApplicationCoreLayer.Model.Response;
namespace Hrm.Authentication.ApplicationCoreLayer.Contract.Service
{
	public interface IUserRoleServiceAsync
	{
        Task<int> AddUserRoleAsync(UserRoleRequestModel model);
        Task<int> UpdateUserRoleAsync(UserRoleRequestModel model);
        Task<int> DeleteUserRoleAsync(int id);
        Task<UserRoleResponseModel> GetUserRoleByIdAsync(int id); 
        Task<IEnumerable<UserRoleResponseModel>> GetAllUserRoleAsync();
    }
}

