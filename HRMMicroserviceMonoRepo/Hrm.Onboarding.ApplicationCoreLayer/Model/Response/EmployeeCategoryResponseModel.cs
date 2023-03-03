using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Onboarding.ApplicationCoreLayer.Model.Response
{
	public class EmployeeCategoryResponseModel
	{
        public int Id { get; set; }
       

        public string Description { get; set; }
    }
}

