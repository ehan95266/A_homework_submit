using System;
using Hrm.Onboarding.ApplicationCoreLayer.Model.Request;
using Hrm.Onboarding.ApplicationCoreLayer.Model.Response;
namespace Hrm.Onboarding.ApplicationCoreLayer.Contract.Service
{
	public interface IEmployeeRoleServiceAsync
	{
        Task<int> AddEmployeeRoleAsync(EmployeeRoleRequestModel model);
        Task<int> UpdateEmployeeRoleAsync(EmployeeRoleRequestModel model);
        Task<int> DeleteEmployeeRoleAsync(int id);
        Task<EmployeeRoleResponseModel> GetEmployeeRoleByIdAsync(int id);
        Task<IEnumerable<EmployeeRoleResponseModel>> GetAllEmployeeRoleAsync();
    }
}

