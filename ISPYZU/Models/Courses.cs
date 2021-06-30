using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ISPYZU.Models
{
    public class Courses
    {
        [Required]
        [Key]
        [Display(Name = "Course Id-")]
        [MinLength(1, ErrorMessage = "{0} cant't be less than {1}")]
        [MaxLength(50, ErrorMessage = "{0}cant't be more than{1}")]
        public string CourseId { get; set; }

        [Required]
        [Display(Name = "Course Name-")]
        [MinLength(1, ErrorMessage = "{0} cant't be less than {1}")]
        [MaxLength(50, ErrorMessage = "{0}cant't be more than{1}")]
        public string CourseName { get; set; }

        [Required]
        [Display(Name = " Major Id-")]
      //  [MinLength(1, ErrorMessage = "{0} cant't be less than {1}")]
     //   [MaxLength(10, ErrorMessage = "{0}cant't be more than{1}")]
        [ForeignKey("Majors")]
        public string MajorId { get; set; }


        public virtual Majors Majors { get; set; }


    }
}