using System;
using HRM.ApplicationCore.Model.Request;
using HRM.ApplicationCore.Model.Response;
namespace HRM.ApplicationCore.Contract.Service
{
	public interface IJobRequirementServiceAsync
	{
        Task<int> AddJobRequirementAsync(JobRequirementRequestModel model);
        Task<int> UpdateJobRequirementAsync(JobRequirementRequestModel model);
        Task<int> DeleteJobRequirementAsync(int id);
        Task<JobRequirementResponseModel> GetJobRequirementByIdAsync(int id);
        Task<IEnumerable<JobRequirementResponseModel>> GetAllJobRequirementsAsync();
    }
}

