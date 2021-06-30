using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ISPYZU.Models
{
    public class CourseEnrolled
    {
        [Required]
        [Key]
        [Display(Name = "CE Id-")]
        [MinLength(1, ErrorMessage = "{0} cant't be less than {1}")]
        [MaxLength(50, ErrorMessage = "{0}cant't be more than{1}")]
        public string CEId { get; set; }

        [Required]
        [Display(Name = "Student ID-")]
      //  [MinLength(1, ErrorMessage = "{0} cant't be less than {1}")]
     //   [MaxLength(50, ErrorMessage = "{0}cant't be more than{1}")]
        public string StudentId { get; set; }

        [Required]
        [Display(Name = "course ID")]
        //  [ForeignKey(nameof(course))]
       // [MinLength(1, ErrorMessage = "{0} cant't be less than {1}")]
       // [MaxLength(50, ErrorMessage = "{0}cant't be more than{1}")]
        public string CourseId { get; set; }

        [Required]
        [Display(Name = "Teacher ID-")]
        //  [ForeignKey(nameof(course))]
       // [MinLength(1, ErrorMessage = "{0} cant't be less than {1}")]
      //  [MaxLength(50, ErrorMessage = "{0}cant't be more than{1}")]
        public string TeacherId { get; set; }



        [ForeignKey(nameof(StudentId))]
        public virtual Student Student { get; set; }

        [ForeignKey(nameof(TeacherId))]
        public virtual Teacher Teacher { get; set; }

        [ForeignKey(nameof(CourseId))]
        public virtual Courses Courses { get; set; }
    }
}