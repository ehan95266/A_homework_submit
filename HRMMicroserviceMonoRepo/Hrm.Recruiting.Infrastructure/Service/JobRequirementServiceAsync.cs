using System;
using Hrm.Recruiting.ApplicationCoreLayer.Contract.Repository;
using Hrm.Recruiting.ApplicationCoreLayer.Contract.Service;
using Hrm.Recruiting.ApplicationCoreLayer.Entity;
using Hrm.Recruiting.ApplicationCoreLayer.Model.Request;
using Hrm.Recruiting.ApplicationCoreLayer.Model.Response;

namespace Hrm.Recruiting.Infrastructure.Service
{
    public class JobRequirementServiceAsync : IJobRequirementServiceAsync
    {
        private readonly IJobRequirementRepositoryAsync jobRequirementRepositoryAsync;

        public JobRequirementServiceAsync(IJobRequirementRepositoryAsync _jobRequirementRepositoryAsync)
        {
            jobRequirementRepositoryAsync = _jobRequirementRepositoryAsync;
        }

        public Task<int> AddJobRequirementAsync(JobRequirementRequestModel model)
        {
            JobRequirement jobRequirement = new JobRequirement()
            {
                Title = model.Title,
                IsActive = model.IsActive,
                Description = model.Description,
                TotalPosition = model.TotalPosition,
                HiringManagerId = model.HiringManagerId,
                HiringManagerName = model.HiringManagerName,
                StartDate = model.StartDate,
                ClosedOn = model.ClosedOn,
                ClosedReason = model.ClosedReason,
                CreatedOn = model.CreatedOn,
                JobCategoryId = model.JobCategoryId


            };
            return jobRequirementRepositoryAsync.InsertAsync(jobRequirement);

        }

        public Task<int> DeleteJobRequirementAsync(int id)
        {
            return jobRequirementRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<JobRequirementResponseModel>> GetAllJobRequirementAsync()
        {
            var result = await jobRequirementRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new JobRequirementResponseModel()
                {
                    Id = x.Id,
                    Title = x.Title,
                    IsActive = x.IsActive,
                    Description = x.Description,
                    TotalPosition = x.TotalPosition,
                    HiringManagerId = x.HiringManagerId,
                    HiringManagerName = x.HiringManagerName,
                    StartDate = x.StartDate,
                    ClosedOn = x.ClosedOn,
                    ClosedReason = x.ClosedReason,
                    CreatedOn = x.CreatedOn,
                    JobCategoryId = x.JobCategoryId
                });
            }
            return null;
        }

        public async Task<JobRequirementResponseModel> GetJobRequirementByIdAsync(int id)
        {
            var result = await jobRequirementRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new JobRequirementResponseModel()
                {
                    Id = result.Id,
                    Title = result.Title,
                    IsActive = result.IsActive,
                    Description = result.Description,
                    TotalPosition = result.TotalPosition,
                    HiringManagerId = result.HiringManagerId,
                    HiringManagerName = result.HiringManagerName,
                    StartDate = result.StartDate,
                    ClosedOn = result.ClosedOn,
                    ClosedReason = result.ClosedReason,
                    CreatedOn = result.CreatedOn,
                    JobCategoryId = result.JobCategoryId
                };
            }
            return null;
        }

        public Task<int> UpdateJobRequirementAsync(JobRequirementRequestModel model)
        {
            JobRequirement jobRequirement = new JobRequirement()
            {
                Id = model.Id,
                Title = model.Title,
                IsActive = model.IsActive,
                Description = model.Description,
                TotalPosition = model.TotalPosition,
                HiringManagerId = model.HiringManagerId,
                HiringManagerName = model.HiringManagerName,
                StartDate = model.StartDate,
                ClosedOn = model.ClosedOn,
                ClosedReason = model.ClosedReason,
                CreatedOn = model.CreatedOn,
                JobCategoryId = model.JobCategoryId
            };
            return jobRequirementRepositoryAsync.InsertAsync(jobRequirement);
        }
    }
}

