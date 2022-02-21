using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ASPProject.Models;

namespace ASPProject.Models
{
    [Table("Faculty")]
    public class Faculty
    {
        // Foreign Key to user info table --> user id
        // [Display(Name = "User ID")]
        // [ForeignKey]
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // public int UserId { get; set; }

        [Display(Name = "Faculty Type")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        public string FacultyType { get; set; }

        [Display(Name ="Subjects")]
        [Required(ErrorMessage ="{0} cannot be empty.")]
        public string Subjects { get; set; } 
        
    }
}
