using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ISPYZU.Models
{
    public class Genders
    {
        [Key]
        [Required]
        public string Gender { set; get; }

        [DisplayName("gender")]
        [Required]
        [MaxLength(15)]
       // [Index("IX_Gender_GenderName", IsUnique = true)]
        public string GenderName { get; set; }

 
       
    }
}