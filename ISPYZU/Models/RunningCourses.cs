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
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "RC Id-")]
        [MinLength(4, ErrorMessage = "{0} cant't be less than {1}")]
        [MaxLength(10, ErrorMessage = "{0}cant't be more than{1}")]
        public string RCId { get; set; }

        [Required]
        [Display(Name = "Course Name-")]
        //  [ForeignKey(nameof(course))]
        [MinLength(4, ErrorMessage = "{0} cant't be less than {1}")]
        [MaxLength(10, ErrorMessage = "{0}cant't be more than{1}")]
        public string CourseName { get; set; }

        [Required]
        [Display(Name = "teacher Name-")]
        //  [ForeignKey(nameof(teacher))]
        [MinLength(4, ErrorMessage = "{0} cant't be less than {1}")]
        [MaxLength(10, ErrorMessage = "{0}cant't be more than{1}")]
        public string TeacherName { get; set; }
    }
}