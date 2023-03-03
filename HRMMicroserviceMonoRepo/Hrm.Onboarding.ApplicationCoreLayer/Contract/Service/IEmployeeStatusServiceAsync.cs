using System;
using Hrm.Onboarding.ApplicationCoreLayer.Model.Request;
using Hrm.Onboarding.ApplicationCoreLayer.Model.Response;
namespace Hrm.Onboarding.ApplicationCoreLayer.Contract.Service
{
	public interface IEmployeeStatusServiceAsync
	{
        Task<int> AddEmployeeStatusAsync(EmployeeStatusRequestModel model);
        Task<int> UpdateEmployeeStatusAsync(EmployeeStatusRequestModel model);
        Task<int> DeleteEmployeeStatusAsync(int id);
        Task<EmployeeStatusResponseModel> GetEmployeeStatusByIdAsync(int id);
        Task<IEnumerable<EmployeeStatusResponseModel>> GetAllEmployeeStatusAsync();
    }
}

