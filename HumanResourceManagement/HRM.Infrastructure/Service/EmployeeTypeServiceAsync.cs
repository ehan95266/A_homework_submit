﻿using System;
using HRM.ApplicationCore.Contract.Repository;
using HRM.ApplicationCore.Contract.Service;
using HRM.ApplicationCore.Entity;
using HRM.ApplicationCore.Model.Request;
using HRM.ApplicationCore.Model.Response;

namespace HRM.Infrastructure.Service
{
    public class EmployeeTypeServiceAsync : IEmployeeTypeServiceAsync
    {
        private readonly IEmployeeTypeRepositoryAsync employeeTypeRepositoryAsync;

        public EmployeeTypeServiceAsync(IEmployeeTypeRepositoryAsync _employeeTypeRepositoryAsync)
        {
            employeeTypeRepositoryAsync = _employeeTypeRepositoryAsync;
        }

        public Task<int> AddEmployeeTypeAsync(EmployeeTypeRequestModel model)
        {
            EmployeeType employeeType = new EmployeeType()
            {
                Title = model.Title,
                Description = model.Description,
                IsActive = model.IsActive
            };
            return employeeTypeRepositoryAsync.InsertAsync(employeeType);
        }

        public Task<int> DeleteEmployeeTypeAsync(int id)
        {
            return employeeTypeRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<EmployeeTypeResponseModel>> GetAllEmployeeTypesAsync()
        {
            var result = await employeeTypeRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new EmployeeTypeResponseModel()
                { Id = x.Id, Description = x.Description, IsActive = x.IsActive, Title = x.Title });
            }
            return null;
        }

        public async Task<EmployeeTypeResponseModel> GetEmployeeTypeByIdAsync(int id)
        {
            var result = await employeeTypeRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new EmployeeTypeResponseModel()
                {
                    Id = result.Id,
                    Description = result.Description,
                    Title = result.Title,
                    IsActive = result.IsActive
                };
            }
            return null;

        }

        public Task<int> UpdateEmployeeTypeAsync(EmployeeTypeRequestModel model)
        {
            EmployeeType employeeType = new EmployeeType()
            {
                Title = model.Title,
                Description = model.Description,
                IsActive = model.IsActive
            };
            return employeeTypeRepositoryAsync.UpdateAsync(employeeType);
        }
    }
}

