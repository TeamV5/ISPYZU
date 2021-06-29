using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ISPYZU.Models
{
    public class Teacher
    { /*
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        */
        [Key]
        [Required]
        [Display(Name = "Teacher Id-")]
        [MinLength(4, ErrorMessage = "{0} cant't be less than {1}")]
        [MaxLength(4, ErrorMessage = "{0}cant't be more than{1}")]
        public string TeacherId { get; set; }


        [DisplayName("Name")]
        [Required]
        [MaxLength(40, ErrorMessage = "{0}cant't be more than{1}")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Gender")]
        // [ForeignKey(nameof(Gender))]
        public string Gender { get; set; }

        [DisplayName("College_ID")]
        [Required]
        // [ForeignKey(nameof(College))]
        [MaxLength(12, ErrorMessage = "{0}cant't be more than{1}")]
        public string CollageId { get; set; }

        

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