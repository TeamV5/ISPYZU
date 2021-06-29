using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ISPYZU.Models
{
    public class Majors
    {

        [Required]
        [Key]
        [Display(Name = "Major Id-")]
        [MinLength(4, ErrorMessage = "{0} cant't be less than {1}")]
        [MaxLength(10, ErrorMessage = "{0}cant't be more than{1}")]
        public string MajorId { get; set; }

        [Required]
        [Display(Name = "Major Name-")]
        [MinLength(4, ErrorMessage = "{0} cant't be less than {1}")]
        [MaxLength(10, ErrorMessage = "{0}cant't be more than{1}")]
        public string MajorName { get; set; }

        [Required]
      //  [ForeignKey(nameof(College))]
        [Display(Name = "College Name-")]
        [MinLength(4, ErrorMessage = "{0} cant't be less than {1}")]
        [MaxLength(10, ErrorMessage = "{0}cant't be more than{1}")]
        public string CollegeName { get; set; }
    }
}