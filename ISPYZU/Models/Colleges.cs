using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ISPYZU.Models
{
    public class Colleges
    {
        

        [Required]
        [Key]
        [Display(Name = "College Id-")]
        [MinLength(1, ErrorMessage = "{0} cant't be less than {1}")]
        [MaxLength(50, ErrorMessage = "{0}cant't be more than{1}")]
        public string CollegeId { get; set; }

        [Required]
        [Display(Name = "College Name-")]
        [MinLength(1, ErrorMessage = "{0} cant't be less than {1}")]
        [MaxLength(50, ErrorMessage = "{0}cant't be more than{1}")]
        public string CollegeName { get; set; }

    }
}