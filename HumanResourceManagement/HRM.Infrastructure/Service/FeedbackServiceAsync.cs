﻿using System;
using HRM.ApplicationCore.Contract.Repository;
using HRM.ApplicationCore.Contract.Service;
using HRM.ApplicationCore.Entity;
using HRM.ApplicationCore.Model.Request;
using HRM.ApplicationCore.Model.Response;

namespace HRM.Infrastructure.Service
{
    public class FeedbackServiceAsync : IFeedbackServiceAsync
    {
            private readonly IFeedbackRepositoryAsync feedbackRepositoryAsync;

            public FeedbackServiceAsync(IFeedbackRepositoryAsync _feedbackRepositoryAsync)
            {
                feedbackRepositoryAsync = _feedbackRepositoryAsync;
            }

            public Task<int> AddFeedbackAsync(FeedbackRequestModel model)
            {
                Feedback feedback = new Feedback()
                {
                    InterviewId = model.InterviewId,
                    Description = model.Description,
                    Hired = model.Hired
                };
                return feedbackRepositoryAsync.InsertAsync(feedback);
            }

            public Task<int> DeleteFeedbackAsync(int id)
            {
                return feedbackRepositoryAsync.DeleteAsync(id);
            }

            public async Task<IEnumerable<FeedbackResponseModel>> GetAllFeedbacksAsync()
            {
                var result = await feedbackRepositoryAsync.GetAllAsync();
                if (result != null)
                {
                    return result.ToList().Select(x => new FeedbackResponseModel()
                    { Id = x.Id, InterviewId = x.InterviewId, Hired = x.Hired, Description = x.Description });
                }
                return null;
            }

            public async Task<FeedbackResponseModel> GetFeedbackByIdAsync(int id)
            {
                var result = await feedbackRepositoryAsync.GetByIdAsync(id);
                if (result != null)
                {
                    return new FeedbackResponseModel()
                    {
                        Id = result.Id,
                        InterviewId = result.InterviewId,
                        Hired = result.Hired,
                        Description = result.Description
                    };
                }
                return null;
            }

            public Task<int> UpdateFeedbackAsync(FeedbackRequestModel model)
            {
                Feedback feedback = new Feedback()
                {
                    Id = model.Id,
                    InterviewId = model.InterviewId,
                    Hired = model.Hired,
                    Description = model.Description
                };
                return feedbackRepositoryAsync.UpdateAsync(feedback);
            }
        
    }
}

