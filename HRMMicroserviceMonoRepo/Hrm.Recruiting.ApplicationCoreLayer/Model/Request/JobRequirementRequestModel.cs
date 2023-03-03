using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.Recruiting.ApplicationCoreLayer.Model.Request
{
	public class JobRequirementRequestModel
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        public int TotalPosition { get; set; }
        public int HiringManagerId { get; set; }

        [Required(ErrorMessage = "Hiring manager name is required")]
        public string HiringManagerName { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime ClosedOn { get; set; }


        public string? ClosedReason { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Job category Id is required")]
        public int JobCategoryId { get; set; }
        public bool IsActive { get; set; }

    }
}

