using System;
using Hrm.Recruiting.ApplicationCoreLayer.Contract.Repository;
using Hrm.Recruiting.ApplicationCoreLayer.Contract.Service;
using Hrm.Recruiting.ApplicationCoreLayer.Entity;
using Hrm.Recruiting.ApplicationCoreLayer.Model.Request;
using Hrm.Recruiting.ApplicationCoreLayer.Model.Response;

namespace Hrm.Recruiting.Infrastructure.Service
{
    public class JobCategoryServiceAsync : IJobCategoryServiceAsync
    {
        private readonly IJobCategoryRepositoryAsync jobCategoryRepositoryAsync;

        public JobCategoryServiceAsync(IJobCategoryRepositoryAsync _jobCategoryRepositoryAsync)
        {
            jobCategoryRepositoryAsync = _jobCategoryRepositoryAsync;
        }

        public Task<int> AddJobCategoryAsync(JobCategoryRequestModel model)
        {
            JobCategory jobCategory = new JobCategory()
            {
                Title = model.Title,
                IsActive = model.IsActive,
                Description = model.Description
            };
            return jobCategoryRepositoryAsync.InsertAsync(jobCategory);
        }

        public Task<int> DeleteJobCategoryAsync(int id)
        {
            return jobCategoryRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<JobCategoryResponseModel>> GetAllJobCategoryAsync()
        {
            var result = await jobCategoryRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new JobCategoryResponseModel()
                { Id = x.Id, Title = x.Title, IsActive = x.IsActive, Description = x.Description });
            }
            return null;
        }

        public async Task<JobCategoryResponseModel> GetJobCategoryByIdAsync(int id)
        {
            var result = await jobCategoryRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new JobCategoryResponseModel()
                {
                    Id = result.Id,
                    Title = result.Title,
                    IsActive = result.IsActive,
                    Description = result.Description
                };
            }
            return null;
        }

        public Task<int> UpdateJobCategoryAsync(JobCategoryRequestModel model)
        {
            JobCategory jobCategory = new JobCategory()
            {
                Id = model.Id,
                Title = model.Title,
                IsActive = model.IsActive,
                Description = model.Description
            };
            return jobCategoryRepositoryAsync.UpdateAsync(jobCategory);
        }
    }
}

