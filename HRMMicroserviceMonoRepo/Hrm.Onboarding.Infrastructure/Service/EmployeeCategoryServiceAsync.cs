using System;
using Hrm.Onboarding.ApplicationCoreLayer.Contract.Repository;
using Hrm.Onboarding.ApplicationCoreLayer.Contract.Service;
using Hrm.Onboarding.ApplicationCoreLayer.Entity;
using Hrm.Onboarding.ApplicationCoreLayer.Model.Request;
using Hrm.Onboarding.ApplicationCoreLayer.Model.Response;

namespace Hrm.Onboarding.Infrastructure.Service
{
    public class EmployeeCategoryServiceAsync : IEmployeeCategoryServiceAsync
    {
        private readonly IEmployeeCategoryRepositoryAsync employeeCategoryRepositoryAsync;

        public EmployeeCategoryServiceAsync(IEmployeeCategoryRepositoryAsync _employeeCategoryRepositoryAsync)
        {
            employeeCategoryRepositoryAsync = _employeeCategoryRepositoryAsync;
        }

        public Task<int> AddEmployeeCategoryAsync(EmployeeCategoryRequestModel model)
        {
            EmployeeCategory employeeCategory = new EmployeeCategory()
            {

                Description = model.Description

            };
            return employeeCategoryRepositoryAsync.InsertAsync(employeeCategory);
        }

        public Task<int> DeleteEmployeeCategoryAsync(int id)
        {
            return employeeCategoryRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<EmployeeCategoryResponseModel>> GetAllEmployeeCategoryAsync()
        {
            var result = await employeeCategoryRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new EmployeeCategoryResponseModel()
                {
                    Id = x.Id,
                    Description = x.Description
                });
            }
            return null;
        }

        public async Task<EmployeeCategoryResponseModel> GetEmployeeCategoryByIdAsync(int id)
        {
            var result = await employeeCategoryRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new EmployeeCategoryResponseModel()
                {
                    Id = result.Id,
                    Description = result.Description
                };
            }
            return null;

        }

        public Task<int> UpdateEmployeeCategoryAsync(EmployeeCategoryRequestModel model)
        {
            EmployeeCategory employeeCategory = new EmployeeCategory()
            {
                Id = model.Id,
                Description = model.Description
            };
            return employeeCategoryRepositoryAsync.UpdateAsync(employeeCategory);
        }
    }
}

