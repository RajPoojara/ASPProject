using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ASPProject.Models;

namespace ASPProject.Models
{
    [Table("Submission Details")]
    public class SubmissionDetail
    {
        [Display(Name = "Submit ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubmitId { get; set; }

        // [Display(Name = "Project ID")]
        // [ForeignKey()]
        // []
        // public int ProjectId { get; set; }

        [Display(Name ="Submission Descripton")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [StringLength(100, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string SubmissionDiscription { get; set; }

        [Display(Name = "Submission Date")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [DataType(DataType.Date)]
        public string SubmissionDate { get; set; }

        [Display(Name = "Upload File")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string UploadFile { get; set; }

        [Display(Name = "Status")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        public bool Status { get; set; }

        [Display(Name = "Reviewed")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        public bool Reviewed { get; set; }

        [Display(Name = "Review Remarks")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [StringLength(100, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string ReviewRemarks { get; set; }
    }
}
