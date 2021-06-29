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
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "CE Id-")]
        [MinLength(4, ErrorMessage = "{0} cant't be less than {1}")]
        [MaxLength(10, ErrorMessage = "{0}cant't be more than{1}")]
        public string CEId { get; set; }

        [Required]
        [Display(Name = "Student ID-")]
        //  [ForeignKey(nameof(student))]
        [MinLength(4, ErrorMessage = "{0} cant't be less than {1}")]
        [MaxLength(10, ErrorMessage = "{0}cant't be more than{1}")]
        public string StudentId { get; set; }

        [Required]
        [Display(Name = "course Name-")]
        //  [ForeignKey(nameof(course))]
        [MinLength(4, ErrorMessage = "{0} cant't be less than {1}")]
        [MaxLength(10, ErrorMessage = "{0}cant't be more than{1}")]
        public string CourseName { get; set; }

        [Required]
        [Display(Name = "Teacher ID-")]
        //  [ForeignKey(nameof(course))]
        [MinLength(4, ErrorMessage = "{0} cant't be less than {1}")]
        [MaxLength(10, ErrorMessage = "{0}cant't be more than{1}")]
        public string TeacherId { get; set; }
    }
}