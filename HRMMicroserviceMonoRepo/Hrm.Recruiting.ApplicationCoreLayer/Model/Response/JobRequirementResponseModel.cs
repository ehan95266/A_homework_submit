using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.Recruiting.ApplicationCoreLayer.Model.Response
{
	public class JobRequirementResponseModel
	{
        public int Id { get; set; }


        public string Title { get; set; }


        public string Description { get; set; }

        public int TotalPosition { get; set; }
        public int HiringManagerId { get; set; }


        public string HiringManagerName { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime ClosedOn { get; set; }


        public string? ClosedReason { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;
        [Required]
        public int JobCategoryId { get; set; }
        public bool IsActive { get; set; }

    }
}

