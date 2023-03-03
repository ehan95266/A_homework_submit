using System;
using Hrm.Onboarding.ApplicationCoreLayer.Model.Request;
using Hrm.Onboarding.ApplicationCoreLayer.Model.Response;

namespace Hrm.Onboarding.ApplicationCoreLayer.Contract.Service
{
	public interface IEmployeeCategoryServiceAsync
	{
        Task<int> AddEmployeeCategoryAsync(EmployeeCategoryRequestModel model);
        Task<int> UpdateEmployeeCategoryAsync(EmployeeCategoryRequestModel model);
        Task<int> DeleteEmployeeCategoryAsync(int id);
        Task<EmployeeCategoryResponseModel> GetEmployeeCategoryByIdAsync(int id);
        Task<IEnumerable<EmployeeCategoryResponseModel>> GetAllEmployeeCategoryAsync();
    }
}

