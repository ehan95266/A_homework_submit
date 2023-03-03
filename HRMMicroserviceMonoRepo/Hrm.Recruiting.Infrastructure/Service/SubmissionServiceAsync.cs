using System;
using Hrm.Recruiting.ApplicationCoreLayer.Contract.Repository;
using Hrm.Recruiting.ApplicationCoreLayer.Contract.Service;
using Hrm.Recruiting.ApplicationCoreLayer.Entity;
using Hrm.Recruiting.ApplicationCoreLayer.Model.Request;
using Hrm.Recruiting.ApplicationCoreLayer.Model.Response;

namespace Hrm.Recruiting.Infrastructure.Service
{
    public class SubmissionServiceAsync : ISubmissionServiceAsync
    {
        private readonly ISubmissionRepositoryAsync submissionRepositoryAsync;

        public SubmissionServiceAsync(ISubmissionRepositoryAsync _submissionRepositoryAsync)
        {
            submissionRepositoryAsync = _submissionRepositoryAsync;
        }

        public Task<int> AddSubmissionAsync(SubmissionRequestModel model)
        {
            Submission submission = new Submission()
            {
                CandidateId = model.CandidateId,
                JobRequirementId = model.JobRequirementId,
                SubmittedOn = model.SubmittedOn,
                SubmissionStatusId = model.SubmissionStatusId,
                ConfirmedOn = model.ConfirmedOn,
                RejectedOn = model.RejectedOn
            };
            return submissionRepositoryAsync.InsertAsync(submission);
        }

        public Task<int> DeleteSubmissionAsync(int id)
        {
            return submissionRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<SubmissionResponseModel>> GetAllSubmissionAsync()
        {
            var result = await submissionRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new SubmissionResponseModel()
                { Id = x.Id,
                  CandidateId = x.CandidateId,
                  JobRequirementId = x.JobRequirementId,
                  SubmittedOn = x.SubmittedOn,
                  SubmissionStatusId = x.SubmissionStatusId,
                  ConfirmedOn = x.ConfirmedOn,
                  RejectedOn = x.RejectedOn
                });
            }
            return null;
        }

        public async Task<SubmissionResponseModel> GetSubmissionByIdAsync(int id)
        {
            var result = await submissionRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new SubmissionResponseModel()
                {
                    Id = result.Id,
                    CandidateId = result.CandidateId,
                    JobRequirementId = result.JobRequirementId,
                    SubmittedOn = result.SubmittedOn,
                    SubmissionStatusId = result.SubmissionStatusId,
                    ConfirmedOn = result.ConfirmedOn,
                    RejectedOn = result.RejectedOn
                };
            }
            return null;
        }

        public Task<int> UpdateSubmissionAsync(SubmissionRequestModel model)
        {
            Submission submission = new Submission()
            {
                Id = model.Id,
                CandidateId = model.CandidateId,
                JobRequirementId = model.JobRequirementId,
                SubmittedOn = model.SubmittedOn,
                SubmissionStatusId = model.SubmissionStatusId,
                ConfirmedOn = model.ConfirmedOn,
                RejectedOn = model.RejectedOn
            };
            return submissionRepositoryAsync.UpdateAsync(submission);
        }

    }
}

