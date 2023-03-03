using System;
using Hrm.Recruiting.ApplicationCoreLayer.Model.Request;
using Hrm.Recruiting.ApplicationCoreLayer.Model.Response;
namespace Hrm.Recruiting.ApplicationCoreLayer.Contract.Service
{
	public interface IJobCategoryServiceAsync
	{
        Task<int> AddJobCategoryAsync(JobCategoryRequestModel model);
        Task<int> UpdateJobCategoryAsync(JobCategoryRequestModel model);
        Task<int> DeleteJobCategoryAsync(int id);
        Task<JobCategoryResponseModel> GetJobCategoryByIdAsync(int id);
        Task<IEnumerable<JobCategoryResponseModel>> GetAllJobCategoryAsync();

    }
}

