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
        [MinLength(1, ErrorMessage = "{0} cant't be less than {1}")]
        [MaxLength(50, ErrorMessage = "{0}cant't be more than{1}")]
        public string MajorId { get; set; }

        [Required]
        [Display(Name = "Major Name-")]
        [MinLength(1, ErrorMessage = "{0} cant't be less than {1}")]
        [MaxLength(50, ErrorMessage = "{0}cant't be more than{1}")]
        public string MajorName { get; set; }

        [Required]
        
        [Display(Name = "College ID")]
        [MinLength(1, ErrorMessage = "{0} cant't be less than {1}")]
        [MaxLength(50, ErrorMessage = "{0}cant't be more than{1}")]
       // [ForeignKey("Colleges")]
        public string CollegeId { get; set; }


        [ForeignKey(nameof(CollegeId))]
        public virtual Colleges Colleges { get; set; }






    }
}