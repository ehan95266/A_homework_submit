using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Onboarding.ApplicationCoreLayer.Model.Request
{
	public class EmployeeCategoryRequestModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage ="Description is required")]

        public string Description { get; set; }
    }
}

