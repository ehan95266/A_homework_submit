﻿using System;
using HRM.ApplicationCore.Model.Request;
using HRM.ApplicationCore.Model.Response;
namespace HRM.ApplicationCore.Contract.Service
{
	public interface IFeedbackServiceAsync
	{
        Task<int> AddFeedbackAsync(FeedbackRequestModel model);
        Task<int> UpdateFeedbackAsync(FeedbackRequestModel model);
        Task<int> DeleteFeedbackAsync(int id);
        Task<FeedbackResponseModel> GetFeedbackByIdAsync(int id);
        Task<IEnumerable<FeedbackResponseModel>> GetAllFeedbacksAsync();
    }
}

