using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRM.ApplicationCore.Contract.Service;
using HRM.ApplicationCore.Model.Request;
using HRM.ApplicationCore.Model.Response;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRM.WebMVCApp.Controllers //control the way that a user interacts with an MVC application.
    //a controller determines what response to send back to a user when a user makes browser request. 
{
    public class CandidateController : Controller
    {
        private readonly ICandidateServiceAsync candidateServiceAsync;

        public CandidateController(ICandidateServiceAsync _candidateServiceAsync)
        {
            candidateServiceAsync = _candidateServiceAsync;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var CandidateCollection = await candidateServiceAsync.GetAllCandidatesAsync();
            return View(CandidateCollection);
        }

        public IActionResult Create() // default HttpGet
        {
            return View();
        }

        [HttpPost] //when method="post", this method must be called
        public async Task<IActionResult> Create(CandidateRequestModel model)
        {
            if (ModelState.IsValid)
            {
                //add candidate to database
                await candidateServiceAsync.AddCandidateAsync(model);
                //after added candidate, display the list of candidates to index page
                return RedirectToAction("Index");


            }
            return View(model); //show error message
        }

        public async Task<IActionResult> Edit(int id) //can be performed in url
        {
            var result = await candidateServiceAsync.GetCandidateByIdAsync(id);
            return View(result);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(CandidateRequestModel model) //performed in html table
        {
            try
            {
                await candidateServiceAsync.UpdateCandidateAsync(model);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(model);
            }
        }

        public async Task<IActionResult> Delete(int id) //httpGet, this will retrieve the data first to client
                                                        //to make sure this is the data they want to delete
        {
            var result = await candidateServiceAsync.GetCandidateByIdAsync(id);
            return View(result);
        }

        [HttpPost] //post allows to create detail to allow users to double check if the selected data is what they want to delete
        public async Task<IActionResult> Delete(CandidateResponseModel model) //after data is deleted, user will be redirected to index page
        {
            await candidateServiceAsync.DeleteCandidateAsync(model.Id);
            return RedirectToAction("Index");
        }

    }

}

