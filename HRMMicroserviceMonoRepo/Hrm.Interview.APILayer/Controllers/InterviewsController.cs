using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hrm.Interview.ApplicationCoreLayer.Contract.Service;
using Hrm.Interview.ApplicationCoreLayer.Model.Request;
using Hrm.Interview.ApplicationCoreLayer.ModelAsync;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hrm.Interview.APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewController : ControllerBase
    {
        private readonly IConfiguration config;
        private readonly IInterviewsServiceAsync InterviewsServiceAsync;
        private readonly HttpClient httpClient = new HttpClient();

        public InterviewController(IConfiguration _config,IInterviewsServiceAsync _InterviewsServiceAsync)
        {
            config = _config;
            InterviewsServiceAsync = _InterviewsServiceAsync;
        }

        [HttpPost]
        public async Task<IActionResult> Post(InterviewsRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await InterviewsServiceAsync.AddInterviewsAsync(model);
                return Ok(model);
            }
            return BadRequest(model);
        }


        [HttpGet]
        public async Task<IActionResult> GetCandidate()
        {
            httpClient.BaseAddress = new Uri(config.GetSection("RecruitApiUrl").Value);
            var result = await httpClient.GetFromJsonAsync<IEnumerable<CandidateModel>>(httpClient.BaseAddress + "candidate");
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetSubmission()
        {
            httpClient.BaseAddress = new Uri(config.GetSection("RecruitApiUrl").Value);
            var result = await httpClient.GetFromJsonAsync<IEnumerable<SubmissionModel>>(httpClient.BaseAddress + "submission");
            return Ok(result);
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await InterviewsServiceAsync.GetAllInterviewsAsync();
            return Ok(result);
        }


        // GET: api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}

