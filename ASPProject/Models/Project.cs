using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ASPProject.Models;

namespace ASPProject.Models
{
    [Table("Project")]
    public class Project
    {
        [Display(Name = "Project ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectId { get; set; }

        [Display(Name = "Project Name")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string ProjectName { get; set; }

        [Display(Name = "Project Descripton")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [StringLength(150, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string ProjectDiscription { get; set; }

        // Foerign key to subject table --> subject id
        // [Display(Name = "Subject ID")]
        // [ForeignKey]
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // public int SubjectId { get; set; }

        // foerign key to faculty's --> users id 
        // [Display(Name = "Professor ID")]
        // [ForeignKey]
        // [Required(ErrorMessage = "{0} cannot be empty.")]
        // public int ProfessorId { get; set; }

        // foerign key to student's --> user id
        // [Display(Name = "Student ID")]
        // [ForeignKey]
        // [Required(ErrorMessage = "{0} cannot be empty.")]
        // public int StudentId { get; set; }

        // foerign key to faculty's --> users id 
        // [Display(Name = "Mentor ID")]
        // [ForeignKey]
        // [Required(ErrorMessage = "{0} cannot be empty.")]
        // public int MentorId { get; set; }
    }
}
