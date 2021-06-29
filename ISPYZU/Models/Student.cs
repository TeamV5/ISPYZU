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
    {   /*
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //  public int SerialId { set; get; }
                ***For auto generate a id ***
        */
        [Required]
        [Key]
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
       // [ForeignKey("Genders")]
        public string Gender { get; set; }

        [DisplayName("Major_ID")]
        [Required]
        [MaxLength(12, ErrorMessage = "{0}cant't be more than{1}")]
        //[ForeignKey("Majors")]
        public string MajorId { get; set; }

        [DisplayName("College_ID")]
        [Required]
      //  [ForeignKey("Colleges")]  // look at the down below public virtual colleges it comes from there 
        [MaxLength(12, ErrorMessage = "{0}cant't be more than{1}")]
        public string CollageId { get; set; }

        [DisplayName("Session year")]
        [Required]
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


            // these are for the foriegn key in the  collegeId,gender
    //    public virtual Colleges Colleges { get; set; }
    //    public virtual Genders Genders { get; set; }
     //   public virtual Majors Majors { get; set; }
    }
}