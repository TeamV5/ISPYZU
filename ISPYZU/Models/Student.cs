using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ISPYZU.Models
{
    public class Student
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SerialId { set; get; }

        [Required]
        [Display(Name = "Student Id-")]
        [MinLength(4, ErrorMessage = "{0} cant't be less than {1}")]
        [MaxLength(4, ErrorMessage = "{0}cant't be more than{1}")]
        public string StudentId { get; set; }


        [DisplayName("Name")]
        [Required]
        [MaxLength(40, ErrorMessage = "{0}cant't be more than{1}")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Gender")]
       // [ForeignKey(nameof(Gender))]
        public string Gender { get; set; }

        [DisplayName("Major_ID")]
        [Required]
        // [ForeignKey(nameof(Majors))]
        [MaxLength(12, ErrorMessage = "{0}cant't be more than{1}")]
        public string MajorId { get; set; }

        [DisplayName("College_ID")]
        [Required]
        // [ForeignKey(nameof(College))]
        [MaxLength(12, ErrorMessage = "{0}cant't be more than{1}")]
        public string CollageId { get; set; }

        [DisplayName("Session year")]
        [Required]
        // [ForeignKey(nameof(Session))]
        [MaxLength(12, ErrorMessage = "{0}cant't be more than{1}")]
        public string Session { get; set; }

        [DisplayName("Password")]
        [Required]
        public string Password { get; set; }

        [DisplayName("Email")]
        [Required]
        public string Email { get; set; }
/*
        [DisplayName("Upload Picture")]
        public byte[] Picture { get; set; }
   */
    }
}