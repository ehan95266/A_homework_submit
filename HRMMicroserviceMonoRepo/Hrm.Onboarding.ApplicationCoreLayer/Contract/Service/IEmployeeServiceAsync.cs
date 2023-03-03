using System;
using Hrm.Onboarding.ApplicationCoreLayer.Model.Request;
using Hrm.Onboarding.ApplicationCoreLayer.Model.Response;
namespace Hrm.Onboarding.ApplicationCoreLayer.Contract.Service
{
	public interface IEmployeeServiceAsync
	{
        Task<int> AddEmployeeAsync(EmployeeRequestModel model);
        Task<int> UpdateEmployeeAsync(EmployeeRequestModel model);
        Task<int> DeleteEmployeeAsync(int id);
        Task<EmployeeResponseModel> GetEmployeeByIdAsync(int id);
        Task<IEnumerable<EmployeeResponseModel>> GetAllEmployeeAsync();
    }
}

