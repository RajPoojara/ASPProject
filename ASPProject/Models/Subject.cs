using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ASPProject.Models;

namespace ASPProject.Models
{
    [Table("Subjects")]
    public class Subject
    {
        [Display(Name = "Subject ID")]
        [Key]
        public int SubjectId { get; set; }

        [Display(Name = "Subject Name")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string SubjectName { get; set; }
    }
}
