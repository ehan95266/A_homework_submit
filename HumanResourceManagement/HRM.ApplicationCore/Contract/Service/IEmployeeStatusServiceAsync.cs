using System;
using HRM.ApplicationCore.Model.Request;
using HRM.ApplicationCore.Model.Response;

namespace HRM.ApplicationCore.Contract.Service
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

