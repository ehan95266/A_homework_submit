using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hrm.Authentication.ApplicationCoreLayer.Contract.Service;
using Hrm.Authentication.ApplicationCoreLayer.Model.Request;
using Hrm.Authentication.Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hrm.Authentication.APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountServiceAsync AccountServiceAsync;

        public AccountController(IAccountServiceAsync _AccountServiceAsync)
        {
            AccountServiceAsync = _AccountServiceAsync;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AccountRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await AccountServiceAsync.AddAccountAsync(model);
                return Ok(model);
            }
            return BadRequest(model);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await AccountServiceAsync.GetAllAccountAsync();
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

