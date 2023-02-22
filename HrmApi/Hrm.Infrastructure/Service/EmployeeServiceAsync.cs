using System;
using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Contract.Service;
using Hrm.ApplicationCore.Entity;
using Hrm.ApplicationCore.Model.Request;
using Hrm.ApplicationCore.Model.Response;

namespace Hrm.Infrastructure.Service
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
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmailId = model.EmailId,
                DOB = model.DOB,
                SSN = model.SSN,
                CurrentAddress = model.CurrentAddress,
                Mobile = model.Mobile,
                HireDate = model.HireDate,
                EndDate = model.EndDate,
                EmployeeRoleId = model.EmployeeTypeId,
                EmployeeTypeId = model.EmployeeTypeId,
                EmployeeStatusId = model.EmployeeStatusId,
                ManagerId = model.ManagerId
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
                    EmailId = x.EmailId,
                    DOB = x.DOB,
                    SSN = x.SSN,
                    CurrentAddress = x.CurrentAddress,
                    Mobile = x.Mobile,
                    HireDate = x.HireDate,
                    EndDate = x.EndDate,
                    EmployeeRoleId = x.EmployeeTypeId,
                    EmployeeTypeId = x.EmployeeTypeId,
                    EmployeeStatusId = x.EmployeeStatusId,
                    ManagerId = (int)x.ManagerId
                });
            }
            return null;
        }

        //public async Task<IEnumerable<EmployeeResponseModel>> GetAllEmployeesAsync()
        //{
        //    var result = await employeeRepositoryAsync.GetAllAsync();
        //    if (result != null)
        //    {
        //        return result.ToList().Select(x => new EmployeeResponseModel()
        //        {
        //            Id = x.Id,
        //            FirstName = x.FirstName,
        //            LastName = x.LastName,
        //            EmailId = x.EmailId,
        //            DOB = x.DOB,
        //            SSN = x.SSN,
        //            CurrentAddress = x.CurrentAddress,
        //            Mobile = x.Mobile,
        //            HireDate = x.HireDate,
        //            EndDate = x.EndDate,
        //            EmployeeRoleId = x.EmployeeTypeId,
        //            EmployeeTypeId = x.EmployeeTypeId,
        //            EmployeeStatusId = x.EmployeeStatusId,
        //            ManagerId = (int)x.ManagerId
        //        });
        //    }
        //    return null;
        //}

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
                    EmailId = result.EmailId,
                    DOB = result.DOB,
                    SSN = result.SSN,
                    CurrentAddress = result.CurrentAddress,
                    Mobile = result.Mobile,
                    HireDate = result.HireDate,
                    EndDate = result.EndDate,
                    EmployeeRoleId = result.EmployeeTypeId,
                    EmployeeTypeId = result.EmployeeTypeId,
                    EmployeeStatusId = result.EmployeeStatusId,
                    ManagerId = (int)result.ManagerId
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
                EmailId = model.EmailId,
                DOB = model.DOB,
                SSN = model.SSN,
                CurrentAddress = model.CurrentAddress,
                Mobile = model.Mobile,
                HireDate = model.HireDate,
                EndDate = model.EndDate,
                EmployeeRoleId = model.EmployeeTypeId,
                EmployeeTypeId = model.EmployeeTypeId,
                EmployeeStatusId = model.EmployeeStatusId,
                ManagerId = model.ManagerId
            };
            return employeeRepositoryAsync.UpdateAsync(employee);
        }
    }
}

