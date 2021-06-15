using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISPYZU.Models
{
  public class Role
  {
    [Required]
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { set; get; }

    [Required]
    [MaxLength(10, ErrorMessage = "{0}长度不能超过{1}个字符!")]
    public string RoleName { set; get; }

    [Required]
    [MaxLength(30, ErrorMessage = "{0}长度不能超过{1}个字符!")]
    public string Description { set; get; }

    public virtual ICollection<User> Users { get; set; }
  }
}