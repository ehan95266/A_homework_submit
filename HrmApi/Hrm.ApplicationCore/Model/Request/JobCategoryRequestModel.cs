using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.ApplicationCore.Model.Request
{
    public class JobCategoryRequestModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]

        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}

