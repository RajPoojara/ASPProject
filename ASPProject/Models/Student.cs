using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ASPProject.Models;

namespace ASPProject.Models
{
    [Table("Students")]
    public class Student
    {

        // Foreign Key to user info table --> user id
        // [Display(Name = "User ID")]
        // [ForeignKey]
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // public int UserId { get; set; }

        [Display(Name = "Enrollment No.")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        public int EnrollmentNo { get; set; }

        [Display(Name = "Date Of Birth")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [DataType(DataType.Date)]
        public string DateOfBirth { get; set; }

        [Display(Name = "Department")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        public string Department { get; set; }


    }
}
