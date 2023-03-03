using System;
using Hrm.Recruiting.ApplicationCoreLayer.Contract.Repository;
using Hrm.Recruiting.ApplicationCoreLayer.Contract.Service;
using Hrm.Recruiting.ApplicationCoreLayer.Entity;
using Hrm.Recruiting.ApplicationCoreLayer.Model.Request;
using Hrm.Recruiting.ApplicationCoreLayer.Model.Response;

namespace Hrm.Recruiting.Infrastructure.Service
{
    public class SubmissionStatusServiceAsync : ISubmissionStatusServiceAsync
    {
        private readonly ISubmissionStatusRepositoryAsync submissionStatusRepositoryAsync;

        public SubmissionStatusServiceAsync(ISubmissionStatusRepositoryAsync _submissionStatusRepositoryAsync)
        {
            submissionStatusRepositoryAsync = _submissionStatusRepositoryAsync;
        }

        public Task<int> AddSubmissionStatusAsync(SubmissionStatusRequestModel model)
        {
            SubmissionStatus submissionstatus = new SubmissionStatus()
            {
                Description = model.Description
               
            };
            return submissionStatusRepositoryAsync.InsertAsync(submissionstatus);
        }

        public Task<int> DeleteSubmissionStatusAsync(int id)
        {
            return submissionStatusRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<SubmissionStatusResponseModel>> GetAllSubmissionStatusAsync()
        {
            var result = await submissionStatusRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new SubmissionStatusResponseModel()
                {
                    Id = x.Id,
                    Description = x.Description
                });
            }
            return null;
        }

        public async Task<SubmissionStatusResponseModel> GetSubmissionStatusByIdAsync(int id)
        {
            var result = await submissionStatusRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new SubmissionStatusResponseModel()
                {
                    Id = result.Id,
                    Description = result.Description
                };
            }
            return null;
        }

        public Task<int> UpdateSubmissionStatusAsync(SubmissionStatusRequestModel model)
        {
            SubmissionStatus submissionstatus = new SubmissionStatus()
            {
                Id = model.Id,
                Description = model.Description
            };
            return submissionStatusRepositoryAsync.UpdateAsync(submissionstatus);
        }

    }
}

