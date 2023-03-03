using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.Recruiting.ApplicationCoreLayer.Model.Request
{
	public class JobCategoryRequestModel
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        public bool IsActive { get; set; } = true;


    }
}

