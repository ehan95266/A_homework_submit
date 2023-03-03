using System;
using Hrm.Interview.ApplicationCoreLayer.Contract.Repository;
using Hrm.Interview.ApplicationCoreLayer.Contract.Service;
using Hrm.Interview.ApplicationCoreLayer.Entity;
using Hrm.Interview.ApplicationCoreLayer.Model.Reponse;
using Hrm.Interview.ApplicationCoreLayer.Model.Request;

namespace Hrm.Interview.Infrastructure.Service
{
    public class InterviewsServiceAsync : IInterviewsServiceAsync
    {
        private readonly IInterviewsRepositoryAsync interviewsRepositoryAsync;

        public InterviewsServiceAsync(IInterviewsRepositoryAsync _interviewsRepositoryAsync)
        {
            interviewsRepositoryAsync = _interviewsRepositoryAsync;
        }

        public Task<int> AddInterviewsAsync(InterviewsRequestModel model)
        {
            Interviews interviews = new Interviews()
            {
                SubmissionId = model.SubmissionId,
                RecruiterId = model.RecruiterId,
                ScheduledOn = model.ScheduledOn,
                InterviewRound = model.InterviewRound,
                InterviewTypeId = model.InterviewTypeId,
                InterviewStatusId = model.InterviewStatusId,
                InterviewerId = model.InterviewerId
            };
            return interviewsRepositoryAsync.InsertAsync(interviews);
        }

        public Task<int> DeleteInterviewsAsync(int id)
        {
            return interviewsRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<InterviewsResponseModel>> GetAllInterviewsAsync()
        {
            var result = await interviewsRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new InterviewsResponseModel()
                {
                    Id = x.Id,
                    SubmissionId = x.SubmissionId,
                    RecruiterId = x.RecruiterId,
                    ScheduledOn = x.ScheduledOn,
                    InterviewRound = x.InterviewRound,
                    InterviewTypeId = x.InterviewTypeId,
                    InterviewStatusId = x.InterviewStatusId,
                    InterviewerId = x.InterviewerId
                });
            }
            return null;

        }

        public async Task<InterviewsResponseModel> GetInterviewsByIdAsync(int id)
        {
            var result = await interviewsRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new InterviewsResponseModel()
                {
                    Id = result.Id,
                    SubmissionId = result.SubmissionId,
                    RecruiterId = result.RecruiterId,
                    ScheduledOn = result.ScheduledOn,
                    InterviewRound = result.InterviewRound,
                    InterviewTypeId = result.InterviewTypeId,
                    InterviewStatusId = result.InterviewStatusId,
                    InterviewerId = result.InterviewerId
                };
            }
            return null;
        }

        public Task<int> UpdateInterviewsAsync(InterviewsRequestModel model)
        {
            Interviews interviews = new Interviews()
            {
                Id = model.Id,
                SubmissionId = model.SubmissionId,
                RecruiterId = model.RecruiterId,
                ScheduledOn = model.ScheduledOn,
                InterviewRound = model.InterviewRound,
                InterviewTypeId = model.InterviewTypeId,
                InterviewStatusId = model.InterviewStatusId,
                InterviewerId = model.InterviewerId
            };
            return interviewsRepositoryAsync.UpdateAsync(interviews);
        }
    }
}

