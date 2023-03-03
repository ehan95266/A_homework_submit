using System;
using Hrm.Interview.ApplicationCoreLayer.Contract.Repository;
using Hrm.Interview.ApplicationCoreLayer.Contract.Service;
using Hrm.Interview.ApplicationCoreLayer.Entity;
using Hrm.Interview.ApplicationCoreLayer.Model.Reponse;
using Hrm.Interview.ApplicationCoreLayer.Model.Request;

namespace Hrm.Interview.Infrastructure.Service
{
    public class InterviewerServiceAsync : IInterviewerServiceAsync
    {
        private readonly IInterviewerRepositoryAsync interviewerRepositoryAsync;

        public InterviewerServiceAsync(IInterviewerRepositoryAsync _interviewerRepositoryAsync)
        {
            interviewerRepositoryAsync = _interviewerRepositoryAsync;
        }

        public Task<int> AddInterviewerAsync(InterviewerRequestModel model)
        {
            Interviewer interviewer = new Interviewer()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmployeeId = model.EmployeeId
            };
            return interviewerRepositoryAsync.InsertAsync(interviewer);
        }

        public Task<int> DeleteInterviewerAsync(int id)
        {
            return interviewerRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<InterviewerResponseModel>> GetAllInterviewerAsync()
        {
            var result = await interviewerRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new InterviewerResponseModel()
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    EmployeeId = x.EmployeeId
                });
            }
            return null;

        }

        public async Task<InterviewerResponseModel> GetInterviewerByIdAsync(int id)
        {
            var result = await interviewerRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new InterviewerResponseModel()
                {
                    Id = result.Id,
                    FirstName = result.FirstName,
                    LastName = result.LastName,
                    EmployeeId = result.EmployeeId
                };
            }
            return null;
        }

        public Task<int> UpdateInterviewerAsync(InterviewerRequestModel model)
        {
            Interviewer interviewer = new Interviewer()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmployeeId = model.EmployeeId
            };
            return interviewerRepositoryAsync.UpdateAsync(interviewer);
        }
    }
}

