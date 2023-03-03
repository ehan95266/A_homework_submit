using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Authentication.ApplicationCoreLayer.Model.Request
{
	public class RoleRequestModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        
        public string Name { get; set; }
        [Required(ErrorMessage ="Description is required")]
        
        public string Description { get; set; }
    }
}

