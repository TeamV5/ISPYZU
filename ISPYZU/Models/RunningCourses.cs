using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ISPYZU.Models
{
    public class RunningCourses
    {

        [Required]
        [Key]
        [Display(Name = "RC Id-")]
        [MinLength(1, ErrorMessage = "{0} cant't be less than {1}")]
        [MaxLength(50, ErrorMessage = "{0}cant't be more than{1}")]
        public string RCId { get; set; }

        [Required]
        [Display(Name = "Course Id")]
        //[MinLength(1, ErrorMessage = "{0} cant't be less than {1}")]
       // [MaxLength(50, ErrorMessage = "{0}cant't be more than{1}")]
       // [ForeignKey("Courses")]
        public string CourseId { get; set; }

        [Required]
        [Display(Name = "teacher ID-")]
     //   [MinLength(1, ErrorMessage = "{0} cant't be less than {1}")]
      //  [MaxLength(50, ErrorMessage = "{0}cant't be more than{1}")]
        //[ForeignKey("Teacher")]
        public string TeacherId { get; set; }

        [ForeignKey(nameof(CourseId))]
        public virtual Courses Courses { get; set; }

        [ForeignKey(nameof(TeacherId))]
        public virtual Teacher Teacher { get; set; }
    }
}