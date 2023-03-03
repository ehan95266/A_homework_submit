using System;
using Hrm.Onboarding.ApplicationCoreLayer.Contract.Repository;
using Hrm.Onboarding.ApplicationCoreLayer.Contract.Service;
using Hrm.Onboarding.ApplicationCoreLayer.Entity;
using Hrm.Onboarding.ApplicationCoreLayer.Model.Request;
using Hrm.Onboarding.ApplicationCoreLayer.Model.Response;

namespace Hrm.Onboarding.Infrastructure.Service
{
    public class EmployeeServiceAsync : IEmployeeServiceAsync
    {
        private readonly IEmployeeRepositoryAsync employeeRepositoryAsync;

        public EmployeeServiceAsync(IEmployeeRepositoryAsync _employeeRepositoryAsync)
        {
            employeeRepositoryAsync = _employeeRepositoryAsync;
        }

        public Task<int> AddEmployeeAsync(EmployeeRequestModel model)
        {
            Employee employee = new Employee()
            {
                
                FirstName = model.FirstName,
                LastName = model.LastName,
                MiddleName = model.MiddleName,
                EmailId = model.EmailId,
                SSN = model.SSN,
                CurrentAddress = model.CurrentAddress,
                HireDate = model.HireDate,
                EndDate = model.EndDate,
                EmployeeRoleId = model.EmployeeRoleId,
                EmployeeCategoryId = model.EmployeeCategoryId,
                EmployeeStatusId = model.EmployeeStatusId,
                
            };
            return employeeRepositoryAsync.InsertAsync(employee);
        }

        public Task<int> DeleteEmployeeAsync(int id)
        {
            return employeeRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<EmployeeResponseModel>> GetAllEmployeeAsync()
        {
            var result = await employeeRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new EmployeeResponseModel()
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    MiddleName = x.MiddleName,
                    EmailId = x.EmailId,
                    SSN = x.SSN,
                    CurrentAddress = x.CurrentAddress,
                    HireDate = x.HireDate,
                    EndDate = x.EndDate,
                    EmployeeRoleId = x.EmployeeRoleId,
                    EmployeeCategoryId = x.EmployeeCategoryId,
                    EmployeeStatusId = x.EmployeeStatusId,
                });
            }
            return null;
        }

        public async Task<EmployeeResponseModel> GetEmployeeByIdAsync(int id)
        {
            var result = await employeeRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new EmployeeResponseModel()
                {
                    Id = result.Id,
                    FirstName = result.FirstName,
                    LastName = result.LastName,
                    MiddleName = result.MiddleName,
                    EmailId = result.EmailId,
                    SSN = result.SSN,
                    CurrentAddress = result.CurrentAddress,
                    HireDate = result.HireDate,
                    EndDate = result.EndDate,
                    EmployeeRoleId = result.EmployeeRoleId,
                    EmployeeCategoryId = result.EmployeeCategoryId,
                    EmployeeStatusId = result.EmployeeStatusId,
                };
            }
            return null;

        }

        public Task<int> UpdateEmployeeAsync(EmployeeRequestModel model)
        {
            Employee employee = new Employee()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                MiddleName = model.MiddleName,
                EmailId = model.EmailId,
                SSN = model.SSN,
                CurrentAddress = model.CurrentAddress,
                HireDate = model.HireDate,
                EndDate = model.EndDate,
                EmployeeRoleId = model.EmployeeRoleId,
                EmployeeCategoryId = model.EmployeeCategoryId,
                EmployeeStatusId = model.EmployeeStatusId,
            };
            return employeeRepositoryAsync.UpdateAsync(employee);
        }
    }
}

