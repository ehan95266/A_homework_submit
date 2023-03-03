using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hrm.Recruiting.ApplicationCoreLayer.Contract.Service;
using Hrm.Recruiting.ApplicationCoreLayer.Model.Request;
using Hrm.Recruiting.ApplicationCoreLayer.ModelAsync;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hrm.Recruiting.APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobRequirementController : ControllerBase
    {
        HttpClient httpClient = new HttpClient();
        private readonly IConfiguration configuration;
        private readonly IJobRequirementServiceAsync JobRequirementServiceAsync;

        public JobRequirementController(IConfiguration _configuration,IJobRequirementServiceAsync _JobRequirementServiceAsync)
        {
            configuration = _configuration;
            JobRequirementServiceAsync = _JobRequirementServiceAsync;
        }

        [HttpPost]
        public async Task<IActionResult> Post(JobRequirementRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await JobRequirementServiceAsync.AddJobRequirementAsync(model);
                return Ok(model);
            }
            return BadRequest(model);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await JobRequirementServiceAsync.GetAllJobRequirementAsync();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployee()
        {
            httpClient.BaseAddress = new Uri(configuration.GetSection("OnboardingApiUrl").Value);
            var result = await httpClient.GetFromJsonAsync<IEnumerable<EmployeeModel>>("OnboardingApiUrl" + "employee");
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

