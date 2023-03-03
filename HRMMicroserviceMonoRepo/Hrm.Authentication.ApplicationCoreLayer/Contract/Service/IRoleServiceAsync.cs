using System;
using Hrm.Authentication.ApplicationCoreLayer.Model.Request;
using Hrm.Authentication.ApplicationCoreLayer.Model.Response;
namespace Hrm.Authentication.ApplicationCoreLayer.Contract.Service
{
	public interface IRoleServiceAsync
	{
        Task<int> AddRoleAsync(RoleRequestModel model);
        Task<int> UpdateRoleAsync(RoleRequestModel model);
        Task<int> DeleteRoleAsync(int id);
        Task<RoleResponseModel> GetRoleByIdAsync(int id);
        Task<IEnumerable<RoleResponseModel>> GetAllRoleAsync();
    }
}

