using System;
using Hrm.Interview.ApplicationCoreLayer.Contract.Repository;
using Hrm.Interview.ApplicationCoreLayer.Contract.Service;
using Hrm.Interview.ApplicationCoreLayer.Entity;
using Hrm.Interview.ApplicationCoreLayer.Model.Reponse;
using Hrm.Interview.ApplicationCoreLayer.Model.Request;

namespace Hrm.Interview.Infrastructure.Service
{
    public class RecruiterServiceAsync : IRecruiterServiceAsync
    {
        private readonly IRecruiterRepositoryAsync RecruiterRepositoryAsync;

        public RecruiterServiceAsync(IRecruiterRepositoryAsync _RecruiterRepositoryAsync)
        {
            RecruiterRepositoryAsync = _RecruiterRepositoryAsync;
        }

        public Task<int> AddRecruiterAsync(RecruiterRequestModel model)
        {
            Recruiter recruiter = new Recruiter()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmployeeId = model.EmployeeId

            };
            return RecruiterRepositoryAsync.InsertAsync(recruiter);
        }

        public Task<int> DeleteRecruiterAsync(int id)
        {
            return RecruiterRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<RecruiterResponseModel>> GetAllRecruiterAsync()
        {
            var result = await RecruiterRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new RecruiterResponseModel()
                { Id = x.Id, FirstName = x.FirstName, LastName=x.LastName,EmployeeId=x.EmployeeId });
            }
            return null;
        }

        public async Task<RecruiterResponseModel> GetRecruiterByIdAsync(int id)
        {
            var result = await RecruiterRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new RecruiterResponseModel()
                {
                    Id = result.Id,
                    FirstName = result.FirstName,
                    LastName = result.LastName,
                    EmployeeId = result.EmployeeId

                };
            }
            return null;

        }

        public Task<int> UpdateRecruiterAsync(RecruiterRequestModel model)
        {
            Recruiter recruiter = new Recruiter()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmployeeId = model.EmployeeId

            };
            return RecruiterRepositoryAsync.UpdateAsync(recruiter);

        }
    }
}

