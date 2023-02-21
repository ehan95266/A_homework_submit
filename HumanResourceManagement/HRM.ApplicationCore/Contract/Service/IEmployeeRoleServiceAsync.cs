using System;
using HRM.ApplicationCore.Model.Request;
using HRM.ApplicationCore.Model.Response;

namespace HRM.ApplicationCore.Contract.Service
{
	public class IEmployeeRoleServiceAsync
	{
		public IEmployeeRoleServiceAsync()
		{
            Task<int> AddEmployeeRoleAsync(EmployeeRoleRequestModel model);
            Task<int> UpdateEmployeeRoleAsync(EmployeeRoleRequestModel model);
            Task<int> DeleteEmployeeRoleAsync(int id);
            Task<EmployeeRoleResponseModel> GetEmployeeRoleByIdAsync(int id);
            Task<IEnumerable<EmployeeRoleResponseModel>> GetAllEmployeeRolesAsync();
        }
	}
}

