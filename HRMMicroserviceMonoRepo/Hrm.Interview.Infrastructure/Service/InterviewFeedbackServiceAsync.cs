using System;
using Hrm.Interview.ApplicationCoreLayer.Contract.Repository;
using Hrm.Interview.ApplicationCoreLayer.Contract.Service;
using Hrm.Interview.ApplicationCoreLayer.Entity;
using Hrm.Interview.ApplicationCoreLayer.Model.Reponse;
using Hrm.Interview.ApplicationCoreLayer.Model.Request;

namespace Hrm.Interview.Infrastructure.Service
{
    public class InterviewFeedbackServiceAsync : IInterviewFeedbackServiceAsync
    {
        private readonly IInterviewFeedbackRepositoryAsync interviewFeedbackRepositoryAsync;

        public InterviewFeedbackServiceAsync(IInterviewFeedbackRepositoryAsync _interviewFeedbackRepositoryAsync)
        {
            interviewFeedbackRepositoryAsync = _interviewFeedbackRepositoryAsync;
        }

        public Task<int> AddInterviewFeedbackAsync(InterviewFeedbackRequestModel model)
        {
            InterviewFeedback interviewFeedback = new InterviewFeedback()
            {
                Rating = model.Rating,
                Comment = model.Comment

            };
            return interviewFeedbackRepositoryAsync.InsertAsync(interviewFeedback);
        }

        public Task<int> DeleteInterviewFeedbackAsync(int id)
        {
            return interviewFeedbackRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<InterviewFeedbackResponseModel>> GetAllInterviewFeedbackAsync()
        {
            var result = await interviewFeedbackRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new InterviewFeedbackResponseModel()
                { Id = x.Id, Rating = x.Rating,Comment=x.Comment
                });
            }
            return null;
        }

        public async Task<InterviewFeedbackResponseModel> GetInterviewFeedbackByIdAsync(int id)
        {
            var result = await interviewFeedbackRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new InterviewFeedbackResponseModel()
                {
                    Id = result.Id,
                    Rating = result.Rating,
                    Comment=result.Comment

                };
            }
            return null;

        }

        public Task<int> UpdateInterviewFeedbackAsync(InterviewFeedbackRequestModel model)
        {
            InterviewFeedback interviewFeedback = new InterviewFeedback()
            {
                Id = model.Id,
                Rating = model.Rating,
                Comment=model.Comment

            };
            return interviewFeedbackRepositoryAsync.UpdateAsync(interviewFeedback);

        }
    }
}

