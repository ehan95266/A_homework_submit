using System;
using Hrm.Onboarding.ApplicationCoreLayer.Contract.Repository;
using Hrm.Onboarding.ApplicationCoreLayer.Contract.Service;
using Hrm.Onboarding.ApplicationCoreLayer.Entity;
using Hrm.Onboarding.ApplicationCoreLayer.Model.Request;
using Hrm.Onboarding.ApplicationCoreLayer.Model.Response;

namespace Hrm.Onboarding.Infrastructure.Service
{
    public class EmployeeStatusServiceAsync : IEmployeeStatusServiceAsync
    {
        private readonly IEmployeeStatusRepositoryAsync employeeStatusRepositoryAsync;

        public EmployeeStatusServiceAsync(IEmployeeStatusRepositoryAsync _employeeStatusRepositoryAsync)
        {
            employeeStatusRepositoryAsync = _employeeStatusRepositoryAsync;
        }

        public Task<int> AddEmployeeStatusAsync(EmployeeStatusRequestModel model)
        {
            EmployeeStatus employeeStatus = new EmployeeStatus()
            {

                Description = model.Description,
                ABBR = model.ABBR
               

            };
            return employeeStatusRepositoryAsync.InsertAsync(employeeStatus);
        }

        public Task<int> DeleteEmployeeStatusAsync(int id)
        {
            return employeeStatusRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<EmployeeStatusResponseModel>> GetAllEmployeeStatusAsync()
        {
            var result = await employeeStatusRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new EmployeeStatusResponseModel()
                {
                    Id = x.Id,
                    Description = x.Description,
                    ABBR = x.ABBR
                });
            }
            return null;
        }

        public async Task<EmployeeStatusResponseModel> GetEmployeeStatusByIdAsync(int id)
        {
            var result = await employeeStatusRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new EmployeeStatusResponseModel()
                {
                    Id = result.Id,
                    Description = result.Description,
                    ABBR = result.ABBR
                };
            }
            return null;

        }

        public Task<int> UpdateEmployeeStatusAsync(EmployeeStatusRequestModel model)
        {
            EmployeeStatus employeeStatus = new EmployeeStatus()
            {
                Id = model.Id,
                Description = model.Description,
                ABBR = model.ABBR
            };
            return employeeStatusRepositoryAsync.UpdateAsync(employeeStatus);
        }
    }
}

