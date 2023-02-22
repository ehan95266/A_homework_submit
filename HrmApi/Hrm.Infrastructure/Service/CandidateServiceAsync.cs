using System;
using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Contract.Service;
using Hrm.ApplicationCore.Entity;
using Hrm.ApplicationCore.Model.Request;
using Hrm.ApplicationCore.Model.Response;

namespace Hrm.Infrastructure.Service
{
    public class CandidateServiceAsync : ICandidateServiceAsync
    {
        private readonly ICandidateRepositoryAsync candidateRepositoryAsync; //creates object of ICandidateRepository

        public CandidateServiceAsync(ICandidateRepositoryAsync _candidateRepositoryAsync) //injecting ICandidateRepository type to the constructor
        {
            candidateRepositoryAsync = _candidateRepositoryAsync; //this is object of CandidateRepositoryAsync class
        }

        public Task<int> AddCandidateAsync(CandidateRequestModel model)
        {
            Candidate candidate = new Candidate()
            {
                //give properties to the candidate object
                FirstName = model.FirstName,
                LastName = model.LastName,
                Mobile = model.Mobile,
                EmailId = model.EmailId

            };
            return candidateRepositoryAsync.InsertAsync(candidate);
        }

        public Task<int> DeleteCandidateAsync(int id)
        {
            return candidateRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<CandidateResponseModel>> GetAllCandidatesAsync() //return a list of candidates
        {
            var result = await candidateRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                result.ToList().Select(x => new CandidateResponseModel()
                { Id = x.Id, EmailId = x.EmailId, FirstName = x.FirstName, LastName = x.LastName, Mobile = x.Mobile });
            }
            return null;
        }

        public async Task<CandidateResponseModel> GetCandidateByIdAsync(int id)
        {
            var result = await candidateRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new CandidateResponseModel()
                {
                    Id = result.Id,
                    FirstName = result.FirstName,
                    LastName = result.LastName,
                    Mobile = result.Mobile,
                    EmailId = result.EmailId
                };
            }
            return null;

        }

        public Task<int> UpdateCandidateAsync(CandidateRequestModel model) //requesting the data
        {
            Candidate candidate = new Candidate()
            {
                Id = model.Id,
                EmailId = model.EmailId,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Mobile = model.Mobile
            };
            return candidateRepositoryAsync.UpdateAsync(candidate);
        }
    }
}

